namespace InventoryManagementSystem
{
    partial class ManageInventoryUpdate
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvInventoryUpdate = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvADDRESSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCAPACITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaxCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInventoryDelete = new System.Windows.Forms.Button();
            this.btnInventoryRefresh = new System.Windows.Forms.Button();
            this.btnInventoryNew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            this.btnInventoryEditBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaxCapacity = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInventoryId = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtInventoryAddress = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInventoryDescription = new System.Windows.Forms.TextBox();
            this.txtInventoryCapacity = new MetroFramework.Controls.MetroTextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.cmbboxInventoryUpdate = new System.Windows.Forms.ComboBox();
            this.lblInventoryEditDistrict = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryUpdate)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.02033F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.97967F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1479, 695);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PeachPuff;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(535, 628);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(941, 64);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvInventoryUpdate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(535, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(941, 550);
            this.panel5.TabIndex = 4;
            // 
            // dgvInventoryUpdate
            // 
            this.dgvInventoryUpdate.AllowUserToAddRows = false;
            this.dgvInventoryUpdate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvInventoryUpdate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryUpdate.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvInventoryUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvADDRESSS,
            this.dgvCAPACITY,
            this.dgvDescription,
            this.dgvMaxCapacity});
            this.dgvInventoryUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventoryUpdate.Location = new System.Drawing.Point(0, 0);
            this.dgvInventoryUpdate.Name = "dgvInventoryUpdate";
            this.dgvInventoryUpdate.ReadOnly = true;
            this.dgvInventoryUpdate.RowTemplate.Height = 24;
            this.dgvInventoryUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryUpdate.Size = new System.Drawing.Size(941, 550);
            this.dgvInventoryUpdate.TabIndex = 0;
            this.dgvInventoryUpdate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryUpdate_CellClick);
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
            this.panel4.Controls.Add(this.btnInventoryDelete);
            this.panel4.Controls.Add(this.btnInventoryRefresh);
            this.panel4.Controls.Add(this.btnInventoryNew);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(535, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(941, 63);
            this.panel4.TabIndex = 3;
            // 
            // btnInventoryDelete
            // 
            this.btnInventoryDelete.BackColor = System.Drawing.Color.SandyBrown;
            this.btnInventoryDelete.Location = new System.Drawing.Point(426, 5);
            this.btnInventoryDelete.Name = "btnInventoryDelete";
            this.btnInventoryDelete.Size = new System.Drawing.Size(123, 58);
            this.btnInventoryDelete.TabIndex = 4;
            this.btnInventoryDelete.Text = "DELETE";
            this.btnInventoryDelete.UseVisualStyleBackColor = false;
            this.btnInventoryDelete.Click += new System.EventHandler(this.btnInventoryDelete_Click);
            // 
            // btnInventoryRefresh
            // 
            this.btnInventoryRefresh.BackColor = System.Drawing.Color.SandyBrown;
            this.btnInventoryRefresh.Location = new System.Drawing.Point(795, 5);
            this.btnInventoryRefresh.Name = "btnInventoryRefresh";
            this.btnInventoryRefresh.Size = new System.Drawing.Size(131, 58);
            this.btnInventoryRefresh.TabIndex = 3;
            this.btnInventoryRefresh.Text = "REFRESH";
            this.btnInventoryRefresh.UseVisualStyleBackColor = false;
            this.btnInventoryRefresh.Click += new System.EventHandler(this.btnInventoryRefresh_Click);
            // 
            // btnInventoryNew
            // 
            this.btnInventoryNew.BackColor = System.Drawing.Color.SandyBrown;
            this.btnInventoryNew.Location = new System.Drawing.Point(3, 3);
            this.btnInventoryNew.Name = "btnInventoryNew";
            this.btnInventoryNew.Size = new System.Drawing.Size(123, 58);
            this.btnInventoryNew.TabIndex = 2;
            this.btnInventoryNew.Text = "NEW";
            this.btnInventoryNew.UseVisualStyleBackColor = false;
            this.btnInventoryNew.Click += new System.EventHandler(this.btnInventoryNew_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 63);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE INVENTORY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnUpdateInventory);
            this.panel1.Controls.Add(this.btnInventoryEditBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUpdateInventory.Location = new System.Drawing.Point(365, 3);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(148, 55);
            this.btnUpdateInventory.TabIndex = 1;
            this.btnUpdateInventory.Text = "UPDATE";
            this.btnUpdateInventory.UseVisualStyleBackColor = false;
            this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
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
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.txtMaxCapacity);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtInventoryId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.txtInventoryAddress);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtInventoryDescription);
            this.panel2.Controls.Add(this.txtInventoryCapacity);
            this.panel2.Controls.Add(this.lblCapacity);
            this.panel2.Controls.Add(this.cmbboxInventoryUpdate);
            this.panel2.Controls.Add(this.lblInventoryEditDistrict);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(3, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 550);
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
            this.txtMaxCapacity.Location = new System.Drawing.Point(243, 264);
            this.txtMaxCapacity.MaxLength = 32767;
            this.txtMaxCapacity.Name = "txtMaxCapacity";
            this.txtMaxCapacity.PasswordChar = '\0';
            this.txtMaxCapacity.PromptText = "ENTER  MAX CAPACITY IN KG";
            this.txtMaxCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxCapacity.SelectedText = "";
            this.txtMaxCapacity.SelectionLength = 0;
            this.txtMaxCapacity.SelectionStart = 0;
            this.txtMaxCapacity.ShortcutsEnabled = true;
            this.txtMaxCapacity.Size = new System.Drawing.Size(270, 23);
            this.txtMaxCapacity.TabIndex = 15;
            this.txtMaxCapacity.UseSelectable = true;
            this.txtMaxCapacity.WaterMark = "ENTER  MAX CAPACITY IN KG";
            this.txtMaxCapacity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxCapacity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "MAX CAPACITY";
            // 
            // txtInventoryId
            // 
            // 
            // 
            // 
            this.txtInventoryId.CustomButton.Image = null;
            this.txtInventoryId.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtInventoryId.CustomButton.Name = "";
            this.txtInventoryId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventoryId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventoryId.CustomButton.TabIndex = 1;
            this.txtInventoryId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventoryId.CustomButton.UseSelectable = true;
            this.txtInventoryId.CustomButton.Visible = false;
            this.txtInventoryId.Enabled = false;
            this.txtInventoryId.Lines = new string[0];
            this.txtInventoryId.Location = new System.Drawing.Point(243, 38);
            this.txtInventoryId.MaxLength = 32767;
            this.txtInventoryId.Name = "txtInventoryId";
            this.txtInventoryId.PasswordChar = '\0';
            this.txtInventoryId.PromptText = "AUTO GENERATED ID";
            this.txtInventoryId.ReadOnly = true;
            this.txtInventoryId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventoryId.SelectedText = "";
            this.txtInventoryId.SelectionLength = 0;
            this.txtInventoryId.SelectionStart = 0;
            this.txtInventoryId.ShortcutsEnabled = true;
            this.txtInventoryId.Size = new System.Drawing.Size(270, 23);
            this.txtInventoryId.TabIndex = 13;
            this.txtInventoryId.UseSelectable = true;
            this.txtInventoryId.WaterMark = "AUTO GENERATED ID";
            this.txtInventoryId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventoryId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(119, 165);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(115, 25);
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
            this.txtInventoryAddress.Location = new System.Drawing.Point(243, 167);
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
            this.txtInventoryCapacity.Location = new System.Drawing.Point(243, 218);
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
            this.txtInventoryCapacity.Click += new System.EventHandler(this.txtInventoryCapacity_Click);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(13, 216);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(230, 25);
            this.lblCapacity.TabIndex = 6;
            this.lblCapacity.Text = "CURRENT CAPACITY";
            // 
            // cmbboxInventoryUpdate
            // 
            this.cmbboxInventoryUpdate.FormattingEnabled = true;
            this.cmbboxInventoryUpdate.Items.AddRange(new object[] {
            "DHAKA",
            "BANDARBAN",
            "FENI",
            "CUMILLA",
            "BARISHAL",
            "SYLET",
            "CHITTAGANG"});
            this.cmbboxInventoryUpdate.Location = new System.Drawing.Point(243, 111);
            this.cmbboxInventoryUpdate.Name = "cmbboxInventoryUpdate";
            this.cmbboxInventoryUpdate.Size = new System.Drawing.Size(270, 24);
            this.cmbboxInventoryUpdate.TabIndex = 1;
            // 
            // lblInventoryEditDistrict
            // 
            this.lblInventoryEditDistrict.AutoSize = true;
            this.lblInventoryEditDistrict.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInventoryEditDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryEditDistrict.Location = new System.Drawing.Point(123, 107);
            this.lblInventoryEditDistrict.Name = "lblInventoryEditDistrict";
            this.lblInventoryEditDistrict.Size = new System.Drawing.Size(112, 25);
            this.lblInventoryEditDistrict.TabIndex = 0;
            this.lblInventoryEditDistrict.Text = "DISTRICT";
            // 
            // ManageInventoryUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 775);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageInventoryUpdate";
            this.Text = "MANAGE INVENTORY UPDATE";
            this.Load += new System.EventHandler(this.ManageInventoryUpdate_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryUpdate)).EndInit();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cmbboxInventoryUpdate;
        private System.Windows.Forms.Label lblInventoryEditDistrict;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInventoryDescription;
        private MetroFramework.Controls.MetroTextBox txtInventoryCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.DataGridView dgvInventoryUpdate;
        private System.Windows.Forms.Button btnUpdateInventory;
        private System.Windows.Forms.Label lblAddress;
        private MetroFramework.Controls.MetroTextBox txtInventoryAddress;
        private System.Windows.Forms.Button btnInventoryRefresh;
        private System.Windows.Forms.Button btnInventoryNew;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtInventoryId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInventoryDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvADDRESSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCAPACITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaxCapacity;
        private MetroFramework.Controls.MetroTextBox txtMaxCapacity;
    }
}