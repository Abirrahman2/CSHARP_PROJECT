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
    public partial class ProductAdd : MetroFramework.Forms.MetroForm
    {
        public ProductAdd()
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
                dgvProductAdd.AutoGenerateColumns = false;
                dgvProductAdd.DataSource = dt;
                dgvProductAdd.Refresh();
                dgvProductAdd.ClearSelection();

            }
            else
            {
                MessageBox.Show(error);

            }

        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }
        private bool search_Product(string name)
        {

            name = name.ToUpper();
            name = name.Trim();
            string error;
            string query = "select * from Product where Name='" + name + "'";
            var dt = DataBaseAccess.getData(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return false;
            }
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("PRODUCT IS ALREADY EXIST,PLEASE ENTER NEW PRODUCT IF ANY");
                return false;

            }
            

        }
        private void New_Data()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";

            txtProductDescription.Text = "";
            txtBasePrice.Text = "";
            txtSellPrice.Text = "";


        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if(txtProductName.Text=="")
            {
                MessageBox.Show("YOU DID NOT ENTER ANY PRODUCT NAME");
                txtProductName.Focus();
                return;
            }
            if(txtBasePrice.Text=="")
            {
                MessageBox.Show("YOU DID NOT ENTER PRODUCT's BASE PRICE NAME");
                return;
            }
            if(txtSellPrice.Text=="")
            {
                MessageBox.Show("YOU DID NOT ENTER PRODUCT's SELL PRICE NAME");
                return;
            }
            string id;
            string productname = txtProductName.Text;
            string description = txtProductDescription.Text;
            string baseprice = txtBasePrice.Text;
            string sellprice = txtSellPrice.Text;
            string error;
            string query="insert into Product(Name,Description,BasePrice,SellPrice) output inserted.Id values('"+productname+"','"+description+"','"+baseprice+"','"+sellprice+"')";
            DataTable dt;
            if(search_Product(productname))
            {
                dt=DataBaseAccess.getData(query, out error);
                if(string.IsNullOrEmpty(error)==false)
                {
                    MessageBox.Show(error);
                }
                MessageBox.Show("SUCCESSFULLY INSERTED PRODUCT");
                this.Load_Data();
                id = dt.Rows[0][0].ToString();
                txtProductId.Text = id;
                for (int i = 0; i < dgvProductAdd.Rows.Count; i++)
                {
                    if (dgvProductAdd.Rows[i].Cells[0].Value.ToString() == txtProductId.Text)
                    {
                        dgvProductAdd.Rows[i].Selected = true;
                        break;
                    }
                }

            }

        }

        private void btnRefreshProductAdd_Click(object sender, EventArgs e)
        {
            this.Load_Data();
            this.New_Data();

        }
    }
}
