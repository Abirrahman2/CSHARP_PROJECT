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
    public partial class ManageViewCustomer : MetroFramework.Forms.MetroForm
    {
       

        public ManageViewCustomer()
        {
            InitializeComponent();
        }

        private void ManageViewCustomer_Load(object sender, EventArgs e)
        {
            string query = "select Id,Name,Email from Customer";
            string error;
            DataTable dtviewcustomer = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error)==true)
            {
                dgvManageViewCustomer.AutoGenerateColumns = false;
                dgvManageViewCustomer.DataSource = dtviewcustomer;
                dgvManageViewCustomer.Refresh();
                dgvManageViewCustomer.ClearSelection();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnbackviewcustomer_Click(object sender, EventArgs e)
        {
            AdminPanel a = new AdminPanel();
            a.Show();
            this.Hide();
        }
        private void New_Data()
        {
            txtcustomerviewname.Text = "";
            txtTotalAmountPaid.Text = "";
            txtTotalOrderPlaced.Text = "";
            txtViewCustomerEmail.Text = "";
            txtViewCustomerId.Text = "";
        }
        private void btnViewCustomerRefresh_Click(object sender, EventArgs e)
        {
            string query = "select Id,Name,Email from Customer";
            string error;
            DataTable dtviewcustomer = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                dgvManageViewCustomer.AutoGenerateColumns = false;
                dgvManageViewCustomer.DataSource = dtviewcustomer;
                dgvManageViewCustomer.Refresh();
                dgvManageViewCustomer.ClearSelection();
                this.New_Data();
            }
            else
            {
                MessageBox.Show(error);
            }
            

        }

        private void dgvManageViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtViewCustomerId.Text = dgvManageViewCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtViewCustomerEmail.Text = dgvManageViewCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtcustomerviewname.Text = dgvManageViewCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                string error;
                string query = "select COUNT(*) from [Order] where Customer_Id=" + txtViewCustomerId.Text;
                  DataTable dt= DataBaseAccess.getData(query, out error);
                if(string.IsNullOrEmpty(error))
                {
                    txtTotalOrderPlaced.Text = dt.Rows[0][0].ToString();
                    //MessageBox.Show(txtTotalOrderPlaced.Text);
                }
                else
                {
                    MessageBox.Show(error);
                    return;
                }
                string error2;
                string query1= "select SUM(TotalPrice) from [Order] where Customer_Id=" + txtViewCustomerId.Text;
                DataTable dtt = DataBaseAccess.getData(query1, out error2);
                if(string.IsNullOrEmpty(error2))
                {
                    if(dtt.Rows[0][0].ToString()=="")
                    {
                        txtTotalAmountPaid.Text = "0";
                       
                    }
                    else
                    {
                        txtTotalAmountPaid.Text = dtt.Rows[0][0].ToString();
                       

                    }
                    return;
                }
                MessageBox.Show(error);
            }
        }

      
        
    }
    }

