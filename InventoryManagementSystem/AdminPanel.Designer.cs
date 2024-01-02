namespace InventoryManagementSystem
{
    partial class AdminPanel
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtvGridInventory = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCAPACITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMAXCAPACITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLPROFITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUPPLIERINFOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLPRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYNAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTINVENTORYMANAGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUPPLIERPRODUCTSELLREQUESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGECUSTOMERORDERREQUESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvGridInventory)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.72247F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.27753F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1636, 673);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLogOut);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1110, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(523, 600);
            this.panel4.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogOut.Location = new System.Drawing.Point(398, 523);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(99, 41);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(17, 523);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 41);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            this.btnRefresh.MouseHover += new System.EventHandler(this.btnRefresh_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtvGridInventory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1101, 600);
            this.panel3.TabIndex = 2;
            // 
            // dtvGridInventory
            // 
            this.dtvGridInventory.AllowUserToAddRows = false;
            this.dtvGridInventory.AllowUserToDeleteRows = false;
            this.dtvGridInventory.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dtvGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvGridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvCAPACITY,
            this.dgvADDRESS,
            this.dgvDescription,
            this.dgvMAXCAPACITY});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvGridInventory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtvGridInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvGridInventory.Location = new System.Drawing.Point(0, 0);
            this.dtvGridInventory.Name = "dtvGridInventory";
            this.dtvGridInventory.ReadOnly = true;
            this.dtvGridInventory.RowTemplate.Height = 24;
            this.dtvGridInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvGridInventory.Size = new System.Drawing.Size(1101, 600);
            this.dtvGridInventory.TabIndex = 0;
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "Id";
            this.dgvID.HeaderText = "Ref";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            // 
            // dgvCAPACITY
            // 
            this.dgvCAPACITY.DataPropertyName = "Capacity";
            this.dgvCAPACITY.HeaderText = "CAPACITY(IN KG)";
            this.dgvCAPACITY.Name = "dgvCAPACITY";
            this.dgvCAPACITY.ReadOnly = true;
            this.dgvCAPACITY.Width = 150;
            // 
            // dgvADDRESS
            // 
            this.dgvADDRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvADDRESS.DataPropertyName = "Address";
            this.dgvADDRESS.HeaderText = "ADDRESS";
            this.dgvADDRESS.Name = "dgvADDRESS";
            this.dgvADDRESS.ReadOnly = true;
            // 
            // dgvDescription
            // 
            this.dgvDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDescription.DataPropertyName = "Description";
            this.dgvDescription.HeaderText = "DESCRIPTION";
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.ReadOnly = true;
            // 
            // dgvMAXCAPACITY
            // 
            this.dgvMAXCAPACITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMAXCAPACITY.DataPropertyName = "MaxCapacity";
            this.dgvMAXCAPACITY.HeaderText = "MAX CAPACITY(IN KG)";
            this.dgvMAXCAPACITY.Name = "dgvMAXCAPACITY";
            this.dgvMAXCAPACITY.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 61);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.aDDToolStripMenuItem,
            this.mANAGEALLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 61);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLLPROFITToolStripMenuItem,
            this.cUSTOMERINFOToolStripMenuItem,
            this.sUPPLIERINFOToolStripMenuItem1,
            this.aLLPRODUCTToolStripMenuItem});
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(56, 57);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            // 
            // aLLPROFITToolStripMenuItem
            // 
            this.aLLPROFITToolStripMenuItem.Name = "aLLPROFITToolStripMenuItem";
            this.aLLPROFITToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.aLLPROFITToolStripMenuItem.Text = "ALL_PROFIT";
            this.aLLPROFITToolStripMenuItem.Click += new System.EventHandler(this.aLLPROFITToolStripMenuItem_Click);
            // 
            // cUSTOMERINFOToolStripMenuItem
            // 
            this.cUSTOMERINFOToolStripMenuItem.Name = "cUSTOMERINFOToolStripMenuItem";
            this.cUSTOMERINFOToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.cUSTOMERINFOToolStripMenuItem.Text = "CUSTOMER_INFO";
            this.cUSTOMERINFOToolStripMenuItem.Click += new System.EventHandler(this.cUSTOMERINFOToolStripMenuItem_Click);
            // 
            // sUPPLIERINFOToolStripMenuItem1
            // 
            this.sUPPLIERINFOToolStripMenuItem1.Name = "sUPPLIERINFOToolStripMenuItem1";
            this.sUPPLIERINFOToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.sUPPLIERINFOToolStripMenuItem1.Text = "SUPPLIER_INFO";
            this.sUPPLIERINFOToolStripMenuItem1.Click += new System.EventHandler(this.sUPPLIERINFOToolStripMenuItem1_Click);
            // 
            // aLLPRODUCTToolStripMenuItem
            // 
            this.aLLPRODUCTToolStripMenuItem.Name = "aLLPRODUCTToolStripMenuItem";
            this.aLLPRODUCTToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.aLLPRODUCTToolStripMenuItem.Text = "ALL_PRODUCT";
            this.aLLPRODUCTToolStripMenuItem.Click += new System.EventHandler(this.aLLPRODUCTToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNVENTORYNAMEToolStripMenuItem,
            this.pRODUCTINFOToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(52, 57);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // iNVENTORYNAMEToolStripMenuItem
            // 
            this.iNVENTORYNAMEToolStripMenuItem.Name = "iNVENTORYNAMEToolStripMenuItem";
            this.iNVENTORYNAMEToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.iNVENTORYNAMEToolStripMenuItem.Text = "INVENTORY_UPDATE";
            this.iNVENTORYNAMEToolStripMenuItem.Click += new System.EventHandler(this.iNVENTORYNAMEToolStripMenuItem_Click);
            // 
            // pRODUCTINFOToolStripMenuItem
            // 
            this.pRODUCTINFOToolStripMenuItem.Name = "pRODUCTINFOToolStripMenuItem";
            this.pRODUCTINFOToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.pRODUCTINFOToolStripMenuItem.Text = "PRODUCT_INFO_UPDATE";
            this.pRODUCTINFOToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTINFOToolStripMenuItem_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNVENTORYToolStripMenuItem,
            this.pRODUCTToolStripMenuItem,
            this.pRODUCTINVENTORYMANAGEToolStripMenuItem});
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(53, 57);
            this.aDDToolStripMenuItem.Text = "ADD";
            // 
            // iNVENTORYToolStripMenuItem
            // 
            this.iNVENTORYToolStripMenuItem.Name = "iNVENTORYToolStripMenuItem";
            this.iNVENTORYToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.iNVENTORYToolStripMenuItem.Text = "INVENTORY";
            this.iNVENTORYToolStripMenuItem.Click += new System.EventHandler(this.iNVENTORYToolStripMenuItem_Click);
            // 
            // pRODUCTToolStripMenuItem
            // 
            this.pRODUCTToolStripMenuItem.Name = "pRODUCTToolStripMenuItem";
            this.pRODUCTToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.pRODUCTToolStripMenuItem.Text = "PRODUCT";
            this.pRODUCTToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTToolStripMenuItem_Click);
            // 
            // pRODUCTINVENTORYMANAGEToolStripMenuItem
            // 
            this.pRODUCTINVENTORYMANAGEToolStripMenuItem.Name = "pRODUCTINVENTORYMANAGEToolStripMenuItem";
            this.pRODUCTINVENTORYMANAGEToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.pRODUCTINVENTORYMANAGEToolStripMenuItem.Text = "PRODUCT_INVENTORY_MANAGE";
            this.pRODUCTINVENTORYMANAGEToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTINVENTORYMANAGEToolStripMenuItem_Click);
            // 
            // mANAGEALLToolStripMenuItem
            // 
            this.mANAGEALLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sUPPLIERPRODUCTSELLREQUESTToolStripMenuItem,
            this.mANAGECUSTOMERORDERREQUESTToolStripMenuItem});
            this.mANAGEALLToolStripMenuItem.Name = "mANAGEALLToolStripMenuItem";
            this.mANAGEALLToolStripMenuItem.Size = new System.Drawing.Size(113, 57);
            this.mANAGEALLToolStripMenuItem.Text = "MANAGE_ALL";
            // 
            // sUPPLIERPRODUCTSELLREQUESTToolStripMenuItem
            // 
            this.sUPPLIERPRODUCTSELLREQUESTToolStripMenuItem.Name = "sUPPLIERPRODUCTSELLREQUESTToolStripMenuItem";
            this.sUPPLIERPRODUCTSELLREQUESTToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.sUPPLIERPRODUCTSELLREQUESTToolStripMenuItem.Text = "SUPPLIER_PRODUCT_SELL_REQUEST";
            this.sUPPLIERPRODUCTSELLREQUESTToolStripMenuItem.Click += new System.EventHandler(this.sUPPLIERPRODUCTSELLREQUESTToolStripMenuItem_Click);
            // 
            // mANAGECUSTOMERORDERREQUESTToolStripMenuItem
            // 
            this.mANAGECUSTOMERORDERREQUESTToolStripMenuItem.Name = "mANAGECUSTOMERORDERREQUESTToolStripMenuItem";
            this.mANAGECUSTOMERORDERREQUESTToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.mANAGECUSTOMERORDERREQUESTToolStripMenuItem.Text = "MANAGE_CUSTOMER_ORDER_REQUEST";
            this.mANAGECUSTOMERORDERREQUESTToolStripMenuItem.Click += new System.EventHandler(this.mANAGECUSTOMERORDERREQUESTToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1110, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 61);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(165, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME ADMIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox2.Image = global::InventoryManagementSystem.Properties.Resources.menu_burger;
            this.pictureBox2.Location = new System.Drawing.Point(1004, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources.shield;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvGridInventory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLPROFITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERINFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtvGridInventory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem iNVENTORYNAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTINFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUPPLIERINFOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aLLPRODUCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTINVENTORYMANAGEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGEALLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUPPLIERPRODUCTSELLREQUESTToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCAPACITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMAXCAPACITY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem mANAGECUSTOMERORDERREQUESTToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}