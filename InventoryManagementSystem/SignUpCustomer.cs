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
    public partial class SignUpCustomer : MetroFramework.Forms.MetroForm
    {
        public static int count;
        public SignUpCustomer()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool InsertIntoUserInfo(string username,string useremail,string userpass)
        {
            string error;
            string query = "insert into UserInfo(UserName,Email,Password,UserType) values('" + username + "','" + useremail + "','" + userpass + "','" + "CUSTOMER')";
            DataBaseAccess.InsertData(query, out error);
            if(string.IsNullOrEmpty(error))
            {
                return true;
            }
            return false;
        }
        private void btncreate_Click(object sender, EventArgs e)
        {
            string username = txtSCUN.Text;
            string email = txtSCEMAIL.Text;
            string mobilenumber = txtSCMOBILE.Text;
            string password = txtSCUPASS.Text;
            string cpassword = txtSCUCONFIRMPASS.Text;
            if(cpassword=="" || password=="" || email=="" || mobilenumber=="")
            {
                MessageBox.Show("PLEASE PROVIDE ALL THE INFORMATION");
                metrolblshow.Text ="PLEASE ENTER PASSWORD/EMAIL";
                return;

            }
            if(cpassword != password)
            {
                metrolblshow.Text = "PASSWORD AND CONFIRM PASSWORD ARE NOT SAME";
                return;
            }
            if(cpassword==password && cpassword!="" && email!="")
            {
                string error1;
                string existCustomerCheckQuery = "select * from UserInfo where Email='" + email + "'";
                DataTable dt = DataBaseAccess.getData(existCustomerCheckQuery, out error1);
                if(string.IsNullOrEmpty(error1)==true)
                {
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("EMAIL ALREADY EXIST ,PLEASE CHANGE THE EMAIL");
                        txtSCEMAIL.Text = "";
                        txtSCEMAIL.Focus();
                        return;
                    }

                }
                else
                {
                    MessageBox.Show(error1);
                    return;
                }
                
                string error;
                string query = "insert into Customer(Name,Email,Password,MobileNumber) output inserted.Id values('" + username + "','" + email + "','" + password + "','" + mobilenumber + "')";
               DataTable dtCustomer= DataBaseAccess.getData(query, out error);
                if(this.InsertIntoUserInfo(txtSCUN.Text, txtSCEMAIL.Text, txtSCUCONFIRMPASS.Text)==false)
                {
                    MessageBox.Show("SOMETHING WENT WRONG");
                    return;

                }
                
                string id = dtCustomer.Rows[0][0].ToString();
                if(string.IsNullOrEmpty(error)==true)
                {
                    DialogResult result= MessageBox.Show("REGISTRATION SUCCESFUL!! DO YOU WANT TO CONTINUE?","CONFIRMATION",MessageBoxButtons.YesNo);
                    count++;
                    if (DialogResult.Yes==result)
                    {
                        Customer c = new Customer(id);
                        c.Show();
                        this.Hide();
                    }
                    else
                    {
                        Login l1 = new Login();
                        l1.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show(error);
                }
                
               
            }        
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            metrolblshow.Text = "";
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
            
        }

        private void btnclearinfo_Click(object sender, EventArgs e)
        {
            txtSCEMAIL.Text = "";
            txtSCMOBILE.Text = "";
            txtSCUCONFIRMPASS.Text = "";
            txtSCUN.Text = "";
            txtSCUPASS.Text = "";
        }
    }
}
