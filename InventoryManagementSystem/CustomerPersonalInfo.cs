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
    public partial class CustomerPersonalInfo : MetroFramework.Forms.MetroForm
    {
        public string myid;
        public CustomerPersonalInfo()
        {
            InitializeComponent();
        }
        public CustomerPersonalInfo(string myid )
        {
            this.myid = myid;
            InitializeComponent();
        }

        private void CustomerPersonalInfo_Load(object sender, EventArgs e)
        {
            string query = "select * from Customer where Id=" + myid;
            string error;
            DataTable dtcustomer = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                string myname = dtcustomer.Rows[0][1].ToString();
                string myemail = dtcustomer.Rows[0][2].ToString();
                string mynumber = dtcustomer.Rows[0][4].ToString();
                string mypassword = dtcustomer.Rows[0][3].ToString();
                txtMyName.Text = myname;
                txtMyEmail.Text = myemail;
                txtMyContact.Text = mynumber;
                
            }
            else
            {
                MessageBox.Show(error);
                
            }
        }
        private string getPass()
        {
            string password;
            string query = "select * from Customer where Id=" + myid;
            string error;
            DataTable dtcustomer = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                
                 password = dtcustomer.Rows[0][3].ToString();
               

            }
            else
            {
                MessageBox.Show(error);
                return null;

            }
            return password;
        }
        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
           if(chkPass.Checked)
            {
                txtMyPassword.Text = getPass();
            }
            else
            {
                txtMyPassword.Text = "";
            }

        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(myid);
            c.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if(txtChangePassword.Text!="")
            {
                string error;
                string query = "Update Customer set Password='" + txtChangePassword.Text + "' Where Id=" + myid;
                DataBaseAccess.InsertData(query, out error);
                if(string.IsNullOrEmpty(error)==false)
                {
                    MessageBox.Show("SOMETHING WENT WRONG,CAN NOT CHANGE PASSWORD");
                    return;
                }
              
            }
            if(txtChangeContact.Text!="")
            {
                string error;
                string query = "Update Customer set MobileNumber='" + txtChangeContact.Text + "Where Id=" + myid;
                DataBaseAccess.InsertData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show("SOMETHING WENT WRONG,CAN NOT CHANGE CONTACT NUMBER");
                    return;
                }

            }
            if (txtChangeName.Text != "")
            {
                string error;
                string query = "Update Customer set Name='" + txtChangeName.Text + "Where Id=" + myid;
                DataBaseAccess.InsertData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show("SOMETHING WENT WRONG,CAN NOT CHANGE YOUR NAME");
                    return;
                }

            }
            MessageBox.Show("SUCCESSFULLY UPDATED YOUR INFORMATION");
        }

        private void btnRefrestUpdate_Click(object sender, EventArgs e)
        {
            string query = "select * from Customer where Id=" + myid;
            string error;
            DataTable dtcustomer = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                string myname = dtcustomer.Rows[0][1].ToString();
                string myemail = dtcustomer.Rows[0][2].ToString();
                string mynumber = dtcustomer.Rows[0][4].ToString();
                string mypassword = dtcustomer.Rows[0][3].ToString();
                txtMyName.Text = myname;
                txtMyEmail.Text = myemail;
                txtMyContact.Text = mynumber;
                txtChangePassword.Text = "";
                txtChangeContact.Text = "";
                txtChangeName.Text = "";

            }
            else
            {
                MessageBox.Show(error);

            }

        }
    }
}
