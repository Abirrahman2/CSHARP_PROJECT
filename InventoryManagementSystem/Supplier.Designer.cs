namespace InventoryManagementSystem
{
    partial class Supplier
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
            this.dgvProductForSupplier = new System.Windows.Forms.DataGridView();
            this.dgvProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductNameForSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductPriceForSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oRDERBOXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDERREQUESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWREQUESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONALINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.txtTotalMoneyGet = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSellRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductQuantityForSupplier = new MetroFramework.Controls.MetroTextBox();
            this.cmbSelectProductForSupplier = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductForSupplier)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 639);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvProductForSupplier);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(371, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 570);
            this.panel4.TabIndex = 3;
            // 
            // dgvProductForSupplier
            // 
            this.dgvProductForSupplier.AllowUserToAddRows = false;
            this.dgvProductForSupplier.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvProductForSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductForSupplier.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvProductForSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductForSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductId,
            this.dgvProductNameForSupplier,
            this.dgvProductPriceForSupplier});
            this.dgvProductForSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductForSupplier.Location = new System.Drawing.Point(0, 0);
            this.dgvProductForSupplier.Name = "dgvProductForSupplier";
            this.dgvProductForSupplier.ReadOnly = true;
            this.dgvProductForSupplier.RowTemplate.Height = 24;
            this.dgvProductForSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductForSupplier.Size = new System.Drawing.Size(546, 570);
            this.dgvProductForSupplier.TabIndex = 0;
            this.dgvProductForSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductForSupplier_CellClick);
            // 
            // dgvProductId
            // 
            this.dgvProductId.DataPropertyName = "Id";
            this.dgvProductId.HeaderText = "SI";
            this.dgvProductId.Name = "dgvProductId";
            this.dgvProductId.ReadOnly = true;
            // 
            // dgvProductNameForSupplier
            // 
            this.dgvProductNameForSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductNameForSupplier.DataPropertyName = "Name";
            this.dgvProductNameForSupplier.HeaderText = "PRODUCT NAME";
            this.dgvProductNameForSupplier.Name = "dgvProductNameForSupplier";
            this.dgvProductNameForSupplier.ReadOnly = true;
            // 
            // dgvProductPriceForSupplier
            // 
            this.dgvProductPriceForSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductPriceForSupplier.DataPropertyName = "BasePrice";
            this.dgvProductPriceForSupplier.HeaderText = "SELLING PRICE";
            this.dgvProductPriceForSupplier.Name = "dgvProductPriceForSupplier";
            this.dgvProductPriceForSupplier.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(371, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 57);
            this.panel3.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(410, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 51);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 51);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 57);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oRDERBOXToolStripMenuItem,
            this.eDITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 57);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oRDERBOXToolStripMenuItem
            // 
            this.oRDERBOXToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oRDERREQUESTToolStripMenuItem,
            this.vIEWREQUESTToolStripMenuItem});
            this.oRDERBOXToolStripMenuItem.Name = "oRDERBOXToolStripMenuItem";
            this.oRDERBOXToolStripMenuItem.Size = new System.Drawing.Size(104, 53);
            this.oRDERBOXToolStripMenuItem.Text = "ORDER_BOX";
            // 
            // oRDERREQUESTToolStripMenuItem
            // 
            this.oRDERREQUESTToolStripMenuItem.Name = "oRDERREQUESTToolStripMenuItem";
            this.oRDERREQUESTToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.oRDERREQUESTToolStripMenuItem.Text = "ORDER_REQUEST";
            // 
            // vIEWREQUESTToolStripMenuItem
            // 
            this.vIEWREQUESTToolStripMenuItem.Name = "vIEWREQUESTToolStripMenuItem";
            this.vIEWREQUESTToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.vIEWREQUESTToolStripMenuItem.Text = "VIEW_REQUEST_SENT";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERSONALINFOToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(52, 53);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // pERSONALINFOToolStripMenuItem
            // 
            this.pERSONALINFOToolStripMenuItem.Name = "pERSONALINFOToolStripMenuItem";
            this.pERSONALINFOToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.pERSONALINFOToolStripMenuItem.Text = "PERSONAL_INFO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnCalculateCost);
            this.panel1.Controls.Add(this.txtTotalMoneyGet);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSellRequest);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProductQuantityForSupplier);
            this.panel1.Controls.Add(this.cmbSelectProductForSupplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 570);
            this.panel1.TabIndex = 0;
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.Location = new System.Drawing.Point(86, 265);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(140, 38);
            this.btnCalculateCost.TabIndex = 18;
            this.btnCalculateCost.Text = "CALCULATE";
            this.btnCalculateCost.UseVisualStyleBackColor = true;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // txtTotalMoneyGet
            // 
            // 
            // 
            // 
            this.txtTotalMoneyGet.CustomButton.Image = null;
            this.txtTotalMoneyGet.CustomButton.Location = new System.Drawing.Point(287, 1);
            this.txtTotalMoneyGet.CustomButton.Name = "";
            this.txtTotalMoneyGet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalMoneyGet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalMoneyGet.CustomButton.TabIndex = 1;
            this.txtTotalMoneyGet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalMoneyGet.CustomButton.UseSelectable = true;
            this.txtTotalMoneyGet.CustomButton.Visible = false;
            this.txtTotalMoneyGet.Lines = new string[0];
            this.txtTotalMoneyGet.Location = new System.Drawing.Point(18, 236);
            this.txtTotalMoneyGet.MaxLength = 32767;
            this.txtTotalMoneyGet.Name = "txtTotalMoneyGet";
            this.txtTotalMoneyGet.PasswordChar = '\0';
            this.txtTotalMoneyGet.PromptText = "AUTO GENERATED";
            this.txtTotalMoneyGet.ReadOnly = true;
            this.txtTotalMoneyGet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalMoneyGet.SelectedText = "";
            this.txtTotalMoneyGet.SelectionLength = 0;
            this.txtTotalMoneyGet.SelectionStart = 0;
            this.txtTotalMoneyGet.ShortcutsEnabled = true;
            this.txtTotalMoneyGet.Size = new System.Drawing.Size(309, 23);
            this.txtTotalMoneyGet.TabIndex = 17;
            this.txtTotalMoneyGet.UseSelectable = true;
            this.txtTotalMoneyGet.WaterMark = "AUTO GENERATED";
            this.txtTotalMoneyGet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalMoneyGet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "TOTAL  MONEY YOU CAN GET";
            // 
            // btnSellRequest
            // 
            this.btnSellRequest.Location = new System.Drawing.Point(76, 355);
            this.btnSellRequest.Name = "btnSellRequest";
            this.btnSellRequest.Size = new System.Drawing.Size(171, 62);
            this.btnSellRequest.TabIndex = 15;
            this.btnSellRequest.Text = "SELL REQUEST";
            this.btnSellRequest.UseVisualStyleBackColor = true;
            this.btnSellRequest.Click += new System.EventHandler(this.btnSellRequest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "SELECT QUANTITY FOR SELL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "CHOOSE PRODUCT";
            // 
            // txtProductQuantityForSupplier
            // 
            // 
            // 
            // 
            this.txtProductQuantityForSupplier.CustomButton.Image = null;
            this.txtProductQuantityForSupplier.CustomButton.Location = new System.Drawing.Point(287, 1);
            this.txtProductQuantityForSupplier.CustomButton.Name = "";
            this.txtProductQuantityForSupplier.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductQuantityForSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductQuantityForSupplier.CustomButton.TabIndex = 1;
            this.txtProductQuantityForSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductQuantityForSupplier.CustomButton.UseSelectable = true;
            this.txtProductQuantityForSupplier.CustomButton.Visible = false;
            this.txtProductQuantityForSupplier.Lines = new string[0];
            this.txtProductQuantityForSupplier.Location = new System.Drawing.Point(15, 144);
            this.txtProductQuantityForSupplier.MaxLength = 32767;
            this.txtProductQuantityForSupplier.Name = "txtProductQuantityForSupplier";
            this.txtProductQuantityForSupplier.PasswordChar = '\0';
            this.txtProductQuantityForSupplier.PromptText = "ENTER QUANTITY(AT LEAST 100 KG)";
            this.txtProductQuantityForSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductQuantityForSupplier.SelectedText = "";
            this.txtProductQuantityForSupplier.SelectionLength = 0;
            this.txtProductQuantityForSupplier.SelectionStart = 0;
            this.txtProductQuantityForSupplier.ShortcutsEnabled = true;
            this.txtProductQuantityForSupplier.Size = new System.Drawing.Size(309, 23);
            this.txtProductQuantityForSupplier.TabIndex = 12;
            this.txtProductQuantityForSupplier.UseSelectable = true;
            this.txtProductQuantityForSupplier.WaterMark = "ENTER QUANTITY(AT LEAST 100 KG)";
            this.txtProductQuantityForSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductQuantityForSupplier.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbSelectProductForSupplier
            // 
            this.cmbSelectProductForSupplier.FormattingEnabled = true;
            this.cmbSelectProductForSupplier.Location = new System.Drawing.Point(15, 59);
            this.cmbSelectProductForSupplier.Name = "cmbSelectProductForSupplier";
            this.cmbSelectProductForSupplier.Size = new System.Drawing.Size(309, 24);
            this.cmbSelectProductForSupplier.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(15, 518);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(114, 49);
            this.btnLogOut.TabIndex = 19;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 719);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Supplier";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductForSupplier)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvProductForSupplier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oRDERBOXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDERREQUESTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONALINFOToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbSelectProductForSupplier;
        private MetroFramework.Controls.MetroTextBox txtProductQuantityForSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductNameForSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductPriceForSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSellRequest;
        private MetroFramework.Controls.MetroTextBox txtTotalMoneyGet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculateCost;
        private System.Windows.Forms.ToolStripMenuItem vIEWREQUESTToolStripMenuItem;
        private System.Windows.Forms.Button btnLogOut;
    }
}