namespace InventoryManagementSystem
{
    partial class ManageViewSupplier
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotalAmountWePaid = new System.Windows.Forms.TextBox();
            this.txtTotalProductGave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtViewSupplierId = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtViewSupplierEmail = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtViewSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.lblcustomernameview = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvViewSupplier = new System.Windows.Forms.DataGridView();
            this.dgvSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSupplierEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewSupplierRefresh = new System.Windows.Forms.Button();
            this.btnbackViewSupplier = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSupplier)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.9633F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0367F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1701, 689);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.Controls.Add(this.txtTotalAmountWePaid);
            this.panel4.Controls.Add(this.txtTotalProductGave);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtViewSupplierId);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtViewSupplierEmail);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtViewSupplierName);
            this.panel4.Controls.Add(this.lblcustomernameview);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel4.Location = new System.Drawing.Point(954, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(744, 615);
            this.panel4.TabIndex = 3;
            // 
            // txtTotalAmountWePaid
            // 
            this.txtTotalAmountWePaid.Location = new System.Drawing.Point(272, 256);
            this.txtTotalAmountWePaid.Name = "txtTotalAmountWePaid";
            this.txtTotalAmountWePaid.Size = new System.Drawing.Size(198, 27);
            this.txtTotalAmountWePaid.TabIndex = 10;
            // 
            // txtTotalProductGave
            // 
            this.txtTotalProductGave.Location = new System.Drawing.Point(272, 205);
            this.txtTotalProductGave.Name = "txtTotalProductGave";
            this.txtTotalProductGave.Size = new System.Drawing.Size(198, 27);
            this.txtTotalProductGave.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(12, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "TOTAL AMOUNT WE PAID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(28, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TOTAL PRODUCT GAVE:";
            // 
            // txtViewSupplierId
            // 
            // 
            // 
            // 
            this.txtViewSupplierId.CustomButton.Image = null;
            this.txtViewSupplierId.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtViewSupplierId.CustomButton.Name = "";
            this.txtViewSupplierId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtViewSupplierId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtViewSupplierId.CustomButton.TabIndex = 1;
            this.txtViewSupplierId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtViewSupplierId.CustomButton.UseSelectable = true;
            this.txtViewSupplierId.CustomButton.Visible = false;
            this.txtViewSupplierId.Lines = new string[0];
            this.txtViewSupplierId.Location = new System.Drawing.Point(193, 41);
            this.txtViewSupplierId.MaxLength = 32767;
            this.txtViewSupplierId.Name = "txtViewSupplierId";
            this.txtViewSupplierId.PasswordChar = '\0';
            this.txtViewSupplierId.PromptText = "CUSTOMER ID (AUTO GENERATED)";
            this.txtViewSupplierId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtViewSupplierId.SelectedText = "";
            this.txtViewSupplierId.SelectionLength = 0;
            this.txtViewSupplierId.SelectionStart = 0;
            this.txtViewSupplierId.ShortcutsEnabled = true;
            this.txtViewSupplierId.Size = new System.Drawing.Size(265, 23);
            this.txtViewSupplierId.TabIndex = 6;
            this.txtViewSupplierId.UseSelectable = true;
            this.txtViewSupplierId.WaterMark = "CUSTOMER ID (AUTO GENERATED)";
            this.txtViewSupplierId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtViewSupplierId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(31, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SUPPLIER ID";
            // 
            // txtViewSupplierEmail
            // 
            // 
            // 
            // 
            this.txtViewSupplierEmail.CustomButton.Image = null;
            this.txtViewSupplierEmail.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtViewSupplierEmail.CustomButton.Name = "";
            this.txtViewSupplierEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtViewSupplierEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtViewSupplierEmail.CustomButton.TabIndex = 1;
            this.txtViewSupplierEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtViewSupplierEmail.CustomButton.UseSelectable = true;
            this.txtViewSupplierEmail.CustomButton.Visible = false;
            this.txtViewSupplierEmail.Lines = new string[0];
            this.txtViewSupplierEmail.Location = new System.Drawing.Point(193, 134);
            this.txtViewSupplierEmail.MaxLength = 32767;
            this.txtViewSupplierEmail.Name = "txtViewSupplierEmail";
            this.txtViewSupplierEmail.PasswordChar = '\0';
            this.txtViewSupplierEmail.PromptText = "ENTER EMAIL (SPECIFIC CUSTOMER)";
            this.txtViewSupplierEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtViewSupplierEmail.SelectedText = "";
            this.txtViewSupplierEmail.SelectionLength = 0;
            this.txtViewSupplierEmail.SelectionStart = 0;
            this.txtViewSupplierEmail.ShortcutsEnabled = true;
            this.txtViewSupplierEmail.Size = new System.Drawing.Size(265, 23);
            this.txtViewSupplierEmail.TabIndex = 3;
            this.txtViewSupplierEmail.UseSelectable = true;
            this.txtViewSupplierEmail.WaterMark = "ENTER EMAIL (SPECIFIC CUSTOMER)";
            this.txtViewSupplierEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtViewSupplierEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(3, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "SUPPLIER EMAIL";
            // 
            // txtViewSupplierName
            // 
            // 
            // 
            // 
            this.txtViewSupplierName.CustomButton.Image = null;
            this.txtViewSupplierName.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtViewSupplierName.CustomButton.Name = "";
            this.txtViewSupplierName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtViewSupplierName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtViewSupplierName.CustomButton.TabIndex = 1;
            this.txtViewSupplierName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtViewSupplierName.CustomButton.UseSelectable = true;
            this.txtViewSupplierName.CustomButton.Visible = false;
            this.txtViewSupplierName.Lines = new string[0];
            this.txtViewSupplierName.Location = new System.Drawing.Point(193, 83);
            this.txtViewSupplierName.MaxLength = 32767;
            this.txtViewSupplierName.Name = "txtViewSupplierName";
            this.txtViewSupplierName.PasswordChar = '\0';
            this.txtViewSupplierName.PromptText = "ENTER NAME (OPTIONAL)";
            this.txtViewSupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtViewSupplierName.SelectedText = "";
            this.txtViewSupplierName.SelectionLength = 0;
            this.txtViewSupplierName.SelectionStart = 0;
            this.txtViewSupplierName.ShortcutsEnabled = true;
            this.txtViewSupplierName.Size = new System.Drawing.Size(265, 23);
            this.txtViewSupplierName.TabIndex = 1;
            this.txtViewSupplierName.UseSelectable = true;
            this.txtViewSupplierName.WaterMark = "ENTER NAME (OPTIONAL)";
            this.txtViewSupplierName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtViewSupplierName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblcustomernameview
            // 
            this.lblcustomernameview.AutoSize = true;
            this.lblcustomernameview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomernameview.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblcustomernameview.Location = new System.Drawing.Point(0, 83);
            this.lblcustomernameview.Name = "lblcustomernameview";
            this.lblcustomernameview.Size = new System.Drawing.Size(157, 20);
            this.lblcustomernameview.TabIndex = 0;
            this.lblcustomernameview.Text = "SUPPLIER NAME";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvViewSupplier);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 615);
            this.panel3.TabIndex = 2;
            // 
            // dgvViewSupplier
            // 
            this.dgvViewSupplier.AllowUserToAddRows = false;
            this.dgvViewSupplier.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvViewSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewSupplier.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSupplierId,
            this.dgvSupplierName,
            this.dgvSupplierEmail,
            this.dgvSupplierAddress});
            this.dgvViewSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewSupplier.Location = new System.Drawing.Point(0, 0);
            this.dgvViewSupplier.Name = "dgvViewSupplier";
            this.dgvViewSupplier.ReadOnly = true;
            this.dgvViewSupplier.RowTemplate.Height = 24;
            this.dgvViewSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewSupplier.Size = new System.Drawing.Size(945, 615);
            this.dgvViewSupplier.TabIndex = 0;
            this.dgvViewSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewSupplier_CellClick);
            // 
            // dgvSupplierId
            // 
            this.dgvSupplierId.DataPropertyName = "Id";
            this.dgvSupplierId.HeaderText = "REF";
            this.dgvSupplierId.Name = "dgvSupplierId";
            this.dgvSupplierId.ReadOnly = true;
            // 
            // dgvSupplierName
            // 
            this.dgvSupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSupplierName.DataPropertyName = "UserName";
            this.dgvSupplierName.HeaderText = "SUPPLIER NAME";
            this.dgvSupplierName.Name = "dgvSupplierName";
            this.dgvSupplierName.ReadOnly = true;
            // 
            // dgvSupplierEmail
            // 
            this.dgvSupplierEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSupplierEmail.DataPropertyName = "Email";
            this.dgvSupplierEmail.HeaderText = "EMAIL";
            this.dgvSupplierEmail.Name = "dgvSupplierEmail";
            this.dgvSupplierEmail.ReadOnly = true;
            // 
            // dgvSupplierAddress
            // 
            this.dgvSupplierAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSupplierAddress.DataPropertyName = "Address";
            this.dgvSupplierAddress.HeaderText = "ADDRESS";
            this.dgvSupplierAddress.Name = "dgvSupplierAddress";
            this.dgvSupplierAddress.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(954, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 62);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH SUPPLIER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnViewSupplierRefresh);
            this.panel1.Controls.Add(this.btnbackViewSupplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnViewSupplierRefresh
            // 
            this.btnViewSupplierRefresh.BackColor = System.Drawing.Color.SeaShell;
            this.btnViewSupplierRefresh.Location = new System.Drawing.Point(763, 11);
            this.btnViewSupplierRefresh.Name = "btnViewSupplierRefresh";
            this.btnViewSupplierRefresh.Size = new System.Drawing.Size(126, 44);
            this.btnViewSupplierRefresh.TabIndex = 1;
            this.btnViewSupplierRefresh.Text = "REFRESH";
            this.btnViewSupplierRefresh.UseVisualStyleBackColor = false;
            this.btnViewSupplierRefresh.Click += new System.EventHandler(this.btnViewSupplierRefresh_Click);
            // 
            // btnbackViewSupplier
            // 
            this.btnbackViewSupplier.BackColor = System.Drawing.Color.SeaShell;
            this.btnbackViewSupplier.Location = new System.Drawing.Point(18, 10);
            this.btnbackViewSupplier.Name = "btnbackViewSupplier";
            this.btnbackViewSupplier.Size = new System.Drawing.Size(123, 45);
            this.btnbackViewSupplier.TabIndex = 0;
            this.btnbackViewSupplier.Text = "BACK";
            this.btnbackViewSupplier.UseVisualStyleBackColor = false;
            this.btnbackViewSupplier.Click += new System.EventHandler(this.btnbackViewSupplier_Click);
            // 
            // ManageViewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 769);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Salmon;
            this.Name = "ManageViewSupplier";
            this.Text = "MANAGE VIEW SUPPLIER";
            this.Load += new System.EventHandler(this.ManageViewSupplier_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSupplier)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewSupplierRefresh;
        private System.Windows.Forms.Button btnbackViewSupplier;
        private MetroFramework.Controls.MetroTextBox txtViewSupplierId;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtViewSupplierEmail;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtViewSupplierName;
        private System.Windows.Forms.Label lblcustomernameview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalAmountWePaid;
        private System.Windows.Forms.TextBox txtTotalProductGave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvViewSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSupplierEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSupplierAddress;
    }
}