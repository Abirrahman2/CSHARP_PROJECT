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
    public partial class ProductInfo : MetroFramework.Forms.MetroForm
    {
        public ProductInfo()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            string query = "select * from Product";
            string error;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                dgvProductView.AutoGenerateColumns = false;
                dgvProductView.DataSource = dt;
                dgvProductView.Refresh();
                dgvProductView.ClearSelection();

            }
            else
            {
                MessageBox.Show(error);

            }

        }
        private void ProductInfo_Load(object sender, EventArgs e)
        {
            this.Load_Data();
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
           
            
            txtProductId.Text= id;
            txtProductName.Text = dt.Rows[0]["Name"].ToString();
            txtProductDescription.Text = dt.Rows[0]["Description"].ToString();
            txtBasePrice.Text = dt.Rows[0]["BasePrice"].ToString();
            txtSellPrice.Text = dt.Rows[0]["SellPrice"].ToString();
            this.Load_Data();
            for(int i=0;i<dgvProductView.Rows.Count;i++)
            {
                if(dgvProductView.Rows[i].Cells[0].Value.ToString()==txtProductId.Text)
                {
                    dgvProductView.Rows[i].Selected = true;
                    break;
                }
            }
            

        }
       

        private void btnBackAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel a = new AdminPanel();
            a.Show();
            this.Hide();
        }
        private void New_Data()
        {
            txtProductId.Text = "";
           txtProductName.Text = "";
           
           txtProductDescription.Text = "";
            txtSellPrice.Text = "";
            txtBasePrice.Text = "";
          

        }
        private void btnNewProductView_Click(object sender, EventArgs e)
        {
            this.New_Data();
        }
        private void search_Product()
        {

            if (txtProductName.Text == "")
            {
                MessageBox.Show("SELECT PRODUCT NAME");
                return;
            }
            string name = txtProductName.Text;
            name = name.ToUpper();
            name = name.Trim();
            string error;
            string query = "select * from Product where Name='" + name + "'";
            var dt = DataBaseAccess.getData(query, out error);

            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return;
            }
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("THERE IS NO PRODUCT IN THIS NAME");
                return;
            }
            string id = dt.Rows[0][0].ToString();

            this.Load_Specific_Product(id);
            



        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            this.search_Product();
            
        }

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            
            this.New_Data();
            this.Load_Data();
        }

        private void dgvProductView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            string id = dgvProductView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Load_Specific_Product(id);
        }
    }
}
