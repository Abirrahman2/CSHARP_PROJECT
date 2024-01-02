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
    public partial class SignUpType :MetroFramework.Forms.MetroForm
    {
        public SignUpType()
        {
            InitializeComponent();
        }

        private void SignUpType_Load(object sender, EventArgs e)
        {

        }

        private void btncreatecustomer_Click(object sender, EventArgs e)
        {
            SignUpCustomer sc = new SignUpCustomer();
            sc.Show();
            this.Hide();
        }

        private void btncreatesupplier_Click(object sender, EventArgs e)
        {
            signUpSupplier ss = new signUpSupplier();
            ss.Show();
            this.Hide();
        }

        private void btncreatecustomer_MouseHover(object sender, EventArgs e)
        {
            btncreatecustomer.BackColor = Color.Pink;
        }

        private void btncreatecustomer_MouseLeave(object sender, EventArgs e)
        {
            btncreatecustomer.BackColor = Color.White;
        }

        private void btncreatesupplier_MouseHover(object sender, EventArgs e)
        {
            btncreatesupplier.BackColor = Color.Pink;
        }

        private void btncreatesupplier_MouseLeave(object sender, EventArgs e)
        {
            btncreatesupplier.BackColor = Color.White;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
