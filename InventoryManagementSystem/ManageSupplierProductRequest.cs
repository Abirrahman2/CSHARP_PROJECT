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
    public partial class ManageSupplierProductRequest : MetroFramework.Forms.MetroForm
    {
        public ManageSupplierProductRequest()
        {
            InitializeComponent();
        }
        private void Load_InventoryData()
        {
            string query = "select Id,Capacity,MaxCapacity,Address from Inventory";
            string error;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                dgvInventoryShow.AutoGenerateColumns = false;
                dgvInventoryShow.DataSource = dt;
                dgvInventoryShow.Refresh();
                dgvInventoryShow.ClearSelection();


            }
            else
            {
                MessageBox.Show(error);

            }
        }
        private void Load_SupplierProductRequestData()
        {
            string error;
            string query = "select ProductSupplierRequestInfo.Id 'PSID',Product.Id 'PID',Supplier.Id 'SID', Product.Name'PRODUCT',Supplier.UserName'USER NAME',ProductSupplierRequestInfo.Quantity'QUANTITY',ProductSupplierRequestInfo.TotalCost 'COST' from ProductSupplierRequestInfo inner join Product on Product.Id=ProductSupplierRequestInfo.ProductIdRequest inner join Supplier on Supplier.Id=ProductSupplierRequestInfo.SupplierIdRequest";
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;

            }
            dgvSupplierRequest.DataSource = dt;
            
            dgvSupplierRequest.Refresh();
            dgvSupplierRequest.ClearSelection();

        }
        private void ManageSupplierProductRequest_Load(object sender, EventArgs e)
        {
            this.Load_InventoryData();
            this.Load_SupplierProductRequestData();

        }


        private void txtChooseProduct_Click(object sender, EventArgs e)
        {

        }

        private void dgvSupplierRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtChooseProduct.Text = dgvSupplierRequest.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtChooseSupplier.Text= dgvSupplierRequest.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtProductQuantity.Text= dgvSupplierRequest.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTotalCostToPaid.Text= dgvSupplierRequest.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtSupplierId.Text= dgvSupplierRequest.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtProductID.Text = dgvSupplierRequest.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }

        private void dgvInventoryShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex>=0)
            {
                txtChooseInventory.Text = dgvInventoryShow.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCurrentCapacity.Text= dgvInventoryShow.Rows[e.RowIndex].Cells[1].Value.ToString();
                

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnAccepted_Click(object sender, EventArgs e)
        {
            if(txtProductID.Text=="" || txtChooseInventory.Text=="")
            {
                MessageBox.Show("YOU DID NOT SELECT ANY INVENTORY OR SUPPLIER.PLEASE SELECT");
                return;
            }
            double current;
            try
            {
                current = double.Parse(txtCurrentCapacity.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            double quantity;
            try
            {
                quantity = double.Parse(txtProductQuantity.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if(current<quantity)
            {
                MessageBox.Show("INSUFFICIENT CAPACITY,PLEASE SELECT ANOTHER INVENTORY.");
                return;
            }
            double currentcapacity = current - quantity;
            string currentInventory = currentcapacity.ToString();
            string error1;
            string query = "Update inventory set Capacity=" + currentInventory + "Where Id=" +txtChooseInventory.Text;
            DataBaseAccess.InsertData(query, out error1);
            if(string.IsNullOrEmpty(error1)==false)
            {
                MessageBox.Show(error1);
                return;
            }
            string query1 = "insert into ProductSupplierInfo(Supplier_Id,Amount,Prize,ProductId) values(" + txtSupplierId.Text + "," + txtProductQuantity.Text + "," + txtTotalCostToPaid.Text + "," + txtProductID.Text + ")";
            DataBaseAccess.InsertData(query1, out error1);
            if(string.IsNullOrEmpty(error1)==false)
            {
                MessageBox.Show(error1);
                return;
            }
            MessageBox.Show("SUCCESSFULLY INSERTED DATA INTO PRODUCTSUPPLIERINFO TABLE");
            this.Load_InventoryData();
            string query3 = "Delete  from ProductSupplierRequestInfo where SupplierIdRequest=" + txtSupplierId.Text +"and ProductIdRequest="+txtProductID.Text;
            DataBaseAccess.InsertData(query3, out error1);
            if(string.IsNullOrEmpty(error1)==false)
            {
                MessageBox.Show(error1);
            }
            if(this.getCurrentProductQuantity(txtChooseInventory.Text,txtProductID.Text)==0)
            {
                MessageBox.Show("INVALID AMOUNT");
                return;
            }
            double currentQuantityIndatabase= this.getCurrentProductQuantity(txtChooseInventory.Text, txtProductID.Text);
            double trytoaddproductindatabase;
            try
            {
                trytoaddproductindatabase = double.Parse(txtProductQuantity.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            double sum = currentQuantityIndatabase + trytoaddproductindatabase;
            string summ = sum.ToString();
            string error5;
            string query5 = "Update ProductInventory Set Amount=" + summ+"Where ProductId=" + txtProductID.Text+"and InventoryId="+ txtChooseInventory.Text;
            DataBaseAccess.InsertData(query5, out error5);
            if (string.IsNullOrEmpty(error5) == false)
            {
                MessageBox.Show(error5);
                return;
            }
            MessageBox.Show("UPDATED PRODUCTINVENTORY TABLE");

        }
        private double getCurrentProductQuantity(string inventoryId,string productId)
        {
            string error;
            string query = "select Amount from ProductInventory where InventoryId=" + inventoryId + "and ProductId=" + productId;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return 0;
            }
            string amount = dt.Rows[0][0].ToString();
            double x;
            try
            {
                x = double.Parse(amount);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return x;

        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            AdminPanel back = new AdminPanel();
            back.Show();
            this.Hide();
        }
    }
}
