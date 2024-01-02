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
    public partial class AllProfitView : MetroFramework.Forms.MetroForm
    {
        public AllProfitView()
        {
            InitializeComponent();
        }
        private void Load_Data_OrderDetails()
        {
            string error;
            string query = "select COUNT(*) from [Order]";
            DataTable dt = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error))
            {
                txtTotalOrderFromCustomer.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show(error);
                return;
            }
            string query1 = "select SUM(TotalPrice) from [Order]";
            DataTable dtt = DataBaseAccess.getData(query1, out error);
            if(string.IsNullOrEmpty(error))
            {
                txtTotalAmount.Text = dtt.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show(error);
                return;
            }
            string query2 = "select SUM(TotalQuantity) from OrderDetail";
            DataTable dtTotalQuantity = DataBaseAccess.getData(query2, out error);
            if (string.IsNullOrEmpty(error))
            {
                txtTotalQuantitySold.Text = dtTotalQuantity.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show(error);
               
            }

        }
        private void Load_Data_Supplier_Info()
        {
            string error;
            string query = "select COUNT(DISTINCT Supplier_Id) from ProductSupplierInfo";
            DataTable totalSupplier = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return;
                
            }
            txtTotalSupplier.Text = totalSupplier.Rows[0][0].ToString();
            string query1 = "select SUM(Amount) from ProductSupplierInfo";
            DataTable dtq = DataBaseAccess.getData(query1, out error);
            if (string.IsNullOrEmpty(error))
            {
                txtTotalQuantityFromSupplier.Text = dtq.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show(error);
                return;
            }
            string query2 = "select SUM(Prize) from ProductSupplierInfo";
            DataTable totalSpent = DataBaseAccess.getData(query2, out error);
            if (string.IsNullOrEmpty(error))
            {
                txtTotalMoneySpent.Text = totalSpent.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show(error);
                return;
            }

        }
        private void AllProfitView_Load(object sender, EventArgs e)
        {
            this.Load_Data_OrderDetails();
            this.Load_Data_Supplier_Info();
            txtQuantityLeft.Text = (double.Parse(txtTotalQuantityFromSupplier.Text) - double.Parse(txtTotalQuantitySold.Text)).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
                admin.Show();
            this.Hide();
        }
    }
}
