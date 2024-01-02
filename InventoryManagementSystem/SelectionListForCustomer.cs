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
    public partial class SelectionListForCustomer : MetroFramework.Forms.MetroForm
    {
        public string myid;
        public string selectionId;
        public SelectionListForCustomer()
        {
            InitializeComponent();
        }
        public SelectionListForCustomer(string myid)
        {
            this.myid = myid;
            InitializeComponent();
        }

        private void btnBackS_Click(object sender, EventArgs e)
        {
            Customer cc = new Customer(myid);
            cc.Show();
            this.Hide();
        }
        private void New_Data()
        {
            txtProductQuantitySelection.Text = "";
            cmbSelectProductForCustomer.SelectedValue = -1;
            txtTotalPriceSelection.Text = "";
        }
        private void Load_Data()
        {
            string error;
            string query = "select SelectionList.Id 'ID NO', Product.Id 'PRODUCT NO', Product.Name 'PRODUCT NAME',Product.SellPrice 'PRODUCT SELL' from SelecTionList inner join Product on Product.Id=SelectionList.ProductNumber  where CustomerId=" + myid;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show("OOPS SOMETHING WENT WRONG");
            }
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("THERE IS NO SELECTION LIST");
                return;
            }
            dgvSelectionList.AutoGenerateColumns = false;
            dgvSelectionList.DataSource = dt;
            cmbSelectProductForCustomer.DataSource = dt;
            cmbSelectProductForCustomer.DisplayMember = "PRODUCT NAME";
            cmbSelectProductForCustomer.ValueMember = "PRODUCT NO";
            dgvSelectionList.Refresh();
            dgvSelectionList.ClearSelection();
            this.New_Data();
        }
        private void SelectionListForCustomer_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }
        private double getPrice(string id)
        {
            string error;
            string query = "select SellPrice from Product where Id=" + id;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error))
            {
                string price = dt.Rows[0][0].ToString();
                double p = Double.Parse(price);
                return p;
            }
            return 0;
        }
        private void btnOrderSelection_Click(object sender, EventArgs e)
        {
            if (cmbSelectProductForCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("YOU DID NOT CHOOSE ANY PRODUCT, SO PLEASE CHOOSE A PRODUCT WHICH YOU WANT TO BUY");
                return;
            }
            if (txtProductQuantitySelection.Text == "")
            {
                MessageBox.Show("YOU DID NOT MENTION HOW MUCH YOU WANT. PLEASE CHOOSE ATLEAST 1 KG");
                return;
            }

            double quantity;
            try
            {
                quantity = Double.Parse(txtProductQuantitySelection.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            string id = cmbSelectProductForCustomer.SelectedValue.ToString();
            double x = this.getPrice(id);
            double totalpricecalculated = quantity * x;

            var result = MessageBox.Show("DO YOU WANT TO ORDER THIS ITEM?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                MessageBox.Show("OK,NEXT TIME,THANK YOU");
                return;
            }
            string totalprice = totalpricecalculated.ToString();
            this.orderQuery(totalprice);

        }
        private void SelectionListDelete()
        {
            if(selectionId=="")
            {
                MessageBox.Show("PLEASE SELECT ANY OF YOUR LIST");
                return;
            }
            string error;
            string query = "Delete from SelectionList where Id=" + selectionId;
            DataBaseAccess.InsertData(query, out error);
            if(string.IsNullOrEmpty(error))
            {
                MessageBox.Show("DELETED YOUR SELECTED LIST");
                this.Load_Data();
                this.New_Data();
                return;
            }
            MessageBox.Show(error);
        }
        private void orderQuery(string totalprice)
        {
            string error;
            DateTime db = Convert.ToDateTime(dtpicker.Text);
            string query = "Insert into [Order](Customer_Id,Date,TotalPrice) output inserted.Id values(" + this.myid + ",'" + db.ToString("dd-MMM-yyyy") + "'," + totalprice + ")";
            DataTable dtOrderId = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error))
            {
                MessageBox.Show("ORDERED SUCCESSFULLY");
                string orderId = dtOrderId.Rows[0][0].ToString();
                this.orderDetailQuery(orderId, totalprice);
                this.SelectionListDelete();

            }
            else
            {
                MessageBox.Show("OOPS SOMETHING WRONG HAPPENED");
            }
        }
        private void orderDetailQuery(string orderId, string totalprice)
        {
            string productid = cmbSelectProductForCustomer.SelectedValue.ToString();
            string totalquantity = txtProductQuantitySelection.Text;
            string error;
            string query = "Insert Into OrderDetail(OrderId,ProductId,TotalQuantity,TotalPrice) values(" + orderId + "," + productid + "," + totalquantity + "," + totalprice + ")";
            DataBaseAccess.InsertData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("SOMETHING WENT WRONG");
            }

        }

        private void dgvSelectionList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                cmbSelectProductForCustomer.SelectedValue = dgvSelectionList.Rows[e.RowIndex].Cells[1].Value.ToString();
                selectionId = dgvSelectionList.Rows[e.RowIndex].Cells[0].Value.ToString();
                
            }
            else
            {
                selectionId = "";
            }
           
        }

        private void btnCalculateTotalPrice_Click(object sender, EventArgs e)
        {
            if (cmbSelectProductForCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("YOU DID NOT CHOOSE ANY PRODUCT, SO PLEASE CHOOSE A PRODUCT WHICH YOU WANT TO BUY");
                return;
            }
            if (txtProductQuantitySelection.Text == "")
            {
                MessageBox.Show("YOU DID NOT MENTION HOW MUCH YOU WANT. PLEASE CHOOSE ATLEAST 1 KG");
                return;
            }
            double quantity;
            try
            {
                quantity = Double.Parse(txtProductQuantitySelection.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            string id = cmbSelectProductForCustomer.SelectedValue.ToString();
            double x = this.getPrice(id);
            double totalpricecalculated = quantity * x;
            txtTotalPriceSelection.Text = totalpricecalculated.ToString();
        }

        private void btnRefreshSelection_Click(object sender, EventArgs e)
        {
            this.Load_Data();
            this.New_Data();
        }

        private void btnProductSelectionDelete_Click(object sender, EventArgs e)
        {
            
            this.SelectionListDelete();
            
        }
    }
}
