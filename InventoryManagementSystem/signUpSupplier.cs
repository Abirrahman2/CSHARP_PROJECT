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
    public partial class signUpSupplier : MetroFramework.Forms.MetroForm
    {
        public static int suppliercount;
        public signUpSupplier()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private void InsertIntoUserInfo(string username, string useremail, string userpass)
        {
            string error;
            string query = "insert into UserInfo(UserName,Email,Password,UserType) values('" + username + "','" + useremail + "','" + userpass + "','" + "SUPPLIER')";
            DataBaseAccess.InsertData(query, out error);
            if (string.IsNullOrEmpty(error))
            {
                return;
            }
            return;
        }

        private void btnCreateSupplier_Click(object sender, EventArgs e)
        {
            
            string username = txtSupplierName.Text;
            string email = txtSupplierEmail.Text;
            string mobilenumber = txtSupplierMobile.Text;
            string address = txtSupplierAddress.Text;
            string password = txtSupplierPass.Text;
            string cpassword = txtSupplierConPass.Text;
            if (cpassword == "" || password == "" || email=="" || username=="" ||address=="" || mobilenumber=="")
            {
                MessageBox.Show("PLEASE PROVIDE ALL THE INFORMATION");
                lblshowCorrect.Text = "ENTER PASSWORD/EMAIL PLEASE";
                return;

            }
            if (cpassword != password)
            {
                lblshowCorrect.Text = "PASSWORD AND CONFIRM PASSWORD ARE NOT SAME";
                return;
            }
            if (cpassword == password && cpassword != "")
            {
                string error1;
                string existSupplierCheckQuery = "select * from UserInfo where Email='" + email + "'";
                DataTable dt = DataBaseAccess.getData(existSupplierCheckQuery, out error1);
                if (string.IsNullOrEmpty(error1) == true)
                {
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("EMAIL ALREADY EXIST ,PLEASE CHANGE THE EMAIL");
                        txtSupplierEmail.Text = "";
                        txtSupplierEmail.Focus();
                        return;
                    }
              
                }
                else
                {
                    MessageBox.Show(error1);
                    return;
                }

                string error;
                string query = "insert into Supplier(UserName,Email,MobileNumber,Password,Address) output inserted.Id values('" + username + "','" + email + "','" + mobilenumber + "','" +password+"','"+address+ "')";

                DataTable dtSupplier = DataBaseAccess.getData(query, out error);
                if(string.IsNullOrEmpty(error))
                {
                    this.InsertIntoUserInfo(username, email, password);
                    string id = dtSupplier.Rows[0][0].ToString();
                    DialogResult result = MessageBox.Show("REGISTRATION SUCCESFUL!! DO YOU WANT TO CONTINUE?", "CONFIRMATION", MessageBoxButtons.YesNo);
                    suppliercount++;
                    if (DialogResult.Yes == result)
                    {
                        Supplier s = new Supplier(id);
                        s.Show();
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
                    MessageBox.Show("CAN NOT CREATE ACCOUNT,SOMETHING WENT WRONG");
                   
                }
               

            }

        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            txtSupplierName.Text="";
             txtSupplierEmail.Text="";
            txtSupplierMobile.Text="";
             txtSupplierAddress.Text="";
            txtSupplierPass.Text="";
             txtSupplierConPass.Text="";

        }
    }
}
