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
    public partial class Customer :MetroFramework.Forms.MetroForm
    {
        public string id;
        public Customer(string id)
        {
           
            this.id = id;
            InitializeComponent();
        }
        public Customer()
        {
            InitializeComponent();
        }

      private void New_Data()
        {
            txtSearchProductForCustomer.Text = "";
            cmbSelectProductForCustomer.SelectedValue = -1;
            txtTotalPrice.Text = "";
        }
        private void Load_Data()
        {
            string query = "select Id, Name, SellPrice from Product";
            string error;
            DataTable dtcustomer = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                dgvShowProductForCustomer.AutoGenerateColumns = false;
                dgvShowProductForCustomer.DataSource = dtcustomer;
                dgvShowProductForCustomer.Refresh();
                dgvShowProductForCustomer.ClearSelection();
                cmbSelectProductForCustomer.DataSource = dtcustomer;
                cmbSelectProductForCustomer.DisplayMember = "Name";
                cmbSelectProductForCustomer.ValueMember = "Id";
                this.New_Data();
            }
            else
            {
                MessageBox.Show(error);
            }

        }
        private void Customer_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }

        private void pERSONALINFORMATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPersonalInfo personal = new CustomerPersonalInfo(id);
            personal.Show();
            this.Hide();
        }
        private bool Load_Specific_Data(string productName)
        {
            string error;
            string query = "select Id, Name, SellPrice from Product where Name='"+productName+"'";
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                if(dt.Rows.Count==0)
                {
                    return false;
                }
                else
                {
                   
                    return true;

                }
                
            }
            else
            {
                MessageBox.Show(error);
                return false;
            }

        }
        private void btnSearchProductForCustomer_Click(object sender, EventArgs e)
        {
           
            string productname = txtSearchProductForCustomer.Text;
            productname = productname.ToUpper();
            productname = productname.Trim();
            //MessageBox.Show(productname);
           if( this.Load_Specific_Data(productname))
            {
                this.Load_Data();

                for (int i = 0; i < dgvShowProductForCustomer.Rows.Count; i++)
                {
                    if (dgvShowProductForCustomer.Rows[i].Cells[1].Value.ToString() == productname)
                    {
                        dgvShowProductForCustomer.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("PRODUCT DOES NOT EXIST");
            }


        }
        private double getPrice(string id)
        {
            string error;
            string query = "select SellPrice from Product where Id=" + id;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error))
            {
                string price = dt.Rows[0][0].ToString();
                double p = Double.Parse(price);
                return p;
            }
            return 1;
        }
        private void orderDetailQuery(string orderId,string totalprice)
        {
            string productid = cmbSelectProductForCustomer.SelectedValue.ToString();
            string totalquantity = txtProductQuantity.Text;
            string error;
            string query = "Insert Into OrderDetail(OrderId,ProductId,TotalQuantity,TotalPrice) values(" + orderId + "," + productid + "," + totalquantity + "," + totalprice + ")";
            DataBaseAccess.InsertData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show("SOMETHING WENT WRONG");
            }
        }
        private void orderQuery(string totalprice)
        {
            string error;
            DateTime db = Convert.ToDateTime(dtpicker.Text);
            string query="Insert into [Order](Customer_Id,Date,TotalPrice) output inserted.Id values("+this.id+",'"+db.ToString("dd-MMM-yyyy") +"',"+totalprice+")";
          DataTable dtOrderId=  DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error))
            {
                MessageBox.Show("ORDERED SUCCESSFULLY");
                string orderId = dtOrderId.Rows[0][0].ToString();
                this.orderDetailQuery(orderId,totalprice);
            }
            else
            {
                MessageBox.Show("OOPS SOMETHING WRONG HAPPENED");
            }
        }
        private void btnOrderProduct_Click(object sender, EventArgs e)
        {
             if (cmbSelectProductForCustomer.SelectedIndex < 0)
             {
                 MessageBox.Show("YOU DID NOT CHOOSE ANY PRODUCT, SO PLEASE CHOOSE A PRODUCT WHICH YOU WANT TO BUY");
                 return;
             }
             if (txtProductQuantity.Text == "")
             {
                 MessageBox.Show("YOU DID NOT MENTION HOW MUCH YOU WANT. PLEASE CHOOSE ATLEAST 1 KG");
                 return;
             }

             double quantity;
             try
             {
                 quantity = Double.Parse(txtProductQuantity.Text);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return;
             }
             string id = cmbSelectProductForCustomer.SelectedValue.ToString();
             double x = this.getPrice(id);
             if(x==0)
            {
                MessageBox.Show("PLEASE SELECT INTEGER VALUE GREATER THAN ZERO");
                return;
            }
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

        private void btnCalculateTotalPrice_Click(object sender, EventArgs e)
        {
            if (cmbSelectProductForCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("YOU DID NOT CHOOSE ANY PRODUCT, SO PLEASE CHOOSE A PRODUCT WHICH YOU WANT TO BUY");
                return;
            }
            if (txtProductQuantity.Text == "" || txtProductQuantity.Text=="0")
            {
                MessageBox.Show("YOU DID NOT MENTION HOW MUCH YOU WANT. PLEASE CHOOSE ATLEAST 1 KG");
                return;
            }
            double quantity;
            try
            {
                quantity = Double.Parse(txtProductQuantity.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            string id = cmbSelectProductForCustomer.SelectedValue.ToString();
            double x = this.getPrice(id);
            double totalpricecalculated = quantity * x;
            txtTotalPrice.Text = totalpricecalculated.ToString();
        }

        private void oRDERHISTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerOrderHistory ch = new CustomerOrderHistory(this.id);
            ch.Show();
            this.Hide();

        }

        private void mYSELECTIONLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectionListForCustomer scc = new SelectionListForCustomer(this.id);
            scc.Show();
            this.Hide();

        }

        private void btnlogoutcustomer_Click(object sender, EventArgs e)
        {
            Login ll = new Login();
            ll.Show();
            this.Hide();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Load_Data();
            this.New_Data();
        }

        private void btnAddtoList_Click(object sender, EventArgs e)
        {
            if(cmbSelectProductForCustomer.SelectedIndex<0)
            {
                MessageBox.Show("PLEASE CHOOSE PRODUCT THAT YOU WANT TO ADD IN YOUR LIST");
                return;
            }
            string productid = cmbSelectProductForCustomer.SelectedValue.ToString();
            string error;
            string query="insert into SelectionList(CustomerId,ProductNumber) values("+this.id+","+productid+")";
            DataBaseAccess.InsertData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("SUCCESSFULLY INSERTED IN YOUR LIST");
        }
    }
}
