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
    public partial class ProductInventoryManage : MetroFramework.Forms.MetroForm
    {
        public ProductInventoryManage()
        {
            InitializeComponent();
        }
        private void Load_InventoryData()
        {
            string query = "select Id, Capacity,MaxCapacity, Description from Inventory";
            string error;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                dgvInventoryAdding.AutoGenerateColumns = false;
                dgvInventoryAdding.DataSource = dt;
                dgvInventoryAdding.Refresh();
                dgvInventoryAdding.ClearSelection();

            }
            else
            {
                MessageBox.Show(error);

            }
        }
        private void Load_ProductData()
        {
            string query = "select  Id, Name, Description from Product";
            string error;
            DataTable dt = DataBaseAccess.getData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                dgvProductAdd.AutoGenerateColumns = false;
                dgvProductAdd.DataSource = dt;
                dgvProductAdd.Refresh();
                dgvProductAdd.ClearSelection();

            }
            else
            {
                MessageBox.Show(error);

            }
        }
        private void ProductInventoryManage_Load(object sender, EventArgs e)
        {
            this.Load_InventoryData();
            this.Load_ProductData();
            //this.New_Data();
        }

       
        private void dgvProductAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProductIdAuto.Text = dgvProductAdd.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void dgvInventoryAdding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtInventoryIdAuto.Text = dgvInventoryAdding.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtInventoryCapacityView.Text = dgvInventoryAdding.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaxCapacity.Text = dgvInventoryAdding.Rows[e.RowIndex].Cells[2].Value.ToString();
                
            }
        }
        
        private void btnAddProductInventory_Click(object sender, EventArgs e)
        {
            if(txtInventoryIdAuto.Text=="" || txtProductIdAuto.Text=="" || txtAmountOfProduct.Text=="")
            {
                MessageBox.Show("PLEASE ENTER ALL INFORMATION");
                return;
            }
            double productamount;
            double inventorycapacity;
            try
            {
                productamount = double.Parse(txtAmountOfProduct.Text);
                inventorycapacity = double.Parse(txtInventoryCapacityView.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if(productamount>inventorycapacity)
            {
                MessageBox.Show("PLEASE SELECT LESS THAN CURRENT CAPACITY");
                return;
            }

            inventorycapacity = inventorycapacity - productamount;
            string productId = txtProductIdAuto.Text;
            string inventoryId = txtInventoryIdAuto.Text;
            string Total = productamount.ToString();
            string error;
            string query = "Insert into ProductInventory(ProductId,InventoryId,Amount) values(" + productId + "," + inventoryId + "," + Total + ")";
            DataBaseAccess.InsertData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return;
            }

            this.updateInventory(inventoryId, inventorycapacity);
            MessageBox.Show("SUCCESSFULLY INSERTED");
            

        }
        private void updateInventory(string inventoryid,double updateCapacity)
        {
            string updatedcapacity = updateCapacity.ToString();
            string error;
            string query = "Update Inventory set Capacity=" + updatedcapacity + "where Id=" + inventoryid;
            DataBaseAccess.InsertData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            this.Load_InventoryData();
            this.New_Data();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPanel a = new AdminPanel();
            a.Show();
            this.Hide();
        }
        private void New_Data()
        {
            txtAmountOfProduct.Text = "";
            txtInventoryCapacityView.Text = "";
            txtInventoryIdAuto.Text = "";
            txtProductIdAuto.Text = "";
            txtMaxCapacity.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Load_InventoryData();
            this.Load_ProductData();
            this.New_Data();
        }

        private void txtInventoryCapacityView_Click(object sender, EventArgs e)
        {

        }
    }
}
