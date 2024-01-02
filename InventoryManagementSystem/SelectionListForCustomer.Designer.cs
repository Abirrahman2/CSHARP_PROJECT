namespace InventoryManagementSystem
{
    partial class SelectionListForCustomer
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
            this.dgvSelectionList = new System.Windows.Forms.DataGridView();
            this.dgvSelectionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductIdS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductNameS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductPriceS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.cmbSelectProductForCustomer = new System.Windows.Forms.ComboBox();
            this.btnOrderSelection = new System.Windows.Forms.Button();
            this.btnCalculateTotalPrice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPriceSelection = new MetroFramework.Controls.MetroTextBox();
            this.txtProductQuantitySelection = new MetroFramework.Controls.MetroTextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshSelection = new System.Windows.Forms.Button();
            this.btnProductSelectionDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackS = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectionList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 643);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvSelectionList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(248, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 573);
            this.panel4.TabIndex = 3;
            // 
            // dgvSelectionList
            // 
            this.dgvSelectionList.AllowUserToAddRows = false;
            this.dgvSelectionList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvSelectionList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectionList.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvSelectionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSelectionId,
            this.dgvProductIdS,
            this.dgvProductNameS,
            this.dgvProductPriceS});
            this.dgvSelectionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectionList.Location = new System.Drawing.Point(0, 0);
            this.dgvSelectionList.Name = "dgvSelectionList";
            this.dgvSelectionList.ReadOnly = true;
            this.dgvSelectionList.RowTemplate.Height = 24;
            this.dgvSelectionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectionList.Size = new System.Drawing.Size(566, 573);
            this.dgvSelectionList.TabIndex = 0;
            this.dgvSelectionList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectionList_CellClick);
            // 
            // dgvSelectionId
            // 
            this.dgvSelectionId.DataPropertyName = "ID NO";
            this.dgvSelectionId.HeaderText = "SI";
            this.dgvSelectionId.Name = "dgvSelectionId";
            this.dgvSelectionId.ReadOnly = true;
            // 
            // dgvProductIdS
            // 
            this.dgvProductIdS.DataPropertyName = "PRODUCT NO";
            this.dgvProductIdS.HeaderText = "PRODUCT ID";
            this.dgvProductIdS.Name = "dgvProductIdS";
            this.dgvProductIdS.ReadOnly = true;
            // 
            // dgvProductNameS
            // 
            this.dgvProductNameS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductNameS.DataPropertyName = "PRODUCT NAME";
            this.dgvProductNameS.HeaderText = "PRODUCT NAME";
            this.dgvProductNameS.Name = "dgvProductNameS";
            this.dgvProductNameS.ReadOnly = true;
            // 
            // dgvProductPriceS
            // 
            this.dgvProductPriceS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductPriceS.DataPropertyName = "PRODUCT SELL";
            this.dgvProductPriceS.HeaderText = "PRODUCT PRICE";
            this.dgvProductPriceS.Name = "dgvProductPriceS";
            this.dgvProductPriceS.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Linen;
            this.panel3.Controls.Add(this.dtpicker);
            this.panel3.Controls.Add(this.cmbSelectProductForCustomer);
            this.panel3.Controls.Add(this.btnOrderSelection);
            this.panel3.Controls.Add(this.btnCalculateTotalPrice);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTotalPriceSelection);
            this.panel3.Controls.Add(this.txtProductQuantitySelection);
            this.panel3.Controls.Add(this.lblquantity);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 573);
            this.panel3.TabIndex = 2;
            // 
            // dtpicker
            // 
            this.dtpicker.Enabled = false;
            this.dtpicker.Location = new System.Drawing.Point(3, 137);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(214, 22);
            this.dtpicker.TabIndex = 18;
            // 
            // cmbSelectProductForCustomer
            // 
            this.cmbSelectProductForCustomer.FormattingEnabled = true;
            this.cmbSelectProductForCustomer.Location = new System.Drawing.Point(3, 53);
            this.cmbSelectProductForCustomer.Name = "cmbSelectProductForCustomer";
            this.cmbSelectProductForCustomer.Size = new System.Drawing.Size(224, 24);
            this.cmbSelectProductForCustomer.TabIndex = 8;
            // 
            // btnOrderSelection
            // 
            this.btnOrderSelection.Location = new System.Drawing.Point(56, 336);
            this.btnOrderSelection.Name = "btnOrderSelection";
            this.btnOrderSelection.Size = new System.Drawing.Size(100, 31);
            this.btnOrderSelection.TabIndex = 7;
            this.btnOrderSelection.Text = "ORDER";
            this.btnOrderSelection.UseVisualStyleBackColor = true;
            this.btnOrderSelection.Click += new System.EventHandler(this.btnOrderSelection_Click);
            // 
            // btnCalculateTotalPrice
            // 
            this.btnCalculateTotalPrice.Location = new System.Drawing.Point(13, 304);
            this.btnCalculateTotalPrice.Name = "btnCalculateTotalPrice";
            this.btnCalculateTotalPrice.Size = new System.Drawing.Size(116, 26);
            this.btnCalculateTotalPrice.TabIndex = 6;
            this.btnCalculateTotalPrice.Text = "CALCULATE";
            this.btnCalculateTotalPrice.UseVisualStyleBackColor = true;
            this.btnCalculateTotalPrice.Click += new System.EventHandler(this.btnCalculateTotalPrice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOTAL PRICE";
            // 
            // txtTotalPriceSelection
            // 
            // 
            // 
            // 
            this.txtTotalPriceSelection.CustomButton.Image = null;
            this.txtTotalPriceSelection.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtTotalPriceSelection.CustomButton.Name = "";
            this.txtTotalPriceSelection.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalPriceSelection.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPriceSelection.CustomButton.TabIndex = 1;
            this.txtTotalPriceSelection.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPriceSelection.CustomButton.UseSelectable = true;
            this.txtTotalPriceSelection.CustomButton.Visible = false;
            this.txtTotalPriceSelection.Lines = new string[0];
            this.txtTotalPriceSelection.Location = new System.Drawing.Point(13, 275);
            this.txtTotalPriceSelection.MaxLength = 32767;
            this.txtTotalPriceSelection.Name = "txtTotalPriceSelection";
            this.txtTotalPriceSelection.PasswordChar = '\0';
            this.txtTotalPriceSelection.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPriceSelection.SelectedText = "";
            this.txtTotalPriceSelection.SelectionLength = 0;
            this.txtTotalPriceSelection.SelectionStart = 0;
            this.txtTotalPriceSelection.ShortcutsEnabled = true;
            this.txtTotalPriceSelection.Size = new System.Drawing.Size(183, 23);
            this.txtTotalPriceSelection.TabIndex = 4;
            this.txtTotalPriceSelection.UseSelectable = true;
            this.txtTotalPriceSelection.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPriceSelection.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductQuantitySelection
            // 
            // 
            // 
            // 
            this.txtProductQuantitySelection.CustomButton.Image = null;
            this.txtProductQuantitySelection.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtProductQuantitySelection.CustomButton.Name = "";
            this.txtProductQuantitySelection.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductQuantitySelection.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductQuantitySelection.CustomButton.TabIndex = 1;
            this.txtProductQuantitySelection.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductQuantitySelection.CustomButton.UseSelectable = true;
            this.txtProductQuantitySelection.CustomButton.Visible = false;
            this.txtProductQuantitySelection.Lines = new string[0];
            this.txtProductQuantitySelection.Location = new System.Drawing.Point(13, 205);
            this.txtProductQuantitySelection.MaxLength = 32767;
            this.txtProductQuantitySelection.Name = "txtProductQuantitySelection";
            this.txtProductQuantitySelection.PasswordChar = '\0';
            this.txtProductQuantitySelection.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductQuantitySelection.SelectedText = "";
            this.txtProductQuantitySelection.SelectionLength = 0;
            this.txtProductQuantitySelection.SelectionStart = 0;
            this.txtProductQuantitySelection.ShortcutsEnabled = true;
            this.txtProductQuantitySelection.Size = new System.Drawing.Size(183, 23);
            this.txtProductQuantitySelection.TabIndex = 3;
            this.txtProductQuantitySelection.UseSelectable = true;
            this.txtProductQuantitySelection.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductQuantitySelection.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Location = new System.Drawing.Point(10, 174);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(78, 17);
            this.lblquantity.TabIndex = 2;
            this.lblquantity.Text = "QUANTITY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT NAME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.btnRefreshSelection);
            this.panel2.Controls.Add(this.btnProductSelectionDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(248, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 58);
            this.panel2.TabIndex = 1;
            // 
            // btnRefreshSelection
            // 
            this.btnRefreshSelection.Location = new System.Drawing.Point(443, 8);
            this.btnRefreshSelection.Name = "btnRefreshSelection";
            this.btnRefreshSelection.Size = new System.Drawing.Size(105, 42);
            this.btnRefreshSelection.TabIndex = 8;
            this.btnRefreshSelection.Text = "REFRESH";
            this.btnRefreshSelection.UseVisualStyleBackColor = true;
            this.btnRefreshSelection.Click += new System.EventHandler(this.btnRefreshSelection_Click);
            // 
            // btnProductSelectionDelete
            // 
            this.btnProductSelectionDelete.Location = new System.Drawing.Point(3, 3);
            this.btnProductSelectionDelete.Name = "btnProductSelectionDelete";
            this.btnProductSelectionDelete.Size = new System.Drawing.Size(225, 52);
            this.btnProductSelectionDelete.TabIndex = 8;
            this.btnProductSelectionDelete.Text = "DELETE SELECTION LIST";
            this.btnProductSelectionDelete.UseVisualStyleBackColor = true;
            this.btnProductSelectionDelete.Click += new System.EventHandler(this.btnProductSelectionDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnBackS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 58);
            this.panel1.TabIndex = 0;
            // 
            // btnBackS
            // 
            this.btnBackS.Location = new System.Drawing.Point(13, 14);
            this.btnBackS.Name = "btnBackS";
            this.btnBackS.Size = new System.Drawing.Size(100, 31);
            this.btnBackS.TabIndex = 0;
            this.btnBackS.Text = "BACK";
            this.btnBackS.UseVisualStyleBackColor = true;
            this.btnBackS.Click += new System.EventHandler(this.btnBackS_Click);
            // 
            // SelectionListForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 723);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "SelectionListForCustomer";
            this.Text = "MY PRODUCT SELECTION LIST";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.SelectionListForCustomer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectionList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackS;
        private System.Windows.Forms.DataGridView dgvSelectionList;
        private System.Windows.Forms.Button btnOrderSelection;
        private System.Windows.Forms.Button btnCalculateTotalPrice;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtTotalPriceSelection;
        private MetroFramework.Controls.MetroTextBox txtProductQuantitySelection;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshSelection;
        private System.Windows.Forms.Button btnProductSelectionDelete;
        private System.Windows.Forms.ComboBox cmbSelectProductForCustomer;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSelectionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductIdS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductNameS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductPriceS;
    }
}