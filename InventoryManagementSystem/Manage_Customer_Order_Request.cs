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
    public partial class Manage_Customer_Order_Request : MetroFramework.Forms.MetroForm
    {
        public Manage_Customer_Order_Request()
        {
            InitializeComponent();
        }
        private void Load_Data_OrderDetail()
        {
            string error;
            string query = "select OrderId,ProductId,TotalQuantity,TotalPrice,Status from OrderDetail";
            DataTable orderDetailes = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error))
            {
                dgvOrderDetailCollect.AutoGenerateColumns = false;
                dgvOrderDetailCollect.DataSource = orderDetailes;
                dgvOrderDetailCollect.Refresh();
                dgvOrderDetailCollect.ClearSelection();
                return;
            }
            MessageBox.Show(error);
        }
        private void Load_Data_ProductInventory(string productId)
        {
            string error;
            string query = "select Product.Name 'NAME',ProductInventory.InventoryId 'INV_ID',ProductInventory.Amount 'PRODUCT_EXIST' from ProductInventory inner join Product on Product.Id=ProductInventory.ProductId where Product.Id="+productId;
            DataTable inventoryDetails = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error))
            {
                dgvInventoryCollect.AutoGenerateColumns = false;
                dgvInventoryCollect.DataSource = inventoryDetails;
                dgvInventoryCollect.Refresh();
                dgvInventoryCollect.ClearSelection();
                return;

            }
            MessageBox.Show(error);

        }
        private void Manage_Customer_Order_Request_Load(object sender, EventArgs e)
        {
            this.Load_Data_OrderDetail();
            
        }
      
       private void Update_OrderDetail_Status(string orderId)
        {
            string error;
            string query = "Update OrderDetail set [Status]='DONE' where OrderId="+ orderId;
            DataBaseAccess.InsertData(query, out error);
            if (string.IsNullOrEmpty(error))
            {
               
                return;
            }
            MessageBox.Show(error);
        }
        private void Update_ProductInventory()
        {
            double existProduct;
            double productquantity;
            try
            {
                existProduct = double.Parse(txtProductExistInInventory.Text);
                productquantity = double.Parse(txtProductQuantity.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            double updatedProductAmount = existProduct - productquantity;
            string updatevalue = updatedProductAmount.ToString();
            string error;
            string query = "Update ProductInventory set Amount=" + updatevalue + "where ProductId=" + txtProductId.Text + "and InventoryId=" + txtInventoryId.Text;
            DataBaseAccess.InsertData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return;
            }
        }
        private double getInventoryCurrentCapacity(string inventoryId)
        {
            string error;
            string query = "select Capacity from Inventory where Id=" + inventoryId;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if(string.IsNullOrEmpty(error))
            {
                string value = dt.Rows[0][0].ToString();
                double current;
                try
                {
                    current= double.Parse(value);
                    return current;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
            }
            return 0;
        }
        private void Update_Inventory()
        {
            double existProduct;
            double productquantity;
            try
            {
                existProduct = double.Parse(txtProductExistInInventory.Text);
                productquantity = double.Parse(txtProductQuantity.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            double updatedProductAmount = productquantity;
            string updatevalue = updatedProductAmount.ToString();
            double updatedInventoryCapacity = this.getInventoryCurrentCapacity(txtInventoryId.Text);
            if(updatedInventoryCapacity==0)
            {
                return;
            }
            double setFinal = updatedProductAmount + updatedInventoryCapacity;
            string final=setFinal.ToString();
            string error;
            string query = "Update Inventory set Capacity="+final+"where Id="+txtInventoryId.Text;
            DataBaseAccess.InsertData(query, out error);
            if (string.IsNullOrEmpty(error))
            {

                return;
            }
            MessageBox.Show(error);

        }
        private void btnAcceptOrder_Click(object sender, EventArgs e)
        {
            if (txtProductId.Text == "")
            {
                MessageBox.Show("PLEASE SELECT WHICH ORDER YOU WANT TO ACCEPT AND SEND TO YOUR CUSTOMER");
                return;
            }
            if (txtInventoryId.Text=="")
            {
                MessageBox.Show("PLEASE SELECT YOUR INVENTORY FROM WHERE YOU WANT TO GIVE YOUR PRODUCT TO YOUR CUSTOMER");
                return;
            }
            if(txtSTATUS.Text=="DONE")
            {
                MessageBox.Show("THIS PRODUCT IS ALREADY DELIVERED TO YOUR CUSTOMER");
                return;
            }
            double existingproduct = double.Parse(txtProductExistInInventory.Text);
            double productquantity = double.Parse(txtProductQuantity.Text);
            if(productquantity>existingproduct)
            {
                MessageBox.Show("INSUFFICIENT QUANTITY,PLEASE SELECT ANOTHER INVENTORY");
                return;
            }
            this.Update_OrderDetail_Status(txtOrderId.Text);
            this.Update_ProductInventory();
            this.Update_Inventory();
            MessageBox.Show("SUCCESSFULLY SEND TO YOUR CUSTOMER.");
           
        }

        private void dgvOrderDetailCollect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtProductId.Text = dgvOrderDetailCollect.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtOrderId.Text= dgvOrderDetailCollect.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProductQuantity.Text= dgvOrderDetailCollect.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSTATUS.Text= dgvOrderDetailCollect.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

   

        private void btnShowAvailable_Click(object sender, EventArgs e)
        {
            if(txtProductId.Text=="")
            {
                MessageBox.Show("Please select an order that you want to send");
                return;
            }
            this.Load_Data_ProductInventory(txtProductId.Text);
        }

        private void dgvInventoryCollect_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtInventoryId.Text = dgvInventoryCollect.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtProductExistInInventory.Text= dgvInventoryCollect.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
           
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            AdminPanel adm = new AdminPanel();
            adm.Show();
            this.Hide();
        }
        private void New_Data()
        {
            txtInventoryId.Text = "";
            txtOrderId.Text = "";
            txtProductExistInInventory.Text = "";
            txtProductId.Text = "";
            txtProductQuantity.Text = "";
            
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.New_Data();
            this.Load_Data_OrderDetail();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
