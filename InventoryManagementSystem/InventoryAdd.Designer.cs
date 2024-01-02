namespace InventoryManagementSystem
{
    partial class InventoryAdd
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvInventoryAdd = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvADDRESSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCAPACITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaxCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInventoryRefresh = new System.Windows.Forms.Button();
            this.btnInventoryNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateInventory = new System.Windows.Forms.Button();
            this.btnInventoryEditBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaxCapacity = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtInventoryAddress = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInventoryDescription = new System.Windows.Forms.TextBox();
            this.txtInventoryCapacity = new MetroFramework.Controls.MetroTextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.cmbboxInventoryEdit = new System.Windows.Forms.ComboBox();
            this.lblInventoryEditDistrict = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryAdd)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1480, 695);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(566, 628);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(911, 64);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvInventoryAdd);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(566, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(911, 550);
            this.panel5.TabIndex = 4;
            // 
            // dgvInventoryAdd
            // 
            this.dgvInventoryAdd.AllowUserToAddRows = false;
            this.dgvInventoryAdd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvInventoryAdd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryAdd.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryAdd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvADDRESSS,
            this.dgvCAPACITY,
            this.dgvDescription,
            this.dgvMaxCapacity});
            this.dgvInventoryAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventoryAdd.Location = new System.Drawing.Point(0, 0);
            this.dgvInventoryAdd.Name = "dgvInventoryAdd";
            this.dgvInventoryAdd.ReadOnly = true;
            this.dgvInventoryAdd.RowTemplate.Height = 24;
            this.dgvInventoryAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryAdd.Size = new System.Drawing.Size(911, 550);
            this.dgvInventoryAdd.TabIndex = 0;
            this.dgvInventoryAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryAdd_CellClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "Id";
            this.dgvID.HeaderText = "Ref";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            // 
            // dgvADDRESSS
            // 
            this.dgvADDRESSS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvADDRESSS.DataPropertyName = "Address";
            this.dgvADDRESSS.HeaderText = "ADDRESS";
            this.dgvADDRESSS.Name = "dgvADDRESSS";
            this.dgvADDRESSS.ReadOnly = true;
            // 
            // dgvCAPACITY
            // 
            this.dgvCAPACITY.DataPropertyName = "Capacity";
            this.dgvCAPACITY.HeaderText = "CAPACITY(IN KG)";
            this.dgvCAPACITY.Name = "dgvCAPACITY";
            this.dgvCAPACITY.ReadOnly = true;
            this.dgvCAPACITY.Width = 150;
            // 
            // dgvDescription
            // 
            this.dgvDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDescription.DataPropertyName = "Description";
            this.dgvDescription.HeaderText = "DESCRIPTION";
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.ReadOnly = true;
            // 
            // dgvMaxCapacity
            // 
            this.dgvMaxCapacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaxCapacity.DataPropertyName = "MaxCapacity";
            this.dgvMaxCapacity.HeaderText = "MAX CAPACITY";
            this.dgvMaxCapacity.Name = "dgvMaxCapacity";
            this.dgvMaxCapacity.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.btnInventoryRefresh);
            this.panel4.Controls.Add(this.btnInventoryNew);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(566, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(911, 63);
            this.panel4.TabIndex = 3;
            // 
            // btnInventoryRefresh
            // 
            this.btnInventoryRefresh.BackColor = System.Drawing.Color.SeaShell;
            this.btnInventoryRefresh.Location = new System.Drawing.Point(705, 10);
            this.btnInventoryRefresh.Name = "btnInventoryRefresh";
            this.btnInventoryRefresh.Size = new System.Drawing.Size(113, 44);
            this.btnInventoryRefresh.TabIndex = 3;
            this.btnInventoryRefresh.Text = "REFRESH";
            this.btnInventoryRefresh.UseVisualStyleBackColor = false;
            this.btnInventoryRefresh.Click += new System.EventHandler(this.btnInventoryRefresh_Click);
            // 
            // btnInventoryNew
            // 
            this.btnInventoryNew.BackColor = System.Drawing.Color.SeaShell;
            this.btnInventoryNew.Location = new System.Drawing.Point(0, 16);
            this.btnInventoryNew.Name = "btnInventoryNew";
            this.btnInventoryNew.Size = new System.Drawing.Size(124, 44);
            this.btnInventoryNew.TabIndex = 2;
            this.btnInventoryNew.Text = "NEW";
            this.btnInventoryNew.UseVisualStyleBackColor = false;
            this.btnInventoryNew.Click += new System.EventHandler(this.btnInventoryNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources.reload;
            this.pictureBox1.Location = new System.Drawing.Point(811, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventoryManagementSystem.Properties.Resources.add_message;
            this.pictureBox2.Location = new System.Drawing.Point(109, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 63);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ADD NEW INVENTORY";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateInventory);
            this.panel1.Controls.Add(this.btnInventoryEditBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnCreateInventory
            // 
            this.btnCreateInventory.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCreateInventory.Location = new System.Drawing.Point(400, 6);
            this.btnCreateInventory.Name = "btnCreateInventory";
            this.btnCreateInventory.Size = new System.Drawing.Size(154, 47);
            this.btnCreateInventory.TabIndex = 1;
            this.btnCreateInventory.Text = "ADD";
            this.btnCreateInventory.UseVisualStyleBackColor = false;
            this.btnCreateInventory.Click += new System.EventHandler(this.btnCreateInventory_Click);
            // 
            // btnInventoryEditBack
            // 
            this.btnInventoryEditBack.BackColor = System.Drawing.Color.SandyBrown;
            this.btnInventoryEditBack.Location = new System.Drawing.Point(3, 3);
            this.btnInventoryEditBack.Name = "btnInventoryEditBack";
            this.btnInventoryEditBack.Size = new System.Drawing.Size(158, 55);
            this.btnInventoryEditBack.TabIndex = 0;
            this.btnInventoryEditBack.Text = "BACK";
            this.btnInventoryEditBack.UseVisualStyleBackColor = false;
            this.btnInventoryEditBack.Click += new System.EventHandler(this.btnInventoryEditBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.txtMaxCapacity);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.txtInventoryAddress);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtInventoryDescription);
            this.panel2.Controls.Add(this.txtInventoryCapacity);
            this.panel2.Controls.Add(this.lblCapacity);
            this.panel2.Controls.Add(this.cmbboxInventoryEdit);
            this.panel2.Controls.Add(this.lblInventoryEditDistrict);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(3, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 550);
            this.panel2.TabIndex = 1;
            // 
            // txtMaxCapacity
            // 
            // 
            // 
            // 
            this.txtMaxCapacity.CustomButton.Image = null;
            this.txtMaxCapacity.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtMaxCapacity.CustomButton.Name = "";
            this.txtMaxCapacity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaxCapacity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaxCapacity.CustomButton.TabIndex = 1;
            this.txtMaxCapacity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaxCapacity.CustomButton.UseSelectable = true;
            this.txtMaxCapacity.CustomButton.Visible = false;
            this.txtMaxCapacity.Lines = new string[0];
            this.txtMaxCapacity.Location = new System.Drawing.Point(235, 255);
            this.txtMaxCapacity.MaxLength = 32767;
            this.txtMaxCapacity.Name = "txtMaxCapacity";
            this.txtMaxCapacity.PasswordChar = '\0';
            this.txtMaxCapacity.PromptText = "ENTER MAX CAPACITY IN KG";
            this.txtMaxCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxCapacity.SelectedText = "";
            this.txtMaxCapacity.SelectionLength = 0;
            this.txtMaxCapacity.SelectionStart = 0;
            this.txtMaxCapacity.ShortcutsEnabled = true;
            this.txtMaxCapacity.Size = new System.Drawing.Size(270, 23);
            this.txtMaxCapacity.TabIndex = 13;
            this.txtMaxCapacity.UseSelectable = true;
            this.txtMaxCapacity.WaterMark = "ENTER MAX CAPACITY IN KG";
            this.txtMaxCapacity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxCapacity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "MAX CAPACITY";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Snow;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(109, 136);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(108, 25);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "ADDRESS";
            // 
            // txtInventoryAddress
            // 
            // 
            // 
            // 
            this.txtInventoryAddress.CustomButton.Image = null;
            this.txtInventoryAddress.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtInventoryAddress.CustomButton.Name = "";
            this.txtInventoryAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventoryAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventoryAddress.CustomButton.TabIndex = 1;
            this.txtInventoryAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventoryAddress.CustomButton.UseSelectable = true;
            this.txtInventoryAddress.CustomButton.Visible = false;
            this.txtInventoryAddress.Lines = new string[0];
            this.txtInventoryAddress.Location = new System.Drawing.Point(235, 136);
            this.txtInventoryAddress.MaxLength = 32767;
            this.txtInventoryAddress.Name = "txtInventoryAddress";
            this.txtInventoryAddress.PasswordChar = '\0';
            this.txtInventoryAddress.PromptText = "ENTER ADDRESS";
            this.txtInventoryAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventoryAddress.SelectedText = "";
            this.txtInventoryAddress.SelectionLength = 0;
            this.txtInventoryAddress.SelectionStart = 0;
            this.txtInventoryAddress.ShortcutsEnabled = true;
            this.txtInventoryAddress.Size = new System.Drawing.Size(270, 23);
            this.txtInventoryAddress.TabIndex = 10;
            this.txtInventoryAddress.UseSelectable = true;
            this.txtInventoryAddress.WaterMark = "ENTER ADDRESS";
            this.txtInventoryAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventoryAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "DESCRIPTION";
            // 
            // txtInventoryDescription
            // 
            this.txtInventoryDescription.BackColor = System.Drawing.Color.Snow;
            this.txtInventoryDescription.ForeColor = System.Drawing.Color.Red;
            this.txtInventoryDescription.Location = new System.Drawing.Point(3, 377);
            this.txtInventoryDescription.Multiline = true;
            this.txtInventoryDescription.Name = "txtInventoryDescription";
            this.txtInventoryDescription.Size = new System.Drawing.Size(381, 150);
            this.txtInventoryDescription.TabIndex = 8;
            // 
            // txtInventoryCapacity
            // 
            // 
            // 
            // 
            this.txtInventoryCapacity.CustomButton.Image = null;
            this.txtInventoryCapacity.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtInventoryCapacity.CustomButton.Name = "";
            this.txtInventoryCapacity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventoryCapacity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventoryCapacity.CustomButton.TabIndex = 1;
            this.txtInventoryCapacity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventoryCapacity.CustomButton.UseSelectable = true;
            this.txtInventoryCapacity.CustomButton.Visible = false;
            this.txtInventoryCapacity.Lines = new string[0];
            this.txtInventoryCapacity.Location = new System.Drawing.Point(235, 203);
            this.txtInventoryCapacity.MaxLength = 32767;
            this.txtInventoryCapacity.Name = "txtInventoryCapacity";
            this.txtInventoryCapacity.PasswordChar = '\0';
            this.txtInventoryCapacity.PromptText = "ENTER CAPACITY IN KG";
            this.txtInventoryCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventoryCapacity.SelectedText = "";
            this.txtInventoryCapacity.SelectionLength = 0;
            this.txtInventoryCapacity.SelectionStart = 0;
            this.txtInventoryCapacity.ShortcutsEnabled = true;
            this.txtInventoryCapacity.Size = new System.Drawing.Size(270, 23);
            this.txtInventoryCapacity.TabIndex = 7;
            this.txtInventoryCapacity.UseSelectable = true;
            this.txtInventoryCapacity.WaterMark = "ENTER CAPACITY IN KG";
            this.txtInventoryCapacity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventoryCapacity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.BackColor = System.Drawing.Color.Snow;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(3, 203);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(214, 25);
            this.lblCapacity.TabIndex = 6;
            this.lblCapacity.Text = "CURRENT CAPACITY";
            // 
            // cmbboxInventoryEdit
            // 
            this.cmbboxInventoryEdit.FormattingEnabled = true;
            this.cmbboxInventoryEdit.Items.AddRange(new object[] {
            "DHAKA",
            "BANDARBAN",
            "FENI",
            "CUMILLA",
            "BARISHAL",
            "SYLET",
            "CHITTAGANG"});
            this.cmbboxInventoryEdit.Location = new System.Drawing.Point(235, 76);
            this.cmbboxInventoryEdit.Name = "cmbboxInventoryEdit";
            this.cmbboxInventoryEdit.Size = new System.Drawing.Size(270, 24);
            this.cmbboxInventoryEdit.TabIndex = 1;
            this.cmbboxInventoryEdit.SelectedIndexChanged += new System.EventHandler(this.cmbboxInventoryEdit_SelectedIndexChanged);
            // 
            // lblInventoryEditDistrict
            // 
            this.lblInventoryEditDistrict.AutoSize = true;
            this.lblInventoryEditDistrict.BackColor = System.Drawing.Color.Snow;
            this.lblInventoryEditDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryEditDistrict.Location = new System.Drawing.Point(109, 76);
            this.lblInventoryEditDistrict.Name = "lblInventoryEditDistrict";
            this.lblInventoryEditDistrict.Size = new System.Drawing.Size(104, 25);
            this.lblInventoryEditDistrict.TabIndex = 0;
            this.lblInventoryEditDistrict.Text = "DISTRICT";
            // 
            // InventoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 775);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InventoryAdd";
            this.Text = "MANAGE INVENTORY ADD";
            this.Load += new System.EventHandler(this.InventoryAdd_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryAdd)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInventoryEditBack;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbboxInventoryEdit;
        private System.Windows.Forms.Label lblInventoryEditDistrict;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInventoryDescription;
        private MetroFramework.Controls.MetroTextBox txtInventoryCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.DataGridView dgvInventoryAdd;
        private System.Windows.Forms.Button btnCreateInventory;
        private System.Windows.Forms.Label lblAddress;
        private MetroFramework.Controls.MetroTextBox txtInventoryAddress;
        private System.Windows.Forms.Button btnInventoryRefresh;
        private System.Windows.Forms.Button btnInventoryNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvADDRESSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCAPACITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaxCapacity;
        private MetroFramework.Controls.MetroTextBox txtMaxCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}