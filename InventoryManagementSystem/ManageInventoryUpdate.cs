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
    public partial class ManageInventoryUpdate : MetroFramework.Forms.MetroForm
    {
        public ManageInventoryUpdate()
        {
            InitializeComponent();
        }

        private void btnInventoryEditBack_Click(object sender, EventArgs e)
        {
            AdminPanel a = new AdminPanel();
            a.Show();
            this.Hide();
        }
        private void Load_Data()
        {
            string query = "select * from Inventory";
            string error;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                dgvInventoryUpdate.AutoGenerateColumns = false;
                dgvInventoryUpdate.DataSource = dt;
                dgvInventoryUpdate.Refresh();
                
                cmbboxInventoryUpdate.SelectedValue = -1;
                dgvInventoryUpdate.ClearSelection();
                

            }
            else
            {
                MessageBox.Show(error);

            }

        }
        private void ManageInventoryUpdate_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }

        private void btnInventoryRefresh_Click(object sender, EventArgs e)
        {
            this.Load_Data();
            this.New_Data();
        }
        private void Load_Specific_Inventory(string id)
        {
            string error;
            string query = "select * from Inventory where Id=" + id;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            txtInventoryId.Text = id;
            txtInventoryAddress.Text = dt.Rows[0]["Address"].ToString();
            txtInventoryCapacity.Text = dt.Rows[0]["Capacity"].ToString();
            txtInventoryDescription.Text = dt.Rows[0]["Description"].ToString();
            txtMaxCapacity.Text = dt.Rows[0]["MaxCapacity"].ToString();
           

        }
        private void dgvInventoryUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                string id = dgvInventoryUpdate.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Load_Specific_Inventory(id);

            }

        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            if(txtInventoryId.Text=="")
            {
                MessageBox.Show("PLEASE SELECT A ROW WHICH YOU WANT TO UPDATE");
                return;

            }
            if(cmbboxInventoryUpdate.SelectedIndex<0)
            {
                MessageBox.Show("please select a district");
                return;
            }
           DialogResult result= MessageBox.Show("ARE YOU SURE YOU WANT TO UPDATE YOUR INVENTORY", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

           if(result==DialogResult.Yes)
            {
                string id = txtInventoryId.Text;
                string updatedAddress = txtInventoryAddress.Text + "," + cmbboxInventoryUpdate.SelectedItem.ToString();
                string updatedCapacity = txtInventoryCapacity.Text;
                string updatedDescription = txtInventoryDescription.Text;
                string maxcapacity = txtMaxCapacity.Text;
                string error;
                string query = "Update Inventory set Address='" + updatedAddress + "', Capacity=" + updatedCapacity + ", Description='" + updatedDescription + "',MaxCapacity='"+maxcapacity+"' where Id=" + id;
                DataBaseAccess.InsertData(query, out error);
                if (string.IsNullOrEmpty(error) == true)
                {
                    MessageBox.Show("SUCCESSFULLY UPDATED AN INVENTORY");

                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            else
            {
                return;
            }
        }
        private void New_Data()
        {
            txtInventoryId.Text = "";
            txtInventoryAddress.Text = "";
            txtInventoryCapacity.Text = "";
            txtInventoryDescription.Text = "";
            txtMaxCapacity.Text = "";
            cmbboxInventoryUpdate.SelectedIndex = -1;
            dgvInventoryUpdate.ClearSelection();

        }
        private void btnInventoryNew_Click(object sender, EventArgs e)
        {
            this.New_Data();
        }

        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS INVENTORY?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(result==DialogResult.No)
            {
                MessageBox.Show("THANK YOU,NEXT TIME");
                return;
            }
            if(string.IsNullOrEmpty(txtInventoryId.Text)==true)
            {
                MessageBox.Show("PLEASE SELECT AN SPECIFIC ROW WHICH YOU WANT TO DELETE");
                return;
            }
            string id = txtInventoryId.Text;
            string error;
            string query = "Delete from Inventory Where Id=" + id;
            DataBaseAccess.InsertData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("SUCCESSFULLY DELETED THIS INVENTORY");
            this.Load_Data();
            this.New_Data();
        }

        private void txtInventoryCapacity_Click(object sender, EventArgs e)
        {

        }
    }
}
