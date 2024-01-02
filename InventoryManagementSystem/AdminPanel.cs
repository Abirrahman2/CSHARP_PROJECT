using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace InventoryManagementSystem
{
    public partial class AdminPanel : MetroFramework.Forms.MetroForm
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

    

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Load_Data();
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.AliceBlue;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.Aqua;
        }

        private void iNVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            InventoryAdd inventoryAdd = new InventoryAdd();
            inventoryAdd.Show();
            this.Hide();
        }

        private void cUSTOMERINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageViewCustomer managecustomer = new ManageViewCustomer();
            managecustomer.Show();
            this.Hide();

        }

        private void iNVENTORYNAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManageInventoryUpdate manageInventory = new ManageInventoryUpdate();
            manageInventory.Show();
            this.Hide();
        }

        private void aLLINVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pore korbo
        }
        private void Load_Data()
        {
            string query = "select Id,Capacity,Address,Description,MaxCapacity from Inventory";
            string error;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error)==true)
            {
                dtvGridInventory.AutoGenerateColumns = false;
                dtvGridInventory.DataSource = dt;
                dtvGridInventory.Refresh();
                dtvGridInventory.ClearSelection();
               


            }

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }

        private void aLLPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfo productInfo = new ProductInfo();
            productInfo.Show();
            this.Hide();
        }

        private void pRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductAdd productAdd= new ProductAdd();
            productAdd.Show();
            this.Hide();
        }

        private void pRODUCTINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProductUpdate manageProductUpdate = new ManageProductUpdate();
            manageProductUpdate.Show();
            this.Hide();
        }

        private void sUPPLIERINFOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            ManageViewSupplier manageViewSupplier = new ManageViewSupplier();
            manageViewSupplier.Show();
            this.Hide();
        }

        private void pRODUCTINVENTORYMANAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInventoryManage pi = new ProductInventoryManage();
            pi.Show();
            this.Hide();
        }

        private void sUPPLIERPRODUCTSELLREQUESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSupplierProductRequest sp = new ManageSupplierProductRequest();
            sp.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Hide();
        }

        private void aLLPROFITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllProfitView ap = new AllProfitView();
            ap.Show();
            this.Hide();

        }

        private void mANAGECUSTOMERORDERREQUESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Customer_Order_Request cutomerOrderViewRequest = new Manage_Customer_Order_Request();
            cutomerOrderViewRequest.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
