namespace InventoryManagementSystem
{
    partial class CustomerOrderHistory
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvOrderHistoryForCustomer = new System.Windows.Forms.DataGridView();
            this.dgvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPriceForOrderHistory = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantityForOrderHistory = new MetroFramework.Controls.MetroTextBox();
            this.txtProductNameForOrderHistory = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefreshHistory = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistoryForCustomer)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 596);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvOrderHistoryForCustomer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(261, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 531);
            this.panel4.TabIndex = 3;
            // 
            // dgvOrderHistoryForCustomer
            // 
            this.dgvOrderHistoryForCustomer.AllowUserToAddRows = false;
            this.dgvOrderHistoryForCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvOrderHistoryForCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderHistoryForCustomer.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderHistoryForCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderHistoryForCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderHistoryForCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductName,
            this.dgvQuantity,
            this.dgvTotalPrice,
            this.dgvDate});
            this.dgvOrderHistoryForCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderHistoryForCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderHistoryForCustomer.Name = "dgvOrderHistoryForCustomer";
            this.dgvOrderHistoryForCustomer.ReadOnly = true;
            this.dgvOrderHistoryForCustomer.RowTemplate.Height = 24;
            this.dgvOrderHistoryForCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderHistoryForCustomer.Size = new System.Drawing.Size(597, 531);
            this.dgvOrderHistoryForCustomer.TabIndex = 0;
            this.dgvOrderHistoryForCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderHistoryForCustomer_CellClick);
            // 
            // dgvProductName
            // 
            this.dgvProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductName.DataPropertyName = "PRODUCT NAME";
            this.dgvProductName.HeaderText = "PRODUCT NAME";
            this.dgvProductName.Name = "dgvProductName";
            this.dgvProductName.ReadOnly = true;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvQuantity.DataPropertyName = "TotalQuantity";
            this.dgvQuantity.HeaderText = "TOTAL QUANTITY";
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.ReadOnly = true;
            // 
            // dgvTotalPrice
            // 
            this.dgvTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTotalPrice.DataPropertyName = "TotalPrice";
            this.dgvTotalPrice.HeaderText = "TOTAL PRICE";
            this.dgvTotalPrice.Name = "dgvTotalPrice";
            this.dgvTotalPrice.ReadOnly = true;
            // 
            // dgvDate
            // 
            this.dgvDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDate.DataPropertyName = "Date";
            this.dgvDate.HeaderText = "ORDER DATE";
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.txtPriceForOrderHistory);
            this.panel3.Controls.Add(this.txtQuantityForOrderHistory);
            this.panel3.Controls.Add(this.txtProductNameForOrderHistory);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 531);
            this.panel3.TabIndex = 2;
            // 
            // txtPriceForOrderHistory
            // 
            // 
            // 
            // 
            this.txtPriceForOrderHistory.CustomButton.Image = null;
            this.txtPriceForOrderHistory.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtPriceForOrderHistory.CustomButton.Name = "";
            this.txtPriceForOrderHistory.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtPriceForOrderHistory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPriceForOrderHistory.CustomButton.TabIndex = 1;
            this.txtPriceForOrderHistory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPriceForOrderHistory.CustomButton.UseSelectable = true;
            this.txtPriceForOrderHistory.CustomButton.Visible = false;
            this.txtPriceForOrderHistory.Lines = new string[0];
            this.txtPriceForOrderHistory.Location = new System.Drawing.Point(16, 274);
            this.txtPriceForOrderHistory.MaxLength = 32767;
            this.txtPriceForOrderHistory.Name = "txtPriceForOrderHistory";
            this.txtPriceForOrderHistory.PasswordChar = '\0';
            this.txtPriceForOrderHistory.PromptText = "TOTAL PRICE(IN TK)";
            this.txtPriceForOrderHistory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPriceForOrderHistory.SelectedText = "";
            this.txtPriceForOrderHistory.SelectionLength = 0;
            this.txtPriceForOrderHistory.SelectionStart = 0;
            this.txtPriceForOrderHistory.ShortcutsEnabled = true;
            this.txtPriceForOrderHistory.Size = new System.Drawing.Size(228, 35);
            this.txtPriceForOrderHistory.TabIndex = 5;
            this.txtPriceForOrderHistory.UseSelectable = true;
            this.txtPriceForOrderHistory.WaterMark = "TOTAL PRICE(IN TK)";
            this.txtPriceForOrderHistory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPriceForOrderHistory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQuantityForOrderHistory
            // 
            // 
            // 
            // 
            this.txtQuantityForOrderHistory.CustomButton.Image = null;
            this.txtQuantityForOrderHistory.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtQuantityForOrderHistory.CustomButton.Name = "";
            this.txtQuantityForOrderHistory.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtQuantityForOrderHistory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantityForOrderHistory.CustomButton.TabIndex = 1;
            this.txtQuantityForOrderHistory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantityForOrderHistory.CustomButton.UseSelectable = true;
            this.txtQuantityForOrderHistory.CustomButton.Visible = false;
            this.txtQuantityForOrderHistory.Lines = new string[0];
            this.txtQuantityForOrderHistory.Location = new System.Drawing.Point(13, 157);
            this.txtQuantityForOrderHistory.MaxLength = 32767;
            this.txtQuantityForOrderHistory.Name = "txtQuantityForOrderHistory";
            this.txtQuantityForOrderHistory.PasswordChar = '\0';
            this.txtQuantityForOrderHistory.PromptText = "TOTAL QUANTITY(IN KG)";
            this.txtQuantityForOrderHistory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantityForOrderHistory.SelectedText = "";
            this.txtQuantityForOrderHistory.SelectionLength = 0;
            this.txtQuantityForOrderHistory.SelectionStart = 0;
            this.txtQuantityForOrderHistory.ShortcutsEnabled = true;
            this.txtQuantityForOrderHistory.Size = new System.Drawing.Size(228, 35);
            this.txtQuantityForOrderHistory.TabIndex = 4;
            this.txtQuantityForOrderHistory.UseSelectable = true;
            this.txtQuantityForOrderHistory.WaterMark = "TOTAL QUANTITY(IN KG)";
            this.txtQuantityForOrderHistory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantityForOrderHistory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductNameForOrderHistory
            // 
            // 
            // 
            // 
            this.txtProductNameForOrderHistory.CustomButton.Image = null;
            this.txtProductNameForOrderHistory.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtProductNameForOrderHistory.CustomButton.Name = "";
            this.txtProductNameForOrderHistory.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtProductNameForOrderHistory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductNameForOrderHistory.CustomButton.TabIndex = 1;
            this.txtProductNameForOrderHistory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductNameForOrderHistory.CustomButton.UseSelectable = true;
            this.txtProductNameForOrderHistory.CustomButton.Visible = false;
            this.txtProductNameForOrderHistory.Lines = new string[0];
            this.txtProductNameForOrderHistory.Location = new System.Drawing.Point(13, 60);
            this.txtProductNameForOrderHistory.MaxLength = 32767;
            this.txtProductNameForOrderHistory.Name = "txtProductNameForOrderHistory";
            this.txtProductNameForOrderHistory.PasswordChar = '\0';
            this.txtProductNameForOrderHistory.PromptText = "PRODUCT NAME";
            this.txtProductNameForOrderHistory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductNameForOrderHistory.SelectedText = "";
            this.txtProductNameForOrderHistory.SelectionLength = 0;
            this.txtProductNameForOrderHistory.SelectionStart = 0;
            this.txtProductNameForOrderHistory.ShortcutsEnabled = true;
            this.txtProductNameForOrderHistory.Size = new System.Drawing.Size(228, 35);
            this.txtProductNameForOrderHistory.TabIndex = 3;
            this.txtProductNameForOrderHistory.UseSelectable = true;
            this.txtProductNameForOrderHistory.WaterMark = "PRODUCT NAME";
            this.txtProductNameForOrderHistory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductNameForOrderHistory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL PRICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOTAL QUANTITY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT NAME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(261, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 53);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "MY ORDER HISTORY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnRefreshHistory);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnRefreshHistory
            // 
            this.btnRefreshHistory.Location = new System.Drawing.Point(151, 9);
            this.btnRefreshHistory.Name = "btnRefreshHistory";
            this.btnRefreshHistory.Size = new System.Drawing.Size(93, 37);
            this.btnRefreshHistory.TabIndex = 1;
            this.btnRefreshHistory.Text = "REFRESH";
            this.btnRefreshHistory.UseVisualStyleBackColor = true;
            this.btnRefreshHistory.Click += new System.EventHandler(this.btnRefreshHistory_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 37);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources.document;
            this.pictureBox1.Location = new System.Drawing.Point(146, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 676);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "CustomerOrderHistory";
            this.Load += new System.EventHandler(this.CustomerOrderHistory_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistoryForCustomer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvOrderHistoryForCustomer;
        private MetroFramework.Controls.MetroTextBox txtPriceForOrderHistory;
        private MetroFramework.Controls.MetroTextBox txtQuantityForOrderHistory;
        private MetroFramework.Controls.MetroTextBox txtProductNameForOrderHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefreshHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}