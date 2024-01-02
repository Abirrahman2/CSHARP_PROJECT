namespace InventoryManagementSystem
{
    partial class Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONALINFORMATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDERHISTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mYSELECTIONLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sETTINGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITPERSONALINFORMATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchProductForCustomer = new System.Windows.Forms.Button();
            this.txtSearchProductForCustomer = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvShowProductForCustomer = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.btnCalculateTotalPrice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddtoList = new System.Windows.Forms.Button();
            this.txtProductQuantity = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOrderProduct = new System.Windows.Forms.Button();
            this.btnlogoutcustomer = new System.Windows.Forms.Button();
            this.cmbSelectProductForCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProductForCustomer)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1298, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 52);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWToolStripMenuItem,
            this.sETTINGSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERSONALINFORMATIONToolStripMenuItem,
            this.oRDERHISTORYToolStripMenuItem,
            this.mYSELECTIONLISTToolStripMenuItem});
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(56, 48);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            // 
            // pERSONALINFORMATIONToolStripMenuItem
            // 
            this.pERSONALINFORMATIONToolStripMenuItem.Name = "pERSONALINFORMATIONToolStripMenuItem";
            this.pERSONALINFORMATIONToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.pERSONALINFORMATIONToolStripMenuItem.Text = "PERSONAL_INFORMATION";
            this.pERSONALINFORMATIONToolStripMenuItem.Click += new System.EventHandler(this.pERSONALINFORMATIONToolStripMenuItem_Click);
            // 
            // oRDERHISTORYToolStripMenuItem
            // 
            this.oRDERHISTORYToolStripMenuItem.Name = "oRDERHISTORYToolStripMenuItem";
            this.oRDERHISTORYToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.oRDERHISTORYToolStripMenuItem.Text = "ORDER_HISTORY";
            this.oRDERHISTORYToolStripMenuItem.Click += new System.EventHandler(this.oRDERHISTORYToolStripMenuItem_Click);
            // 
            // mYSELECTIONLISTToolStripMenuItem
            // 
            this.mYSELECTIONLISTToolStripMenuItem.Name = "mYSELECTIONLISTToolStripMenuItem";
            this.mYSELECTIONLISTToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.mYSELECTIONLISTToolStripMenuItem.Text = "MY_SELECTION_LIST";
            this.mYSELECTIONLISTToolStripMenuItem.Click += new System.EventHandler(this.mYSELECTIONLISTToolStripMenuItem_Click);
            // 
            // sETTINGSToolStripMenuItem
            // 
            this.sETTINGSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITPERSONALINFORMATIONToolStripMenuItem});
            this.sETTINGSToolStripMenuItem.Name = "sETTINGSToolStripMenuItem";
            this.sETTINGSToolStripMenuItem.Size = new System.Drawing.Size(86, 48);
            this.sETTINGSToolStripMenuItem.Text = "SETTINGS";
            // 
            // eDITPERSONALINFORMATIONToolStripMenuItem
            // 
            this.eDITPERSONALINFORMATIONToolStripMenuItem.Name = "eDITPERSONALINFORMATIONToolStripMenuItem";
            this.eDITPERSONALINFORMATIONToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.eDITPERSONALINFORMATIONToolStripMenuItem.Text = "EDIT_PERSONAL_INFORMATION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.btnSearchProductForCustomer);
            this.panel2.Controls.Add(this.txtSearchProductForCustomer);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(781, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 52);
            this.panel2.TabIndex = 1;
            // 
            // btnSearchProductForCustomer
            // 
            this.btnSearchProductForCustomer.Location = new System.Drawing.Point(260, 11);
            this.btnSearchProductForCustomer.Name = "btnSearchProductForCustomer";
            this.btnSearchProductForCustomer.Size = new System.Drawing.Size(104, 38);
            this.btnSearchProductForCustomer.TabIndex = 6;
            this.btnSearchProductForCustomer.Text = "SEARCH";
            this.btnSearchProductForCustomer.UseVisualStyleBackColor = true;
            this.btnSearchProductForCustomer.Click += new System.EventHandler(this.btnSearchProductForCustomer_Click);
            // 
            // txtSearchProductForCustomer
            // 
            // 
            // 
            // 
            this.txtSearchProductForCustomer.CustomButton.Image = null;
            this.txtSearchProductForCustomer.CustomButton.Location = new System.Drawing.Point(215, 2);
            this.txtSearchProductForCustomer.CustomButton.Name = "";
            this.txtSearchProductForCustomer.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtSearchProductForCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchProductForCustomer.CustomButton.TabIndex = 1;
            this.txtSearchProductForCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchProductForCustomer.CustomButton.UseSelectable = true;
            this.txtSearchProductForCustomer.CustomButton.Visible = false;
            this.txtSearchProductForCustomer.Lines = new string[0];
            this.txtSearchProductForCustomer.Location = new System.Drawing.Point(3, 11);
            this.txtSearchProductForCustomer.MaxLength = 32767;
            this.txtSearchProductForCustomer.Name = "txtSearchProductForCustomer";
            this.txtSearchProductForCustomer.PasswordChar = '\0';
            this.txtSearchProductForCustomer.PromptText = "SEARCH PRODUCT";
            this.txtSearchProductForCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchProductForCustomer.SelectedText = "";
            this.txtSearchProductForCustomer.SelectionLength = 0;
            this.txtSearchProductForCustomer.SelectionStart = 0;
            this.txtSearchProductForCustomer.ShortcutsEnabled = true;
            this.txtSearchProductForCustomer.Size = new System.Drawing.Size(251, 38);
            this.txtSearchProductForCustomer.TabIndex = 3;
            this.txtSearchProductForCustomer.UseSelectable = true;
            this.txtSearchProductForCustomer.WaterMark = "SEARCH PRODUCT";
            this.txtSearchProductForCustomer.WaterMarkColor = System.Drawing.Color.ForestGreen;
            this.txtSearchProductForCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.75193F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.24807F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 118);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 592F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1298, 592);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvShowProductForCustomer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(506, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(789, 586);
            this.panel4.TabIndex = 1;
            // 
            // dgvShowProductForCustomer
            // 
            this.dgvShowProductForCustomer.AllowUserToAddRows = false;
            this.dgvShowProductForCustomer.AllowUserToDeleteRows = false;
            this.dgvShowProductForCustomer.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvShowProductForCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowProductForCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvProductName,
            this.dgvProductPrice});
            this.dgvShowProductForCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowProductForCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvShowProductForCustomer.Name = "dgvShowProductForCustomer";
            this.dgvShowProductForCustomer.ReadOnly = true;
            this.dgvShowProductForCustomer.RowTemplate.Height = 24;
            this.dgvShowProductForCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowProductForCustomer.Size = new System.Drawing.Size(789, 586);
            this.dgvShowProductForCustomer.TabIndex = 0;
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "Id";
            this.dgvID.HeaderText = "PRODUCT_NUMBER";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Width = 150;
            // 
            // dgvProductName
            // 
            this.dgvProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductName.DataPropertyName = "Name";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductName.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductName.HeaderText = "PRODUCT_NAME";
            this.dgvProductName.Name = "dgvProductName";
            this.dgvProductName.ReadOnly = true;
            // 
            // dgvProductPrice
            // 
            this.dgvProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductPrice.DataPropertyName = "SellPrice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductPrice.HeaderText = "PRODUCT_PRICE(PER KG)";
            this.dgvProductPrice.Name = "dgvProductPrice";
            this.dgvProductPrice.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Linen;
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dtpicker);
            this.panel3.Controls.Add(this.btnCalculateTotalPrice);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnAddtoList);
            this.panel3.Controls.Add(this.txtProductQuantity);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnOrderProduct);
            this.panel3.Controls.Add(this.btnlogoutcustomer);
            this.panel3.Controls.Add(this.cmbSelectProductForCustomer);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 586);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "DATE AND TIME";
            // 
            // dtpicker
            // 
            this.dtpicker.Enabled = false;
            this.dtpicker.Location = new System.Drawing.Point(154, 240);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(309, 22);
            this.dtpicker.TabIndex = 17;
            // 
            // btnCalculateTotalPrice
            // 
            this.btnCalculateTotalPrice.Location = new System.Drawing.Point(327, 300);
            this.btnCalculateTotalPrice.Name = "btnCalculateTotalPrice";
            this.btnCalculateTotalPrice.Size = new System.Drawing.Size(103, 23);
            this.btnCalculateTotalPrice.TabIndex = 16;
            this.btnCalculateTotalPrice.Text = "CALCULATE PRICE";
            this.btnCalculateTotalPrice.UseVisualStyleBackColor = true;
            this.btnCalculateTotalPrice.Click += new System.EventHandler(this.btnCalculateTotalPrice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "OR";
            // 
            // txtTotalPrice
            // 
            // 
            // 
            // 
            this.txtTotalPrice.CustomButton.Image = null;
            this.txtTotalPrice.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtTotalPrice.CustomButton.Name = "";
            this.txtTotalPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPrice.CustomButton.TabIndex = 1;
            this.txtTotalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPrice.CustomButton.UseSelectable = true;
            this.txtTotalPrice.CustomButton.Visible = false;
            this.txtTotalPrice.Lines = new string[0];
            this.txtTotalPrice.Location = new System.Drawing.Point(154, 300);
            this.txtTotalPrice.MaxLength = 32767;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PromptText = "AUTO GENERATED";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.SelectionLength = 0;
            this.txtTotalPrice.SelectionStart = 0;
            this.txtTotalPrice.ShortcutsEnabled = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(167, 23);
            this.txtTotalPrice.TabIndex = 14;
            this.txtTotalPrice.UseSelectable = true;
            this.txtTotalPrice.WaterMark = "AUTO GENERATED";
            this.txtTotalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "TOTAL PRICE";
            // 
            // btnAddtoList
            // 
            this.btnAddtoList.Location = new System.Drawing.Point(218, 466);
            this.btnAddtoList.Name = "btnAddtoList";
            this.btnAddtoList.Size = new System.Drawing.Size(137, 49);
            this.btnAddtoList.TabIndex = 12;
            this.btnAddtoList.Text = "ADD TO MYLIST";
            this.btnAddtoList.UseVisualStyleBackColor = true;
            this.btnAddtoList.Click += new System.EventHandler(this.btnAddtoList_Click);
            // 
            // txtProductQuantity
            // 
            // 
            // 
            // 
            this.txtProductQuantity.CustomButton.Image = null;
            this.txtProductQuantity.CustomButton.Location = new System.Drawing.Point(287, 1);
            this.txtProductQuantity.CustomButton.Name = "";
            this.txtProductQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductQuantity.CustomButton.TabIndex = 1;
            this.txtProductQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductQuantity.CustomButton.UseSelectable = true;
            this.txtProductQuantity.CustomButton.Visible = false;
            this.txtProductQuantity.Lines = new string[0];
            this.txtProductQuantity.Location = new System.Drawing.Point(154, 197);
            this.txtProductQuantity.MaxLength = 32767;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.PasswordChar = '\0';
            this.txtProductQuantity.PromptText = "ENTER QUANTITY(NOT LESS THAN 1 KG)";
            this.txtProductQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductQuantity.SelectedText = "";
            this.txtProductQuantity.SelectionLength = 0;
            this.txtProductQuantity.SelectionStart = 0;
            this.txtProductQuantity.ShortcutsEnabled = true;
            this.txtProductQuantity.Size = new System.Drawing.Size(309, 23);
            this.txtProductQuantity.TabIndex = 11;
            this.txtProductQuantity.UseSelectable = true;
            this.txtProductQuantity.WaterMark = "ENTER QUANTITY(NOT LESS THAN 1 KG)";
            this.txtProductQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ENTER QUANTITY";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaShell;
            this.panel5.Controls.Add(this.btnNew);
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Location = new System.Drawing.Point(3, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 59);
            this.panel5.TabIndex = 9;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(5, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 53);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(349, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(139, 49);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOrderProduct
            // 
            this.btnOrderProduct.Location = new System.Drawing.Point(218, 346);
            this.btnOrderProduct.Name = "btnOrderProduct";
            this.btnOrderProduct.Size = new System.Drawing.Size(137, 49);
            this.btnOrderProduct.TabIndex = 6;
            this.btnOrderProduct.Text = "ORDER";
            this.btnOrderProduct.UseVisualStyleBackColor = true;
            this.btnOrderProduct.Click += new System.EventHandler(this.btnOrderProduct_Click);
            // 
            // btnlogoutcustomer
            // 
            this.btnlogoutcustomer.Location = new System.Drawing.Point(3, 534);
            this.btnlogoutcustomer.Name = "btnlogoutcustomer";
            this.btnlogoutcustomer.Size = new System.Drawing.Size(137, 49);
            this.btnlogoutcustomer.TabIndex = 5;
            this.btnlogoutcustomer.Text = "LOG OUT";
            this.btnlogoutcustomer.UseVisualStyleBackColor = true;
            this.btnlogoutcustomer.Click += new System.EventHandler(this.btnlogoutcustomer_Click);
            // 
            // cmbSelectProductForCustomer
            // 
            this.cmbSelectProductForCustomer.FormattingEnabled = true;
            this.cmbSelectProductForCustomer.Location = new System.Drawing.Point(154, 142);
            this.cmbSelectProductForCustomer.Name = "cmbSelectProductForCustomer";
            this.cmbSelectProductForCustomer.Size = new System.Drawing.Size(309, 24);
            this.cmbSelectProductForCustomer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "SELECT PRODUCT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER YOUR PRODUCT AND ENJOY";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox6.Image = global::InventoryManagementSystem.Properties.Resources.logout;
            this.pictureBox6.Location = new System.Drawing.Point(142, 534);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 49);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox3.Image = global::InventoryManagementSystem.Properties.Resources.add_to_cart;
            this.pictureBox3.Location = new System.Drawing.Point(352, 466);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox4.Image = global::InventoryManagementSystem.Properties.Resources.shopping_bag;
            this.pictureBox4.Location = new System.Drawing.Point(352, 346);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox5.Image = global::InventoryManagementSystem.Properties.Resources.analysis;
            this.pictureBox5.Location = new System.Drawing.Point(431, 300);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox2.Image = global::InventoryManagementSystem.Properties.Resources.setting;
            this.pictureBox2.Location = new System.Drawing.Point(142, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources.product_research;
            this.pictureBox1.Location = new System.Drawing.Point(361, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 730);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Salmon;
            this.Name = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProductForCustomer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONALINFORMATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDERHISTORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sETTINGSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITPERSONALINFORMATIONToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvShowProductForCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchProductForCustomer;
        private MetroFramework.Controls.MetroTextBox txtSearchProductForCustomer;
        private System.Windows.Forms.Button btnlogoutcustomer;
        private System.Windows.Forms.ComboBox cmbSelectProductForCustomer;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtProductQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOrderProduct;
        private System.Windows.Forms.ToolStripMenuItem mYSELECTIONLISTToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddtoList;
        private System.Windows.Forms.Button btnCalculateTotalPrice;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}