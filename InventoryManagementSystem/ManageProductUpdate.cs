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
    public partial class ManageProductUpdate : MetroFramework.Forms.MetroForm
    {
        public ManageProductUpdate()
        {
            InitializeComponent();
        }
        private void btnBackAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel a = new AdminPanel();
            a.Show();
            this.Hide();
        }
        private void Load_Data()
        {
            string query = "select * from Product";
            string error;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                dgvProductUpdate.AutoGenerateColumns = false;
                dgvProductUpdate.DataSource = dt;
                dgvProductUpdate.Refresh();
                dgvProductUpdate.ClearSelection();

            }
            else
            {
                MessageBox.Show(error);

            }

        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }
        
        private void New_Data()
        {
            txtProductId.Text = "";
            txtProductNameUpdate.Text = "";
            txtProductDescription.Text = "";
            txtBasePrice.Text = "";
            txtSellPrice.Text = "";


        }
        private void btnRefreshProductAdd_Click(object sender, EventArgs e)
        {
            this.Load_Data();
            this.New_Data();

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            if(txtProductId.Text=="")
            {
                MessageBox.Show("PLEASE SELECT THE ROW YOU WANT TO UPDATE");
                return;
            }
           DialogResult result= MessageBox.Show("ARE YOU SURE?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(result==DialogResult.No)
            {
                return;
            }
            string id = txtProductId.Text;
            string updatename = txtProductNameUpdate.Text;
            string updatedescription = txtProductDescription.Text;
            string updatebaseprice = txtBasePrice.Text;
            string updatesellprice = txtSellPrice.Text;
            string error;
            string query = "Update Product set Name='" + updatename + "', Description='" + updatedescription + "' , BasePrice=" + updatebaseprice + ", SellPrice=" + updatesellprice + " where Id=" + id;
            DataBaseAccess.InsertData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("UPDATED SUCCESSFULLY");
            this.Load_Data();
            for(int i=0;i<dgvProductUpdate.Rows.Count;i++)
            {
                if(dgvProductUpdate.Rows[i].Cells[0].Value.ToString()==txtProductId.Text)
                {
                    dgvProductUpdate.Rows[i].Selected = true;
                    break;
                }
            }
        }
        private void Load_Specific_Product(string id)
        {
            string error;
            string query = "select * from Product where Id=" + id;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            txtProductId.Text = id;
           txtProductNameUpdate.Text = dt.Rows[0]["Name"].ToString();
            txtProductDescription.Text = dt.Rows[0]["Description"].ToString();
            txtBasePrice.Text = dt.Rows[0]["BasePrice"].ToString();
            txtSellPrice.Text = dt.Rows[0]["SellPrice"].ToString();

        }

        private void dgvProductUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvProductUpdate.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Load_Specific_Product(id);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ARE YOU SURE THAT YOU WANT TO DELETE THIS ITEM?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(result==DialogResult.No)
            {
                MessageBox.Show("THANK YOU, NEXT TIME");
                return;
            }
            if(txtProductId.Text=="")
            {
                MessageBox.Show("PLEASE SELECT A ROW THAT YOU WANT TO DELETE");
                return;
            }
            string id = txtProductId.Text;
            string error;
            string query = "Delete from Product where Id=" + id;
            DataBaseAccess.InsertData(query, out error);
            if(string.IsNullOrEmpty(error))
            {
                MessageBox.Show("SUCCESSFULLY DELETED THIS PRODUCT");
                this.Load_Data();
                this.New_Data();
            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}
