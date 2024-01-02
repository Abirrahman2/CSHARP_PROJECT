using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class InventoryAdd : MetroFramework.Forms.MetroForm
    {
        public InventoryAdd()
        {
            InitializeComponent();
           
        }

        private void btnInventoryEditBack_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Are you sure?", "Disclaimer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
           if(result==DialogResult.Cancel)
            {
                return;
            }
           else if(result==DialogResult.Yes)
            {
                AdminPanel a = new AdminPanel();
                a.Show();
                this.Hide();
            }
            
        }

        

        private void cmbboxInventoryEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbboxInventoryEdit.SelectedIndex!=-1)
            {
                lblInventoryEditDistrict.BackColor = Color.DarkOliveGreen;
            }
        }

        private void Load_Data()
        {
            string query = "select * from Inventory";
            string error;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                dgvInventoryAdd.AutoGenerateColumns = false;
                dgvInventoryAdd.DataSource = dt;
                dgvInventoryAdd.Refresh();
                dgvInventoryAdd.ClearSelection();

            }
            else
            {
                MessageBox.Show(error);
               
            }

        }

        private void btnInventoryRefresh_Click(object sender, EventArgs e)
        {
            this.Load_Data();
            this.New_Data();

        }

        private void InventoryAdd_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }
        private void btnCreateInventory_Click(object sender, EventArgs e)
        {
            if(cmbboxInventoryEdit.SelectedIndex<0)
            {
                MessageBox.Show("YOU DID NOT CHOOSE DISTRICT,PLEASE CHOOSE ONE OF THEM!!");
                return;
            }
            if(txtInventoryAddress.Text=="")
            {
                MessageBox.Show("YOU DID NOT ADD ADDRESS,PLEASE ENTER ADDRESS!!!");
                    return;
            }
            if(txtInventoryCapacity.Text=="")
            {
                MessageBox.Show("YOU DID NOT ADD CAPACITY,PLEASE ENTER CAPACITY IN KG!!!");
                return;
            }
            if(txtMaxCapacity.Text=="")
            {
                MessageBox.Show("YOU DID NOT ADD MAX CAPACITY,PLEASE ENTER CAPACITY IN KG!!!");
                return;
            }
            string district = cmbboxInventoryEdit.SelectedItem.ToString();
            string address = txtInventoryAddress.Text+district;
            string capacity = txtInventoryCapacity.Text;
            string description = txtInventoryDescription.Text;
            string maxcapacity = txtMaxCapacity.Text;
            string error;
            string query = "insert into inventory(Address,Capacity,Description,MaxCapacity) values('" + address + "','" + capacity + "','" + description +"','" +maxcapacity+"')";
            DataBaseAccess.InsertData(query, out error);
            if(string.IsNullOrEmpty(error)==true)
            {
                MessageBox.Show("SUCCESSFULLY INSERTED AN INVENTORY");
                
            }
            else
            {
                MessageBox.Show(error);
            }

        }
        private void Load_Specific_Inventory(string id)
        {
            string error;
            string query = "select * from Inventory where Id=" + id;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return;
            }
            txtInventoryAddress.Text = dt.Rows[0]["Address"].ToString();
            txtInventoryCapacity.Text = dt.Rows[0]["Capacity"].ToString();
            txtInventoryDescription.Text = dt.Rows[0]["Description"].ToString();
            txtMaxCapacity.Text = dt.Rows[0]["MaxCapacity"].ToString();

        }

        private void dgvInventoryAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0)
            {
                return;
            }
            else
            {
                string id = dgvInventoryAdd.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Load_Specific_Inventory(id);
            }
            

        }
        private void New_Data()
        {
            txtInventoryAddress.Text = "";
            txtInventoryCapacity.Text = "";
            txtInventoryDescription.Text = "";
            txtMaxCapacity.Text = "";
            cmbboxInventoryEdit.SelectedIndex = -1;
            dgvInventoryAdd.ClearSelection();

        }

        private void btnInventoryNew_Click(object sender, EventArgs e)
        {
            this.Load_Data();
            this.New_Data();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
