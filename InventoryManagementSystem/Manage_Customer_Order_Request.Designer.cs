namespace InventoryManagementSystem
{
    partial class Manage_Customer_Order_Request
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvInventoryCollect = new System.Windows.Forms.DataGridView();
            this.dgvPRODUCTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPRODUCTINVENTORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPRODUCTEXIST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvOrderDetailCollect = new System.Windows.Forms.DataGridView();
            this.dgvODID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPRODUCTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTOTALQUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTOTALPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSTATUS = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductExistInInventory = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderId = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcceptOrder = new System.Windows.Forms.Button();
            this.txtProductId = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInventoryId = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowAvailable = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryCollect)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailCollect)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.76177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.3038F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.96533F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1650, 684);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvInventoryCollect);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1009, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(638, 610);
            this.panel6.TabIndex = 5;
            // 
            // dgvInventoryCollect
            // 
            this.dgvInventoryCollect.AllowUserToAddRows = false;
            this.dgvInventoryCollect.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvInventoryCollect.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryCollect.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvInventoryCollect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryCollect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPRODUCTNAME,
            this.dgvPRODUCTINVENTORY,
            this.dgvPRODUCTEXIST});
            this.dgvInventoryCollect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventoryCollect.Location = new System.Drawing.Point(0, 0);
            this.dgvInventoryCollect.Name = "dgvInventoryCollect";
            this.dgvInventoryCollect.ReadOnly = true;
            this.dgvInventoryCollect.RowTemplate.Height = 24;
            this.dgvInventoryCollect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryCollect.Size = new System.Drawing.Size(638, 610);
            this.dgvInventoryCollect.TabIndex = 0;
            this.dgvInventoryCollect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryCollect_CellClick_1);
            // 
            // dgvPRODUCTNAME
            // 
            this.dgvPRODUCTNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPRODUCTNAME.DataPropertyName = "NAME";
            this.dgvPRODUCTNAME.HeaderText = "NAME";
            this.dgvPRODUCTNAME.Name = "dgvPRODUCTNAME";
            this.dgvPRODUCTNAME.ReadOnly = true;
            // 
            // dgvPRODUCTINVENTORY
            // 
            this.dgvPRODUCTINVENTORY.DataPropertyName = "INV_ID";
            this.dgvPRODUCTINVENTORY.HeaderText = "INV_ID";
            this.dgvPRODUCTINVENTORY.Name = "dgvPRODUCTINVENTORY";
            this.dgvPRODUCTINVENTORY.ReadOnly = true;
            // 
            // dgvPRODUCTEXIST
            // 
            this.dgvPRODUCTEXIST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPRODUCTEXIST.DataPropertyName = "PRODUCT_EXIST";
            this.dgvPRODUCTEXIST.HeaderText = "PRODUCT_EXIST(IN KG)";
            this.dgvPRODUCTEXIST.Name = "dgvPRODUCTEXIST";
            this.dgvPRODUCTEXIST.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvOrderDetailCollect);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(279, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(724, 610);
            this.panel5.TabIndex = 4;
            // 
            // dgvOrderDetailCollect
            // 
            this.dgvOrderDetailCollect.AllowUserToAddRows = false;
            this.dgvOrderDetailCollect.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvOrderDetailCollect.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDetailCollect.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvOrderDetailCollect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetailCollect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvODID,
            this.dgvPRODUCTID,
            this.dgvTOTALQUANTITY,
            this.dgvTOTALPRICE,
            this.dgvSTATUS});
            this.dgvOrderDetailCollect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetailCollect.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetailCollect.Name = "dgvOrderDetailCollect";
            this.dgvOrderDetailCollect.ReadOnly = true;
            this.dgvOrderDetailCollect.RowTemplate.Height = 24;
            this.dgvOrderDetailCollect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetailCollect.Size = new System.Drawing.Size(724, 610);
            this.dgvOrderDetailCollect.TabIndex = 0;
            this.dgvOrderDetailCollect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetailCollect_CellClick);
            // 
            // dgvODID
            // 
            this.dgvODID.DataPropertyName = "OrderId";
            this.dgvODID.HeaderText = "OID";
            this.dgvODID.Name = "dgvODID";
            this.dgvODID.ReadOnly = true;
            this.dgvODID.Width = 80;
            // 
            // dgvPRODUCTID
            // 
            this.dgvPRODUCTID.DataPropertyName = "ProductId";
            this.dgvPRODUCTID.HeaderText = "PID";
            this.dgvPRODUCTID.Name = "dgvPRODUCTID";
            this.dgvPRODUCTID.ReadOnly = true;
            this.dgvPRODUCTID.Width = 80;
            // 
            // dgvTOTALQUANTITY
            // 
            this.dgvTOTALQUANTITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTOTALQUANTITY.DataPropertyName = "TotalQuantity";
            this.dgvTOTALQUANTITY.HeaderText = "QUANTITY";
            this.dgvTOTALQUANTITY.Name = "dgvTOTALQUANTITY";
            this.dgvTOTALQUANTITY.ReadOnly = true;
            // 
            // dgvTOTALPRICE
            // 
            this.dgvTOTALPRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTOTALPRICE.DataPropertyName = "TotalPrice";
            this.dgvTOTALPRICE.HeaderText = "PRICE";
            this.dgvTOTALPRICE.Name = "dgvTOTALPRICE";
            this.dgvTOTALPRICE.ReadOnly = true;
            // 
            // dgvSTATUS
            // 
            this.dgvSTATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSTATUS.DataPropertyName = "Status";
            this.dgvSTATUS.HeaderText = "STATUS";
            this.dgvSTATUS.Name = "dgvSTATUS";
            this.dgvSTATUS.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.Controls.Add(this.txtSTATUS);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtProductExistInInventory);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtOrderId);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtProductQuantity);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnAcceptOrder);
            this.panel4.Controls.Add(this.txtProductId);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtInventoryId);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel4.Location = new System.Drawing.Point(3, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 610);
            this.panel4.TabIndex = 3;
            // 
            // txtSTATUS
            // 
            // 
            // 
            // 
            this.txtSTATUS.CustomButton.Image = null;
            this.txtSTATUS.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtSTATUS.CustomButton.Name = "";
            this.txtSTATUS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSTATUS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSTATUS.CustomButton.TabIndex = 1;
            this.txtSTATUS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSTATUS.CustomButton.UseSelectable = true;
            this.txtSTATUS.CustomButton.Visible = false;
            this.txtSTATUS.Lines = new string[0];
            this.txtSTATUS.Location = new System.Drawing.Point(17, 169);
            this.txtSTATUS.MaxLength = 32767;
            this.txtSTATUS.Name = "txtSTATUS";
            this.txtSTATUS.PasswordChar = '\0';
            this.txtSTATUS.PromptText = "AUTO GENERATE";
            this.txtSTATUS.ReadOnly = true;
            this.txtSTATUS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSTATUS.SelectedText = "";
            this.txtSTATUS.SelectionLength = 0;
            this.txtSTATUS.SelectionStart = 0;
            this.txtSTATUS.ShortcutsEnabled = true;
            this.txtSTATUS.Size = new System.Drawing.Size(195, 23);
            this.txtSTATUS.TabIndex = 12;
            this.txtSTATUS.UseSelectable = true;
            this.txtSTATUS.WaterMark = "AUTO GENERATE";
            this.txtSTATUS.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSTATUS.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "PRODUCT STATUS";
            // 
            // txtProductExistInInventory
            // 
            // 
            // 
            // 
            this.txtProductExistInInventory.CustomButton.Image = null;
            this.txtProductExistInInventory.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtProductExistInInventory.CustomButton.Name = "";
            this.txtProductExistInInventory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductExistInInventory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductExistInInventory.CustomButton.TabIndex = 1;
            this.txtProductExistInInventory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductExistInInventory.CustomButton.UseSelectable = true;
            this.txtProductExistInInventory.CustomButton.Visible = false;
            this.txtProductExistInInventory.Lines = new string[0];
            this.txtProductExistInInventory.Location = new System.Drawing.Point(22, 392);
            this.txtProductExistInInventory.MaxLength = 32767;
            this.txtProductExistInInventory.Name = "txtProductExistInInventory";
            this.txtProductExistInInventory.PasswordChar = '\0';
            this.txtProductExistInInventory.PromptText = "AUTO GENERATE";
            this.txtProductExistInInventory.ReadOnly = true;
            this.txtProductExistInInventory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductExistInInventory.SelectedText = "";
            this.txtProductExistInInventory.SelectionLength = 0;
            this.txtProductExistInInventory.SelectionStart = 0;
            this.txtProductExistInInventory.ShortcutsEnabled = true;
            this.txtProductExistInInventory.Size = new System.Drawing.Size(200, 23);
            this.txtProductExistInInventory.TabIndex = 10;
            this.txtProductExistInInventory.UseSelectable = true;
            this.txtProductExistInInventory.WaterMark = "AUTO GENERATE";
            this.txtProductExistInInventory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductExistInInventory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "PRODUCT EXIST IN INVENTORY";
            // 
            // txtOrderId
            // 
            // 
            // 
            // 
            this.txtOrderId.CustomButton.Image = null;
            this.txtOrderId.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtOrderId.CustomButton.Name = "";
            this.txtOrderId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrderId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderId.CustomButton.TabIndex = 1;
            this.txtOrderId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderId.CustomButton.UseSelectable = true;
            this.txtOrderId.CustomButton.Visible = false;
            this.txtOrderId.Lines = new string[0];
            this.txtOrderId.Location = new System.Drawing.Point(22, 249);
            this.txtOrderId.MaxLength = 32767;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.PasswordChar = '\0';
            this.txtOrderId.PromptText = "AUTO GENERATE";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderId.SelectedText = "";
            this.txtOrderId.SelectionLength = 0;
            this.txtOrderId.SelectionStart = 0;
            this.txtOrderId.ShortcutsEnabled = true;
            this.txtOrderId.Size = new System.Drawing.Size(195, 23);
            this.txtOrderId.TabIndex = 8;
            this.txtOrderId.UseSelectable = true;
            this.txtOrderId.WaterMark = "AUTO GENERATE";
            this.txtOrderId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ORDER ID";
            // 
            // txtProductQuantity
            // 
            // 
            // 
            // 
            this.txtProductQuantity.CustomButton.Image = null;
            this.txtProductQuantity.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtProductQuantity.CustomButton.Name = "";
            this.txtProductQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductQuantity.CustomButton.TabIndex = 1;
            this.txtProductQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductQuantity.CustomButton.UseSelectable = true;
            this.txtProductQuantity.CustomButton.Visible = false;
            this.txtProductQuantity.Lines = new string[0];
            this.txtProductQuantity.Location = new System.Drawing.Point(22, 91);
            this.txtProductQuantity.MaxLength = 32767;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.PasswordChar = '\0';
            this.txtProductQuantity.PromptText = "AUTO GENERATE";
            this.txtProductQuantity.ReadOnly = true;
            this.txtProductQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductQuantity.SelectedText = "";
            this.txtProductQuantity.SelectionLength = 0;
            this.txtProductQuantity.SelectionStart = 0;
            this.txtProductQuantity.ShortcutsEnabled = true;
            this.txtProductQuantity.Size = new System.Drawing.Size(195, 23);
            this.txtProductQuantity.TabIndex = 6;
            this.txtProductQuantity.UseSelectable = true;
            this.txtProductQuantity.WaterMark = "AUTO GENERATE";
            this.txtProductQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRODUCT QUANTITY";
            // 
            // btnAcceptOrder
            // 
            this.btnAcceptOrder.Location = new System.Drawing.Point(37, 507);
            this.btnAcceptOrder.Name = "btnAcceptOrder";
            this.btnAcceptOrder.Size = new System.Drawing.Size(131, 51);
            this.btnAcceptOrder.TabIndex = 4;
            this.btnAcceptOrder.Text = "ACCEPT ORDER";
            this.btnAcceptOrder.UseVisualStyleBackColor = true;
            this.btnAcceptOrder.Click += new System.EventHandler(this.btnAcceptOrder_Click);
            // 
            // txtProductId
            // 
            // 
            // 
            // 
            this.txtProductId.CustomButton.Image = null;
            this.txtProductId.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtProductId.CustomButton.Name = "";
            this.txtProductId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductId.CustomButton.TabIndex = 1;
            this.txtProductId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductId.CustomButton.UseSelectable = true;
            this.txtProductId.CustomButton.Visible = false;
            this.txtProductId.Lines = new string[0];
            this.txtProductId.Location = new System.Drawing.Point(17, 35);
            this.txtProductId.MaxLength = 32767;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.PasswordChar = '\0';
            this.txtProductId.PromptText = "AUTO GENERATE";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductId.SelectedText = "";
            this.txtProductId.SelectionLength = 0;
            this.txtProductId.SelectionStart = 0;
            this.txtProductId.ShortcutsEnabled = true;
            this.txtProductId.Size = new System.Drawing.Size(195, 23);
            this.txtProductId.TabIndex = 3;
            this.txtProductId.UseSelectable = true;
            this.txtProductId.WaterMark = "AUTO GENERATE";
            this.txtProductId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRODUCT ID";
            // 
            // txtInventoryId
            // 
            // 
            // 
            // 
            this.txtInventoryId.CustomButton.Image = null;
            this.txtInventoryId.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtInventoryId.CustomButton.Name = "";
            this.txtInventoryId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventoryId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventoryId.CustomButton.TabIndex = 1;
            this.txtInventoryId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventoryId.CustomButton.UseSelectable = true;
            this.txtInventoryId.CustomButton.Visible = false;
            this.txtInventoryId.Lines = new string[0];
            this.txtInventoryId.Location = new System.Drawing.Point(22, 323);
            this.txtInventoryId.MaxLength = 32767;
            this.txtInventoryId.Name = "txtInventoryId";
            this.txtInventoryId.PasswordChar = '\0';
            this.txtInventoryId.PromptText = "AUTO GENERATE";
            this.txtInventoryId.ReadOnly = true;
            this.txtInventoryId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventoryId.SelectedText = "";
            this.txtInventoryId.SelectionLength = 0;
            this.txtInventoryId.SelectionStart = 0;
            this.txtInventoryId.ShortcutsEnabled = true;
            this.txtInventoryId.Size = new System.Drawing.Size(195, 23);
            this.txtInventoryId.TabIndex = 1;
            this.txtInventoryId.UseSelectable = true;
            this.txtInventoryId.WaterMark = "AUTO GENERATE";
            this.txtInventoryId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventoryId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY ID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InventoryManagementSystem.Properties.Resources.acceptable_risk;
            this.pictureBox3.Location = new System.Drawing.Point(174, 502);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.btnShowAvailable);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel3.Location = new System.Drawing.Point(1009, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 62);
            this.panel3.TabIndex = 2;
            // 
            // btnShowAvailable
            // 
            this.btnShowAvailable.Location = new System.Drawing.Point(432, 13);
            this.btnShowAvailable.Name = "btnShowAvailable";
            this.btnShowAvailable.Size = new System.Drawing.Size(113, 35);
            this.btnShowAvailable.TabIndex = 5;
            this.btnShowAvailable.Text = "SHOW";
            this.btnShowAvailable.UseVisualStyleBackColor = true;
            this.btnShowAvailable.Click += new System.EventHandler(this.btnShowAvailable_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "SHOW AVAILABLE PRODUCT AND INVENTORY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources.goods;
            this.pictureBox1.Location = new System.Drawing.Point(523, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(279, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 62);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "ORDER DETAILS ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventoryManagementSystem.Properties.Resources.purchase_order;
            this.pictureBox2.Location = new System.Drawing.Point(385, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnBACK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(160, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 40);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.Location = new System.Drawing.Point(3, 10);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(114, 40);
            this.btnBACK.TabIndex = 5;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // Manage_Customer_Order_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 764);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Manage_Customer_Order_Request";
            this.Text = "Manage_Customer_Order_Request";
            this.Load += new System.EventHandler(this.Manage_Customer_Order_Request_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryCollect)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailCollect)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroTextBox txtInventoryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOrderDetailCollect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvODID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPRODUCTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTOTALQUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTOTALPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSTATUS;
        private MetroFramework.Controls.MetroTextBox txtOrderId;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtProductQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcceptOrder;
        private MetroFramework.Controls.MetroTextBox txtProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvInventoryCollect;
        private System.Windows.Forms.Button btnShowAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPRODUCTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPRODUCTINVENTORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPRODUCTEXIST;
        private MetroFramework.Controls.MetroTextBox txtProductExistInInventory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnRefresh;
        private MetroFramework.Controls.MetroTextBox txtSTATUS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}