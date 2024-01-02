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
    public partial class Supplier : MetroFramework.Forms.MetroForm
    {
        public string id;
        public Supplier(string id)
        {
            this.id = id;
            InitializeComponent();
        }
        public Supplier()
        {
            InitializeComponent();
        }
        private void New_Data()
        {
            txtProductQuantityForSupplier.Text = "";
            cmbSelectProductForSupplier.SelectedValue = -1;
        }
        private void Load_Data()
        {
            string query = "select Id, Name, BasePrice from Product";
            string error;
            DataTable dtSupplier = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                dgvProductForSupplier.AutoGenerateColumns = false;
                dgvProductForSupplier.DataSource = dtSupplier;
                dgvProductForSupplier.Refresh();
                dgvProductForSupplier.ClearSelection();
                cmbSelectProductForSupplier.DataSource = dtSupplier;
                cmbSelectProductForSupplier.DisplayMember = "Name";
                cmbSelectProductForSupplier.ValueMember = "Id";
                this.New_Data();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }

        private void dgvProductForSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                string productid = dgvProductForSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
               // MessageBox.Show(productid);
               //just checking nothing else
                
            }
        }

        private void btnSellRequest_Click(object sender, EventArgs e)
        {
            if(cmbSelectProductForSupplier.SelectedIndex<0)
            {
                MessageBox.Show("PLEASE SELECT PRODUCT");
                return;
            }
            if(txtProductQuantityForSupplier.Text=="" || txtProductQuantityForSupplier.Text=="0")
            {
                MessageBox.Show("PLEASE SELECT QUANTITY ATLEAST 100 KG");
                return;
            }
            double x;
            try
            {
                x = double.Parse(txtProductQuantityForSupplier.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
           
            string productid = cmbSelectProductForSupplier.SelectedValue.ToString();
            double baseprice = this.getPrice(productid);
            double totalcost = x * baseprice;
            string total = totalcost.ToString();
            string error;
            string query = "Insert into ProductSupplierRequestInfo(ProductIdRequest,SupplierIdRequest,Quantity,TotalCost) values(" + productid + "," + this.id + "," + txtProductQuantityForSupplier.Text +","+ total + ")";
            DataBaseAccess.InsertData(query, out error);
            if(string.IsNullOrEmpty(error))
            {
                MessageBox.Show("THANK YOU FOR YOUR SELL,PLEASE WAITING,WE WILL INFORM SOON");
                return;
            }
            MessageBox.Show("OOPS SOMETHING WENT WRONG");
        }
        private double getPrice(string id)
        {
            string error;
            string query = "select BasePrice from Product where Id=" + id;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error))
            {
                string price = dt.Rows[0][0].ToString();
                double p = Double.Parse(price);
                return p;
            }
            return 0;
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            if (cmbSelectProductForSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("YOU DID NOT CHOOSE ANY PRODUCT, SO PLEASE CHOOSE A PRODUCT WHICH YOU WANT TO SELL");
                return;
            }
            if (txtProductQuantityForSupplier.Text == "")
            {
                MessageBox.Show("YOU DID NOT MENTION HOW MUCH YOU WANT TO SELL TO US.SO,PLEASE CHOOSE ATLEAST 100 KG");
                return;
            }

            double quantity;
            try
            {
                quantity = Double.Parse(txtProductQuantityForSupplier.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string id = cmbSelectProductForSupplier.SelectedValue.ToString();
            double x = this.getPrice(id);
            if(x==0)
            {
                MessageBox.Show("INVALID");
                return;
            }
            double totalpricecalculated = quantity * x;
            txtTotalMoneyGet.Text = totalpricecalculated.ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login logi = new Login();
            logi.Show();
            this.Hide();
        }
    }
}
