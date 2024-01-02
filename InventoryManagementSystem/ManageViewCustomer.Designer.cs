namespace InventoryManagementSystem
{
    partial class ManageViewCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotalAmountPaid = new System.Windows.Forms.TextBox();
            this.txtTotalOrderPlaced = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtViewCustomerId = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtViewCustomerEmail = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcustomerviewname = new MetroFramework.Controls.MetroTextBox();
            this.lblcustomernameview = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvManageViewCustomer = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewCustomerRefresh = new System.Windows.Forms.Button();
            this.btnbackviewcustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageViewCustomer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.873F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.127F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1557, 686);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTotalAmountPaid);
            this.panel4.Controls.Add(this.txtTotalOrderPlaced);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtViewCustomerId);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtViewCustomerEmail);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtcustomerviewname);
            this.panel4.Controls.Add(this.lblcustomernameview);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(919, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 612);
            this.panel4.TabIndex = 3;
            // 
            // txtTotalAmountPaid
            // 
            this.txtTotalAmountPaid.Location = new System.Drawing.Point(232, 259);
            this.txtTotalAmountPaid.Name = "txtTotalAmountPaid";
            this.txtTotalAmountPaid.ReadOnly = true;
            this.txtTotalAmountPaid.Size = new System.Drawing.Size(203, 22);
            this.txtTotalAmountPaid.TabIndex = 10;
            // 
            // txtTotalOrderPlaced
            // 
            this.txtTotalOrderPlaced.Location = new System.Drawing.Point(232, 205);
            this.txtTotalOrderPlaced.Name = "txtTotalOrderPlaced";
            this.txtTotalOrderPlaced.ReadOnly = true;
            this.txtTotalOrderPlaced.Size = new System.Drawing.Size(203, 22);
            this.txtTotalOrderPlaced.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(19, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "TOTAL AMOUNT PAID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(0, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TOTAL ORDER PLACED:";
            // 
            // txtViewCustomerId
            // 
            // 
            // 
            // 
            this.txtViewCustomerId.CustomButton.Image = null;
            this.txtViewCustomerId.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtViewCustomerId.CustomButton.Name = "";
            this.txtViewCustomerId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtViewCustomerId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtViewCustomerId.CustomButton.TabIndex = 1;
            this.txtViewCustomerId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtViewCustomerId.CustomButton.UseSelectable = true;
            this.txtViewCustomerId.CustomButton.Visible = false;
            this.txtViewCustomerId.Lines = new string[0];
            this.txtViewCustomerId.Location = new System.Drawing.Point(193, 41);
            this.txtViewCustomerId.MaxLength = 32767;
            this.txtViewCustomerId.Name = "txtViewCustomerId";
            this.txtViewCustomerId.PasswordChar = '\0';
            this.txtViewCustomerId.PromptText = "CUSTOMER ID (AUTO GENERATED)";
            this.txtViewCustomerId.ReadOnly = true;
            this.txtViewCustomerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtViewCustomerId.SelectedText = "";
            this.txtViewCustomerId.SelectionLength = 0;
            this.txtViewCustomerId.SelectionStart = 0;
            this.txtViewCustomerId.ShortcutsEnabled = true;
            this.txtViewCustomerId.Size = new System.Drawing.Size(265, 23);
            this.txtViewCustomerId.TabIndex = 6;
            this.txtViewCustomerId.UseSelectable = true;
            this.txtViewCustomerId.WaterMark = "CUSTOMER ID (AUTO GENERATED)";
            this.txtViewCustomerId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtViewCustomerId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(43, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CUSTOMER ID";
            // 
            // txtViewCustomerEmail
            // 
            // 
            // 
            // 
            this.txtViewCustomerEmail.CustomButton.Image = null;
            this.txtViewCustomerEmail.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtViewCustomerEmail.CustomButton.Name = "";
            this.txtViewCustomerEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtViewCustomerEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtViewCustomerEmail.CustomButton.TabIndex = 1;
            this.txtViewCustomerEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtViewCustomerEmail.CustomButton.UseSelectable = true;
            this.txtViewCustomerEmail.CustomButton.Visible = false;
            this.txtViewCustomerEmail.Lines = new string[0];
            this.txtViewCustomerEmail.Location = new System.Drawing.Point(193, 134);
            this.txtViewCustomerEmail.MaxLength = 32767;
            this.txtViewCustomerEmail.Name = "txtViewCustomerEmail";
            this.txtViewCustomerEmail.PasswordChar = '\0';
            this.txtViewCustomerEmail.PromptText = "ENTER EMAIL (SPECIFIC CUSTOMER)";
            this.txtViewCustomerEmail.ReadOnly = true;
            this.txtViewCustomerEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtViewCustomerEmail.SelectedText = "";
            this.txtViewCustomerEmail.SelectionLength = 0;
            this.txtViewCustomerEmail.SelectionStart = 0;
            this.txtViewCustomerEmail.ShortcutsEnabled = true;
            this.txtViewCustomerEmail.Size = new System.Drawing.Size(265, 23);
            this.txtViewCustomerEmail.TabIndex = 3;
            this.txtViewCustomerEmail.UseSelectable = true;
            this.txtViewCustomerEmail.WaterMark = "ENTER EMAIL (SPECIFIC CUSTOMER)";
            this.txtViewCustomerEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtViewCustomerEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CUSTOMER EMAIL";
            // 
            // txtcustomerviewname
            // 
            // 
            // 
            // 
            this.txtcustomerviewname.CustomButton.Image = null;
            this.txtcustomerviewname.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtcustomerviewname.CustomButton.Name = "";
            this.txtcustomerviewname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcustomerviewname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcustomerviewname.CustomButton.TabIndex = 1;
            this.txtcustomerviewname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcustomerviewname.CustomButton.UseSelectable = true;
            this.txtcustomerviewname.CustomButton.Visible = false;
            this.txtcustomerviewname.Lines = new string[0];
            this.txtcustomerviewname.Location = new System.Drawing.Point(193, 83);
            this.txtcustomerviewname.MaxLength = 32767;
            this.txtcustomerviewname.Name = "txtcustomerviewname";
            this.txtcustomerviewname.PasswordChar = '\0';
            this.txtcustomerviewname.PromptText = "ENTER NAME (OPTIONAL)";
            this.txtcustomerviewname.ReadOnly = true;
            this.txtcustomerviewname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcustomerviewname.SelectedText = "";
            this.txtcustomerviewname.SelectionLength = 0;
            this.txtcustomerviewname.SelectionStart = 0;
            this.txtcustomerviewname.ShortcutsEnabled = true;
            this.txtcustomerviewname.Size = new System.Drawing.Size(265, 23);
            this.txtcustomerviewname.TabIndex = 1;
            this.txtcustomerviewname.UseSelectable = true;
            this.txtcustomerviewname.WaterMark = "ENTER NAME (OPTIONAL)";
            this.txtcustomerviewname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcustomerviewname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblcustomernameview
            // 
            this.lblcustomernameview.AutoSize = true;
            this.lblcustomernameview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomernameview.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblcustomernameview.Location = new System.Drawing.Point(12, 83);
            this.lblcustomernameview.Name = "lblcustomernameview";
            this.lblcustomernameview.Size = new System.Drawing.Size(170, 20);
            this.lblcustomernameview.TabIndex = 0;
            this.lblcustomernameview.Text = "CUSTOMER NAME";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvManageViewCustomer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 612);
            this.panel3.TabIndex = 2;
            // 
            // dgvManageViewCustomer
            // 
            this.dgvManageViewCustomer.AllowUserToAddRows = false;
            this.dgvManageViewCustomer.AllowUserToDeleteRows = false;
            this.dgvManageViewCustomer.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvManageViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvNAME,
            this.dgvEMAIL});
            this.dgvManageViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManageViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvManageViewCustomer.Name = "dgvManageViewCustomer";
            this.dgvManageViewCustomer.ReadOnly = true;
            this.dgvManageViewCustomer.RowTemplate.Height = 24;
            this.dgvManageViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageViewCustomer.Size = new System.Drawing.Size(910, 612);
            this.dgvManageViewCustomer.TabIndex = 0;
            this.dgvManageViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageViewCustomer_CellClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "Id";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvID.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvID.HeaderText = "Ref";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            // 
            // dgvNAME
            // 
            this.dgvNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNAME.DataPropertyName = "Name";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvNAME.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNAME.HeaderText = "CUSTOMER NAME";
            this.dgvNAME.Name = "dgvNAME";
            this.dgvNAME.ReadOnly = true;
            // 
            // dgvEMAIL
            // 
            this.dgvEMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvEMAIL.DataPropertyName = "Email";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvEMAIL.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEMAIL.HeaderText = "CUSTOMER EMAIL";
            this.dgvEMAIL.Name = "dgvEMAIL";
            this.dgvEMAIL.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(919, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 62);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH CUSTOMER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnViewCustomerRefresh);
            this.panel1.Controls.Add(this.btnbackviewcustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnViewCustomerRefresh
            // 
            this.btnViewCustomerRefresh.Location = new System.Drawing.Point(781, 10);
            this.btnViewCustomerRefresh.Name = "btnViewCustomerRefresh";
            this.btnViewCustomerRefresh.Size = new System.Drawing.Size(103, 43);
            this.btnViewCustomerRefresh.TabIndex = 1;
            this.btnViewCustomerRefresh.Text = "REFRESH";
            this.btnViewCustomerRefresh.UseVisualStyleBackColor = true;
            this.btnViewCustomerRefresh.Click += new System.EventHandler(this.btnViewCustomerRefresh_Click);
            // 
            // btnbackviewcustomer
            // 
            this.btnbackviewcustomer.Location = new System.Drawing.Point(13, 12);
            this.btnbackviewcustomer.Name = "btnbackviewcustomer";
            this.btnbackviewcustomer.Size = new System.Drawing.Size(109, 41);
            this.btnbackviewcustomer.TabIndex = 0;
            this.btnbackviewcustomer.Text = "BACK";
            this.btnbackviewcustomer.UseVisualStyleBackColor = true;
            this.btnbackviewcustomer.Click += new System.EventHandler(this.btnbackviewcustomer_Click);
            // 
            // ManageViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 766);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Salmon;
            this.Name = "ManageViewCustomer";
            this.Text = "ManageViewCustomer";
            this.Load += new System.EventHandler(this.ManageViewCustomer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageViewCustomer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvManageViewCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewCustomerRefresh;
        private System.Windows.Forms.Button btnbackviewcustomer;
        private MetroFramework.Controls.MetroTextBox txtViewCustomerId;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtViewCustomerEmail;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtcustomerviewname;
        private System.Windows.Forms.Label lblcustomernameview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalAmountPaid;
        private System.Windows.Forms.TextBox txtTotalOrderPlaced;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEMAIL;
    }
}