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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncreateaccount_Click(object sender, EventArgs e)
        {
           
            SignUpType s = new SignUpType();
            s.Show();
            this.Hide();
        }
        private string Search_Email(string email)
        {
           // MessageBox.Show(email);
            string error;
            string query="select UserType from UserInfo where Email='"+email+"'";
            DataTable dt = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show("SOMETHING WENT WRONG");
               
                return null;
            }
            if(dt.Rows.Count==0)
            {
               
                return null;
            }
            string user = dt.Rows[0][0].ToString();
            
            return user;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text=="")
            {
                MessageBox.Show("PLEASE PROVIDE YOUR EMAIL");
                return;
            }
            if(txtPASS.Text=="")
            {
                MessageBox.Show("PLEASE PROVIDE YOUR PASSWORD");
                return;
            }
            string mail=txtEmail.Text;
            string usertype = this.Search_Email(mail);
           // MessageBox.Show(usertype);
            if (string.IsNullOrEmpty(usertype))
            {
                MessageBox.Show("EMAIL YOU PROVIDED IS INCORRECT,PLEASE CHECK");
                return;
            }         
            if (usertype=="ADMIN")
            {
              
                string password = txtPASS.Text;
                string email = txtEmail.Text;
                string error;
                string query = "select * from Admin where Email='"+email+"'";
                DataTable dt = DataBaseAccess.getData(query, out error);
                if (string.IsNullOrEmpty(error) == true)
                {
                    if (dt.Rows.Count == 0)
                    {
                        DialogResult result = MessageBox.Show("YOU ENTERED WRONG INFORMATION", "ERROR", MessageBoxButtons.OKCancel);
                        if (DialogResult.OK == result)
                        {
                            txtEmail.Text = "";
                            txtPASS.Text = "";
                           
                        }
                        return;
                    }
                   
                    string checkPassword = dt.Rows[0][3].ToString();
                    if (checkPassword == password)
                    {
                        AdminPanel a = new AdminPanel();
                        a.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("OOPS something went wrong!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(error);

                }



            }         
            else if(usertype=="SUPPLIER")
             {
                
                  string password = txtPASS.Text;
                  // MessageBox.Show(password);
                  string email = txtEmail.Text;
              //  MessageBox.Show(email);
                  string error;
                  string query = "select * from Supplier where Email='"+email+"'";
                  DataTable dtSupplier = DataBaseAccess.getData(query, out error);
                  if(string.IsNullOrEmpty(error)==false)
                  {
                      MessageBox.Show(error);
                      return;

                  }
                  if(dtSupplier.Rows.Count==0)
                  {
                      DialogResult result = MessageBox.Show("YOU ENTERED WRONG INFORMATION", "ERROR", MessageBoxButtons.OKCancel);
                      if (DialogResult.OK == result)
                      {
                          txtEmail.Text = "";
                          txtPASS.Text = "";
                         

                      }

                      return;
                  }
                  string id = dtSupplier.Rows[0][0].ToString();
               
                  string checkPassword = dtSupplier.Rows[0][4].ToString();
                  if ( checkPassword == password)
                  {
                      Supplier s = new Supplier(id);
                      s.Show();
                      this.Hide();
                  }
                  else
                  {
                      MessageBox.Show("INVALID EMAIL AND PASSWORD");
                      return;
                  }

                 // MessageBox.Show("supllier selected");

              }
              else if(usertype=="CUSTOMER")
              {
                 
                  string password = txtPASS.Text;
                  string email = txtEmail.Text;
                  string error;
                  string query = "select * from Customer where Email='"+email+"'";
                  DataTable dtCustomer = DataBaseAccess.getData(query, out error);
                 if(string.IsNullOrEmpty(error)==true)
                  {
                      if (dtCustomer.Rows.Count == 0)
                      {
                          DialogResult result = MessageBox.Show("YOU ENTERED WRONG INFORMATION", "ERROR", MessageBoxButtons.OKCancel);
                          if (DialogResult.OK == result)
                          {
                              txtEmail.Text = "";
                              txtPASS.Text = "";
                             

                          }

                          return;


                      }
                     
                      string checkPassword = dtCustomer.Rows[0][3].ToString();

                      string id = dtCustomer.Rows[0][0].ToString();
                      if (checkPassword == password)
                      {
                          Customer c = new Customer(id);
                          c.Show();
                          this.Hide();
                      }
                      else
                      {
                          MessageBox.Show("INVALID EMAIL AND PASSWORD");
                          return;
                      }
                  }
                  else
                  {
                      MessageBox.Show(error);
                  }
              }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPass.Checked==true)
            {
                txtPASS.UseSystemPasswordChar = true;

            }
            else
            {
                txtPASS.UseSystemPasswordChar = false;
            }
        }
    }
}
