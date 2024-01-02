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
    public partial class ManageViewSupplier : MetroFramework.Forms.MetroForm
    {
        public ManageViewSupplier()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            string error;
            string query = "select Id,UserName,Email,Address from Supplier";
            DataTable dtsupplier = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show("SOMETHING WENT WRONG");
                return;
            }
            dgvViewSupplier.AutoGenerateColumns = false;
            dgvViewSupplier.DataSource = dtsupplier;
            dgvViewSupplier.Refresh();
            dgvViewSupplier.ClearSelection();
        }
        private void New_Data()
        {
            txtTotalAmountWePaid.Text = "";
            txtTotalProductGave.Text = "";
            txtViewSupplierEmail.Text = "";
            txtViewSupplierId.Text = "";
            txtViewSupplierName.Text = "";
        }
        private void ManageViewSupplier_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }

        private void btnbackViewSupplier_Click(object sender, EventArgs e)
        {
            AdminPanel add = new AdminPanel();
            add.Show();
            this.Hide();
        }

        private void btnViewSupplierRefresh_Click(object sender, EventArgs e)
        {
            this.Load_Data();
            this.New_Data();
        }

        private void dgvViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtViewSupplierId.Text = dgvViewSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtViewSupplierName.Text = dgvViewSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtViewSupplierEmail.Text = dgvViewSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                string error;
                string query = "select COUNT(*) from ProductSupplierInfo where Supplier_Id =" + txtViewSupplierId.Text;
                DataTable dt = DataBaseAccess.getData(query, out error);
                if(string.IsNullOrEmpty(error)==false)
                {
                    MessageBox.Show(error);
                    return;
                }
                if(dt.Rows.Count==0)
                {
                    return;
                }
                txtTotalProductGave.Text = dt.Rows[0][0].ToString();
                string query1 = "select SUM(Prize) from ProductSupplierInfo where Supplier_Id ="+ txtViewSupplierId.Text;
                DataTable dtt = DataBaseAccess.getData(query1, out error);
                if(string.IsNullOrEmpty(error)==false)
                {
                    MessageBox.Show(error);
                    return;
                }
                if(dtt.Rows.Count==0)
                {
                    return;
                }
                txtTotalAmountWePaid.Text = dtt.Rows[0][0].ToString();
            }
        }
    }
}
