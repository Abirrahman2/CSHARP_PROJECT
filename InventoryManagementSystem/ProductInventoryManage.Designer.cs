namespace InventoryManagementSystem
{
    partial class ProductInventoryManage
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
            this.dgvProductAdd = new System.Windows.Forms.DataGridView();
            this.dgvProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvInventoryAdding = new System.Windows.Forms.DataGridView();
            this.dgvInventoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaxCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaxCapacity = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtInventoryCapacityView = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmountOfProduct = new System.Windows.Forms.TextBox();
            this.txtProductIdAuto = new MetroFramework.Controls.MetroTextBox();
            this.txtInventoryIdAuto = new MetroFramework.Controls.MetroTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddProductInventory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAdd)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryAdding)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1391, 632);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvProductAdd);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(976, 66);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(412, 563);
            this.panel6.TabIndex = 5;
            // 
            // dgvProductAdd
            // 
            this.dgvProductAdd.AllowUserToAddRows = false;
            this.dgvProductAdd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvProductAdd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductAdd.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvProductAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductId,
            this.dgvProductName,
            this.dgvProductDescription});
            this.dgvProductAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductAdd.Location = new System.Drawing.Point(0, 0);
            this.dgvProductAdd.Name = "dgvProductAdd";
            this.dgvProductAdd.ReadOnly = true;
            this.dgvProductAdd.RowTemplate.Height = 24;
            this.dgvProductAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductAdd.Size = new System.Drawing.Size(412, 563);
            this.dgvProductAdd.TabIndex = 1;
            this.dgvProductAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductAdd_CellClick);
            // 
            // dgvProductId
            // 
            this.dgvProductId.DataPropertyName = "Id";
            this.dgvProductId.HeaderText = "Id";
            this.dgvProductId.Name = "dgvProductId";
            this.dgvProductId.ReadOnly = true;
            // 
            // dgvProductName
            // 
            this.dgvProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductName.DataPropertyName = "Name";
            this.dgvProductName.HeaderText = "PRODUCT NAME";
            this.dgvProductName.Name = "dgvProductName";
            this.dgvProductName.ReadOnly = true;
            // 
            // dgvProductDescription
            // 
            this.dgvProductDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductDescription.DataPropertyName = "Description";
            this.dgvProductDescription.HeaderText = "DESCRIPTION";
            this.dgvProductDescription.Name = "dgvProductDescription";
            this.dgvProductDescription.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvInventoryAdding);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(420, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(550, 563);
            this.panel5.TabIndex = 4;
            // 
            // dgvInventoryAdding
            // 
            this.dgvInventoryAdding.AllowUserToAddRows = false;
            this.dgvInventoryAdding.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvInventoryAdding.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryAdding.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvInventoryAdding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryAdding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvInventoryId,
            this.dgvCapacity,
            this.dgvMaxCapacity,
            this.dgvDescription});
            this.dgvInventoryAdding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventoryAdding.Location = new System.Drawing.Point(0, 0);
            this.dgvInventoryAdding.Name = "dgvInventoryAdding";
            this.dgvInventoryAdding.ReadOnly = true;
            this.dgvInventoryAdding.RowTemplate.Height = 24;
            this.dgvInventoryAdding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryAdding.Size = new System.Drawing.Size(550, 563);
            this.dgvInventoryAdding.TabIndex = 0;
            this.dgvInventoryAdding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryAdding_CellClick);
            // 
            // dgvInventoryId
            // 
            this.dgvInventoryId.DataPropertyName = "Id";
            this.dgvInventoryId.HeaderText = "ID";
            this.dgvInventoryId.Name = "dgvInventoryId";
            this.dgvInventoryId.ReadOnly = true;
            // 
            // dgvCapacity
            // 
            this.dgvCapacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCapacity.DataPropertyName = "Capacity";
            this.dgvCapacity.HeaderText = "INVENTORY CAPACITY";
            this.dgvCapacity.Name = "dgvCapacity";
            this.dgvCapacity.ReadOnly = true;
            // 
            // dgvMaxCapacity
            // 
            this.dgvMaxCapacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaxCapacity.DataPropertyName = "MaxCapacity";
            this.dgvMaxCapacity.HeaderText = "MAX CAPACITY";
            this.dgvMaxCapacity.Name = "dgvMaxCapacity";
            this.dgvMaxCapacity.ReadOnly = true;
            // 
            // dgvDescription
            // 
            this.dgvDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDescription.DataPropertyName = "Description";
            this.dgvDescription.HeaderText = "DESCRIPTION";
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel4.Location = new System.Drawing.Point(976, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 57);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ALL PRODUCT INFORMATION";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventoryManagementSystem.Properties.Resources.about;
            this.pictureBox2.Location = new System.Drawing.Point(13, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel3.Location = new System.Drawing.Point(420, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 57);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ALL INVENTORY INFORMATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources.about;
            this.pictureBox1.Location = new System.Drawing.Point(65, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 57);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD PRODUCT IN INVENTORY";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InventoryManagementSystem.Properties.Resources.plus;
            this.pictureBox3.Location = new System.Drawing.Point(3, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.txtMaxCapacity);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtInventoryCapacityView);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtAmountOfProduct);
            this.panel1.Controls.Add(this.txtProductIdAuto);
            this.panel1.Controls.Add(this.txtInventoryIdAuto);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnAddProductInventory);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 563);
            this.panel1.TabIndex = 0;
            // 
            // txtMaxCapacity
            // 
            // 
            // 
            // 
            this.txtMaxCapacity.CustomButton.Image = null;
            this.txtMaxCapacity.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtMaxCapacity.CustomButton.Name = "";
            this.txtMaxCapacity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaxCapacity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaxCapacity.CustomButton.TabIndex = 1;
            this.txtMaxCapacity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaxCapacity.CustomButton.UseSelectable = true;
            this.txtMaxCapacity.CustomButton.Visible = false;
            this.txtMaxCapacity.Lines = new string[0];
            this.txtMaxCapacity.Location = new System.Drawing.Point(30, 229);
            this.txtMaxCapacity.MaxLength = 32767;
            this.txtMaxCapacity.Name = "txtMaxCapacity";
            this.txtMaxCapacity.PasswordChar = '\0';
            this.txtMaxCapacity.PromptText = "AUTO GENERATED";
            this.txtMaxCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxCapacity.SelectedText = "";
            this.txtMaxCapacity.SelectionLength = 0;
            this.txtMaxCapacity.SelectionStart = 0;
            this.txtMaxCapacity.ShortcutsEnabled = true;
            this.txtMaxCapacity.Size = new System.Drawing.Size(225, 23);
            this.txtMaxCapacity.TabIndex = 15;
            this.txtMaxCapacity.UseSelectable = true;
            this.txtMaxCapacity.WaterMark = "AUTO GENERATED";
            this.txtMaxCapacity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxCapacity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "INVENTORY MAX CAPACITY";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(299, 518);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 56);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtInventoryCapacityView
            // 
            // 
            // 
            // 
            this.txtInventoryCapacityView.CustomButton.Image = null;
            this.txtInventoryCapacityView.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtInventoryCapacityView.CustomButton.Name = "";
            this.txtInventoryCapacityView.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventoryCapacityView.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventoryCapacityView.CustomButton.TabIndex = 1;
            this.txtInventoryCapacityView.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventoryCapacityView.CustomButton.UseSelectable = true;
            this.txtInventoryCapacityView.CustomButton.Visible = false;
            this.txtInventoryCapacityView.Lines = new string[0];
            this.txtInventoryCapacityView.Location = new System.Drawing.Point(30, 150);
            this.txtInventoryCapacityView.MaxLength = 32767;
            this.txtInventoryCapacityView.Name = "txtInventoryCapacityView";
            this.txtInventoryCapacityView.PasswordChar = '\0';
            this.txtInventoryCapacityView.PromptText = "AUTO GENERATED";
            this.txtInventoryCapacityView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventoryCapacityView.SelectedText = "";
            this.txtInventoryCapacityView.SelectionLength = 0;
            this.txtInventoryCapacityView.SelectionStart = 0;
            this.txtInventoryCapacityView.ShortcutsEnabled = true;
            this.txtInventoryCapacityView.Size = new System.Drawing.Size(225, 23);
            this.txtInventoryCapacityView.TabIndex = 12;
            this.txtInventoryCapacityView.UseSelectable = true;
            this.txtInventoryCapacityView.WaterMark = "AUTO GENERATED";
            this.txtInventoryCapacityView.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventoryCapacityView.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInventoryCapacityView.Click += new System.EventHandler(this.txtInventoryCapacityView_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "INVENTORY CURRENT CAPACITY";
            // 
            // txtAmountOfProduct
            // 
            this.txtAmountOfProduct.Location = new System.Drawing.Point(30, 384);
            this.txtAmountOfProduct.Multiline = true;
            this.txtAmountOfProduct.Name = "txtAmountOfProduct";
            this.txtAmountOfProduct.Size = new System.Drawing.Size(261, 37);
            this.txtAmountOfProduct.TabIndex = 10;
            // 
            // txtProductIdAuto
            // 
            // 
            // 
            // 
            this.txtProductIdAuto.CustomButton.Image = null;
            this.txtProductIdAuto.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtProductIdAuto.CustomButton.Name = "";
            this.txtProductIdAuto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductIdAuto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductIdAuto.CustomButton.TabIndex = 1;
            this.txtProductIdAuto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductIdAuto.CustomButton.UseSelectable = true;
            this.txtProductIdAuto.CustomButton.Visible = false;
            this.txtProductIdAuto.Lines = new string[0];
            this.txtProductIdAuto.Location = new System.Drawing.Point(30, 299);
            this.txtProductIdAuto.MaxLength = 32767;
            this.txtProductIdAuto.Name = "txtProductIdAuto";
            this.txtProductIdAuto.PasswordChar = '\0';
            this.txtProductIdAuto.PromptText = "AUTO GENERATED";
            this.txtProductIdAuto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductIdAuto.SelectedText = "";
            this.txtProductIdAuto.SelectionLength = 0;
            this.txtProductIdAuto.SelectionStart = 0;
            this.txtProductIdAuto.ShortcutsEnabled = true;
            this.txtProductIdAuto.Size = new System.Drawing.Size(225, 23);
            this.txtProductIdAuto.TabIndex = 9;
            this.txtProductIdAuto.UseSelectable = true;
            this.txtProductIdAuto.WaterMark = "AUTO GENERATED";
            this.txtProductIdAuto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductIdAuto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInventoryIdAuto
            // 
            // 
            // 
            // 
            this.txtInventoryIdAuto.CustomButton.Image = null;
            this.txtInventoryIdAuto.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtInventoryIdAuto.CustomButton.Name = "";
            this.txtInventoryIdAuto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventoryIdAuto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventoryIdAuto.CustomButton.TabIndex = 1;
            this.txtInventoryIdAuto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventoryIdAuto.CustomButton.UseSelectable = true;
            this.txtInventoryIdAuto.CustomButton.Visible = false;
            this.txtInventoryIdAuto.Lines = new string[0];
            this.txtInventoryIdAuto.Location = new System.Drawing.Point(30, 63);
            this.txtInventoryIdAuto.MaxLength = 32767;
            this.txtInventoryIdAuto.Name = "txtInventoryIdAuto";
            this.txtInventoryIdAuto.PasswordChar = '\0';
            this.txtInventoryIdAuto.PromptText = "AUTO GENERATED";
            this.txtInventoryIdAuto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventoryIdAuto.SelectedText = "";
            this.txtInventoryIdAuto.SelectionLength = 0;
            this.txtInventoryIdAuto.SelectionStart = 0;
            this.txtInventoryIdAuto.ShortcutsEnabled = true;
            this.txtInventoryIdAuto.Size = new System.Drawing.Size(225, 23);
            this.txtInventoryIdAuto.TabIndex = 8;
            this.txtInventoryIdAuto.UseSelectable = true;
            this.txtInventoryIdAuto.WaterMark = "AUTO GENERATED";
            this.txtInventoryIdAuto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventoryIdAuto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 518);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 56);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddProductInventory
            // 
            this.btnAddProductInventory.Location = new System.Drawing.Point(150, 436);
            this.btnAddProductInventory.Name = "btnAddProductInventory";
            this.btnAddProductInventory.Size = new System.Drawing.Size(118, 56);
            this.btnAddProductInventory.TabIndex = 6;
            this.btnAddProductInventory.Text = "ADD";
            this.btnAddProductInventory.UseVisualStyleBackColor = true;
            this.btnAddProductInventory.Click += new System.EventHandler(this.btnAddProductInventory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "ENTER AMOUNT OF YOUR PRODUCT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "PRODUCT ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "INVENTORY ID";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::InventoryManagementSystem.Properties.Resources.logistics;
            this.pictureBox4.Location = new System.Drawing.Point(273, 436);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // ProductInventoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 712);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductInventoryManage";
            this.Load += new System.EventHandler(this.ProductInventoryManage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAdd)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryAdding)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProductAdd;
        private System.Windows.Forms.DataGridView dgvInventoryAdding;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddProductInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductDescription;
        private MetroFramework.Controls.MetroTextBox txtProductIdAuto;
        private MetroFramework.Controls.MetroTextBox txtInventoryIdAuto;
        private System.Windows.Forms.TextBox txtAmountOfProduct;
        private MetroFramework.Controls.MetroTextBox txtInventoryCapacityView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaxCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtMaxCapacity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}