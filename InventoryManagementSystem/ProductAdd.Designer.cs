﻿namespace InventoryManagementSystem
{
    partial class ProductAdd
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
            this.btnRefreshProductAdd = new System.Windows.Forms.Button();
            this.btnBackAdminPanel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProductAdd = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSellPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtBasePrice = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProductAdd = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAdd)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1252, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnRefreshProductAdd);
            this.panel1.Controls.Add(this.btnBackAdminPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnRefreshProductAdd
            // 
            this.btnRefreshProductAdd.Location = new System.Drawing.Point(397, 3);
            this.btnRefreshProductAdd.Name = "btnRefreshProductAdd";
            this.btnRefreshProductAdd.Size = new System.Drawing.Size(110, 35);
            this.btnRefreshProductAdd.TabIndex = 2;
            this.btnRefreshProductAdd.Text = "REFRESH";
            this.btnRefreshProductAdd.UseVisualStyleBackColor = true;
            this.btnRefreshProductAdd.Click += new System.EventHandler(this.btnRefreshProductAdd_Click);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.86901F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.13099F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 110);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1252, 559);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvProductAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(402, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 553);
            this.panel3.TabIndex = 2;
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
            this.dgvID,
            this.dgvName,
            this.dgvDescription,
            this.dgvBasePrice,
            this.dgvSellPrice});
            this.dgvProductAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductAdd.Location = new System.Drawing.Point(0, 0);
            this.dgvProductAdd.Name = "dgvProductAdd";
            this.dgvProductAdd.ReadOnly = true;
            this.dgvProductAdd.RowTemplate.Height = 24;
            this.dgvProductAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductAdd.Size = new System.Drawing.Size(847, 553);
            this.dgvProductAdd.TabIndex = 0;
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
            this.dgvBasePrice.HeaderText = "BasePrice(IN KG)";
            this.dgvBasePrice.Name = "dgvBasePrice";
            this.dgvBasePrice.ReadOnly = true;
            // 
            // dgvSellPrice
            // 
            this.dgvSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSellPrice.DataPropertyName = "SellPrice";
            this.dgvSellPrice.HeaderText = "SellPrice(IN KG)";
            this.dgvSellPrice.Name = "dgvSellPrice";
            this.dgvSellPrice.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSellPrice);
            this.panel2.Controls.Add(this.txtBasePrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnProductAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtProductDescription);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtProductId);
            this.panel2.Controls.Add(this.lblProductId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 553);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "SELLING PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "BUYING PRICE";
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
            this.txtSellPrice.Location = new System.Drawing.Point(158, 231);
            this.txtSellPrice.MaxLength = 32767;
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.PasswordChar = '\0';
            this.txtSellPrice.PromptText = "ENTER SELLING";
            this.txtSellPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSellPrice.SelectedText = "";
            this.txtSellPrice.SelectionLength = 0;
            this.txtSellPrice.SelectionStart = 0;
            this.txtSellPrice.ShortcutsEnabled = true;
            this.txtSellPrice.Size = new System.Drawing.Size(224, 23);
            this.txtSellPrice.TabIndex = 9;
            this.txtSellPrice.UseSelectable = true;
            this.txtSellPrice.WaterMark = "ENTER SELLING";
            this.txtSellPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSellPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtBasePrice.Location = new System.Drawing.Point(158, 171);
            this.txtBasePrice.MaxLength = 32767;
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.PasswordChar = '\0';
            this.txtBasePrice.PromptText = "ENTER BASE PRICE";
            this.txtBasePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBasePrice.SelectedText = "";
            this.txtBasePrice.SelectionLength = 0;
            this.txtBasePrice.SelectionStart = 0;
            this.txtBasePrice.ShortcutsEnabled = true;
            this.txtBasePrice.Size = new System.Drawing.Size(224, 23);
            this.txtBasePrice.TabIndex = 8;
            this.txtBasePrice.UseSelectable = true;
            this.txtBasePrice.WaterMark = "ENTER BASE PRICE";
            this.txtBasePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBasePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "(IF ANY)";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(244, 495);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(138, 48);
            this.btnProductAdd.TabIndex = 6;
            this.btnProductAdd.Text = "ADD";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "DESCRIPTION";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(6, 328);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(360, 149);
            this.txtProductDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 113);
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
            this.txtProductName.Location = new System.Drawing.Point(158, 113);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PromptText = "ENTER NAME";
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(224, 23);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMark = "ENTER NAME";
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
            this.lblProductId.Location = new System.Drawing.Point(111, 54);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(28, 20);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "ID";
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 689);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductAdd";
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAdd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProductAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroTextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Button btnBackAdminPanel;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnRefreshProductAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSellPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtSellPrice;
        private MetroFramework.Controls.MetroTextBox txtBasePrice;
    }
}