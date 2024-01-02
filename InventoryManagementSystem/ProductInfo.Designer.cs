namespace InventoryManagementSystem
{
    partial class ProductInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProductRefresh = new System.Windows.Forms.Button();
            this.btnBackAdminPanel = new System.Windows.Forms.Button();
            this.btnNewProductView = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProductView = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSellPrice = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBasePrice = new MetroFramework.Controls.MetroTextBox();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.txtProductId = new MetroFramework.Controls.MetroTextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1098, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnProductRefresh);
            this.panel1.Controls.Add(this.btnBackAdminPanel);
            this.panel1.Controls.Add(this.btnNewProductView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.Location = new System.Drawing.Point(789, 6);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(110, 35);
            this.btnProductRefresh.TabIndex = 2;
            this.btnProductRefresh.Text = "REFRESH";
            this.btnProductRefresh.UseVisualStyleBackColor = true;
            this.btnProductRefresh.Click += new System.EventHandler(this.btnProductRefresh_Click);
            // 
            // btnBackAdminPanel
            // 
            this.btnBackAdminPanel.Location = new System.Drawing.Point(3, 3);
            this.btnBackAdminPanel.Name = "btnBackAdminPanel";
            this.btnBackAdminPanel.Size = new System.Drawing.Size(85, 41);
            this.btnBackAdminPanel.TabIndex = 1;
            this.btnBackAdminPanel.Text = "BACK";
            this.btnBackAdminPanel.UseVisualStyleBackColor = true;
            this.btnBackAdminPanel.Click += new System.EventHandler(this.btnBackAdminPanel_Click);
            // 
            // btnNewProductView
            // 
            this.btnNewProductView.Location = new System.Drawing.Point(391, 6);
            this.btnNewProductView.Name = "btnNewProductView";
            this.btnNewProductView.Size = new System.Drawing.Size(75, 38);
            this.btnNewProductView.TabIndex = 0;
            this.btnNewProductView.Text = "NEW";
            this.btnNewProductView.UseVisualStyleBackColor = true;
            this.btnNewProductView.Click += new System.EventHandler(this.btnNewProductView_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.03276F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.96724F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 110);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1098, 610);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvProductView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(398, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 604);
            this.panel3.TabIndex = 2;
            // 
            // dgvProductView
            // 
            this.dgvProductView.AllowUserToAddRows = false;
            this.dgvProductView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvProductView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvDescription,
            this.dgvBasePrice,
            this.dgvSellPrice});
            this.dgvProductView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductView.Location = new System.Drawing.Point(0, 0);
            this.dgvProductView.Name = "dgvProductView";
            this.dgvProductView.ReadOnly = true;
            this.dgvProductView.RowTemplate.Height = 24;
            this.dgvProductView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductView.Size = new System.Drawing.Size(697, 604);
            this.dgvProductView.TabIndex = 1;
            this.dgvProductView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductView_CellClick_1);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "Id";
            this.dgvID.HeaderText = "Ref";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.DataPropertyName = "Name";
            this.dgvName.HeaderText = "PRODUCT_NAME";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvDescription
            // 
            this.dgvDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDescription.DataPropertyName = "Description";
            this.dgvDescription.HeaderText = "DESCRIPTION";
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.ReadOnly = true;
            // 
            // dgvBasePrice
            // 
            this.dgvBasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBasePrice.DataPropertyName = "BasePrice";
            this.dgvBasePrice.HeaderText = "BASE_PRICE(PER KG)";
            this.dgvBasePrice.Name = "dgvBasePrice";
            this.dgvBasePrice.ReadOnly = true;
            // 
            // dgvSellPrice
            // 
            this.dgvSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSellPrice.DataPropertyName = "SellPrice";
            this.dgvSellPrice.HeaderText = "SELL_PRICE(PER KG)";
            this.dgvSellPrice.Name = "dgvSellPrice";
            this.dgvSellPrice.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSellPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBasePrice);
            this.panel2.Controls.Add(this.btnProductSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtProductDescription);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtProductId);
            this.panel2.Controls.Add(this.lblProductId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 604);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "SELLING PRICE";
            // 
            // txtSellPrice
            // 
            // 
            // 
            // 
            this.txtSellPrice.CustomButton.Image = null;
            this.txtSellPrice.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtSellPrice.CustomButton.Name = "";
            this.txtSellPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSellPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSellPrice.CustomButton.TabIndex = 1;
            this.txtSellPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSellPrice.CustomButton.UseSelectable = true;
            this.txtSellPrice.CustomButton.Visible = false;
            this.txtSellPrice.Lines = new string[0];
            this.txtSellPrice.Location = new System.Drawing.Point(158, 223);
            this.txtSellPrice.MaxLength = 32767;
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.PasswordChar = '\0';
            this.txtSellPrice.PromptText = "SELL PRICE";
            this.txtSellPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSellPrice.SelectedText = "";
            this.txtSellPrice.SelectionLength = 0;
            this.txtSellPrice.SelectionStart = 0;
            this.txtSellPrice.ShortcutsEnabled = true;
            this.txtSellPrice.Size = new System.Drawing.Size(224, 23);
            this.txtSellPrice.TabIndex = 12;
            this.txtSellPrice.UseSelectable = true;
            this.txtSellPrice.WaterMark = "SELL PRICE";
            this.txtSellPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSellPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "BUYING PRICE";
            // 
            // txtBasePrice
            // 
            // 
            // 
            // 
            this.txtBasePrice.CustomButton.Image = null;
            this.txtBasePrice.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtBasePrice.CustomButton.Name = "";
            this.txtBasePrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBasePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBasePrice.CustomButton.TabIndex = 1;
            this.txtBasePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBasePrice.CustomButton.UseSelectable = true;
            this.txtBasePrice.CustomButton.Visible = false;
            this.txtBasePrice.Lines = new string[0];
            this.txtBasePrice.Location = new System.Drawing.Point(158, 154);
            this.txtBasePrice.MaxLength = 32767;
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.PasswordChar = '\0';
            this.txtBasePrice.PromptText = "BASE PRICE";
            this.txtBasePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBasePrice.SelectedText = "";
            this.txtBasePrice.SelectionLength = 0;
            this.txtBasePrice.SelectionStart = 0;
            this.txtBasePrice.ShortcutsEnabled = true;
            this.txtBasePrice.Size = new System.Drawing.Size(224, 23);
            this.txtBasePrice.TabIndex = 9;
            this.txtBasePrice.UseSelectable = true;
            this.txtBasePrice.WaterMark = "BASE PRICE";
            this.txtBasePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBasePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(148, 301);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(138, 48);
            this.btnProductSearch.TabIndex = 6;
            this.btnProductSearch.Text = "SEARCH";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "DESCRIPTION";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(12, 389);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(360, 149);
            this.txtProductDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRODUCT NAME";
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(158, 94);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PromptText = "PRODUCT NAME";
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(224, 23);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMark = "PRODUCT NAME";
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductId
            // 
            // 
            // 
            // 
            this.txtProductId.CustomButton.Image = null;
            this.txtProductId.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtProductId.CustomButton.Name = "";
            this.txtProductId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductId.CustomButton.TabIndex = 1;
            this.txtProductId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductId.CustomButton.UseSelectable = true;
            this.txtProductId.CustomButton.Visible = false;
            this.txtProductId.Lines = new string[0];
            this.txtProductId.Location = new System.Drawing.Point(158, 54);
            this.txtProductId.MaxLength = 32767;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.PasswordChar = '\0';
            this.txtProductId.PromptText = "AUTO GENERATED";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductId.SelectedText = "";
            this.txtProductId.SelectionLength = 0;
            this.txtProductId.SelectionStart = 0;
            this.txtProductId.ShortcutsEnabled = true;
            this.txtProductId.Size = new System.Drawing.Size(224, 23);
            this.txtProductId.TabIndex = 1;
            this.txtProductId.UseSelectable = true;
            this.txtProductId.WaterMark = "AUTO GENERATED";
            this.txtProductId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(103, 54);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(28, 20);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "ID";
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 740);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "ProductInfo";
            this.Text = "ProductInfo";
            this.Load += new System.EventHandler(this.ProductInfo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroTextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Button btnBackAdminPanel;
        private System.Windows.Forms.Button btnNewProductView;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Button btnProductRefresh;
        private System.Windows.Forms.DataGridView dgvProductView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSellPrice;
        private MetroFramework.Controls.MetroTextBox txtBasePrice;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtSellPrice;
        private System.Windows.Forms.Label label4;
    }
}