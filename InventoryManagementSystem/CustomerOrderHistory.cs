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
    public partial class CustomerOrderHistory : MetroFramework.Forms.MetroForm
    {
        public string myId;
        public CustomerOrderHistory()
        {
            InitializeComponent();
        }
        public CustomerOrderHistory(string myId)
        {
            this.myId = myId;
            InitializeComponent();

        }
        private void Load_Data()
        {
            string error;
            string query = "select Customer.Name,Date,[Order].TotalPrice,Product.Name 'PRODUCT NAME',OrderDetail.TotalQuantity from [Order] inner join OrderDetail on [order].Id=OrderDetail.OrderId inner join Customer on Customer.Id=" + myId + " inner join Product on Product.Id=OrderDetail.ProductId where [order].Customer_Id=" + myId;
            DataTable dtOrderHistory = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show("OOPS SOMETHING WENT WRONG");
                return;
            }
            dgvOrderHistoryForCustomer.AutoGenerateColumns = false;
            dgvOrderHistoryForCustomer.DataSource = dtOrderHistory;
            dgvOrderHistoryForCustomer.Refresh();
            dgvOrderHistoryForCustomer.ClearSelection();
        }
        private void CustomerOrderHistory_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(this.myId);
            c.Show();
            this.Hide();
        }
         private void New_Data()
        {
            txtPriceForOrderHistory.Text = "";
            txtProductNameForOrderHistory.Text = "";
            txtQuantityForOrderHistory.Text = "";
        }
        private void dgvOrderHistoryForCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProductNameForOrderHistory.Text = dgvOrderHistoryForCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtQuantityForOrderHistory.Text = dgvOrderHistoryForCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPriceForOrderHistory.Text = dgvOrderHistoryForCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();


            }
            else
            {
                this.New_Data();
            }
        }

        private void btnRefreshHistory_Click(object sender, EventArgs e)
        {
            this.Load_Data();
            this.New_Data();
        }
    }
}
