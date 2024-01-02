namespace InventoryManagementSystem
{
    partial class CustomerPersonalInfo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefrestUpdate = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkPass = new System.Windows.Forms.CheckBox();
            this.txtChangeContact = new MetroFramework.Controls.MetroTextBox();
            this.txtChangePassword = new MetroFramework.Controls.MetroTextBox();
            this.txtChangeName = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.txtMyPassword = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMyContact = new System.Windows.Forms.TextBox();
            this.txtMyEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 611);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnRefrestUpdate);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnBackHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnRefrestUpdate
            // 
            this.btnRefrestUpdate.Location = new System.Drawing.Point(433, 3);
            this.btnRefrestUpdate.Name = "btnRefrestUpdate";
            this.btnRefrestUpdate.Size = new System.Drawing.Size(123, 41);
            this.btnRefrestUpdate.TabIndex = 15;
            this.btnRefrestUpdate.Text = "REFRESH";
            this.btnRefrestUpdate.UseVisualStyleBackColor = true;
            this.btnRefrestUpdate.Click += new System.EventHandler(this.btnRefrestUpdate_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(919, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(99, 41);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "EXIT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBackHome
            // 
            this.btnBackHome.Location = new System.Drawing.Point(3, 3);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(99, 41);
            this.btnBackHome.TabIndex = 0;
            this.btnBackHome.Text = "BACK";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtChangeContact);
            this.panel2.Controls.Add(this.txtChangePassword);
            this.panel2.Controls.Add(this.txtChangeName);
            this.panel2.Controls.Add(this.btnUpdateCustomer);
            this.panel2.Controls.Add(this.txtMyPassword);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMyContact);
            this.panel2.Controls.Add(this.txtMyEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMyName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 544);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkPass);
            this.panel3.Location = new System.Drawing.Point(246, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 51);
            this.panel3.TabIndex = 14;
            // 
            // chkPass
            // 
            this.chkPass.AutoSize = true;
            this.chkPass.Location = new System.Drawing.Point(21, 21);
            this.chkPass.Name = "chkPass";
            this.chkPass.Size = new System.Drawing.Size(157, 21);
            this.chkPass.TabIndex = 8;
            this.chkPass.Text = "SHOW PASSWORD";
            this.chkPass.UseVisualStyleBackColor = true;
            this.chkPass.CheckedChanged += new System.EventHandler(this.chkPass_CheckedChanged);
            // 
            // txtChangeContact
            // 
            // 
            // 
            // 
            this.txtChangeContact.CustomButton.Image = null;
            this.txtChangeContact.CustomButton.Location = new System.Drawing.Point(326, 1);
            this.txtChangeContact.CustomButton.Name = "";
            this.txtChangeContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChangeContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChangeContact.CustomButton.TabIndex = 1;
            this.txtChangeContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChangeContact.CustomButton.UseSelectable = true;
            this.txtChangeContact.CustomButton.Visible = false;
            this.txtChangeContact.Lines = new string[0];
            this.txtChangeContact.Location = new System.Drawing.Point(616, 268);
            this.txtChangeContact.MaxLength = 32767;
            this.txtChangeContact.Name = "txtChangeContact";
            this.txtChangeContact.PasswordChar = '\0';
            this.txtChangeContact.PromptText = "CHANGE CONTACT INFO";
            this.txtChangeContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChangeContact.SelectedText = "";
            this.txtChangeContact.SelectionLength = 0;
            this.txtChangeContact.SelectionStart = 0;
            this.txtChangeContact.ShortcutsEnabled = true;
            this.txtChangeContact.Size = new System.Drawing.Size(348, 23);
            this.txtChangeContact.TabIndex = 12;
            this.txtChangeContact.UseSelectable = true;
            this.txtChangeContact.WaterMark = "CHANGE CONTACT INFO";
            this.txtChangeContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChangeContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtChangePassword
            // 
            // 
            // 
            // 
            this.txtChangePassword.CustomButton.Image = null;
            this.txtChangePassword.CustomButton.Location = new System.Drawing.Point(326, 1);
            this.txtChangePassword.CustomButton.Name = "";
            this.txtChangePassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChangePassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChangePassword.CustomButton.TabIndex = 1;
            this.txtChangePassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChangePassword.CustomButton.UseSelectable = true;
            this.txtChangePassword.CustomButton.Visible = false;
            this.txtChangePassword.Lines = new string[0];
            this.txtChangePassword.Location = new System.Drawing.Point(616, 350);
            this.txtChangePassword.MaxLength = 32767;
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.PasswordChar = '\0';
            this.txtChangePassword.PromptText = "CHANGE PASSWORD";
            this.txtChangePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChangePassword.SelectedText = "";
            this.txtChangePassword.SelectionLength = 0;
            this.txtChangePassword.SelectionStart = 0;
            this.txtChangePassword.ShortcutsEnabled = true;
            this.txtChangePassword.Size = new System.Drawing.Size(348, 23);
            this.txtChangePassword.TabIndex = 11;
            this.txtChangePassword.UseSelectable = true;
            this.txtChangePassword.WaterMark = "CHANGE PASSWORD";
            this.txtChangePassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChangePassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtChangeName
            // 
            // 
            // 
            // 
            this.txtChangeName.CustomButton.Image = null;
            this.txtChangeName.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.txtChangeName.CustomButton.Name = "";
            this.txtChangeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChangeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChangeName.CustomButton.TabIndex = 1;
            this.txtChangeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChangeName.CustomButton.UseSelectable = true;
            this.txtChangeName.CustomButton.Visible = false;
            this.txtChangeName.Lines = new string[0];
            this.txtChangeName.Location = new System.Drawing.Point(616, 58);
            this.txtChangeName.MaxLength = 32767;
            this.txtChangeName.Name = "txtChangeName";
            this.txtChangeName.PasswordChar = '\0';
            this.txtChangeName.PromptText = "CHANGE NAME IF YOU WANT";
            this.txtChangeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChangeName.SelectedText = "";
            this.txtChangeName.SelectionLength = 0;
            this.txtChangeName.SelectionStart = 0;
            this.txtChangeName.ShortcutsEnabled = true;
            this.txtChangeName.Size = new System.Drawing.Size(327, 23);
            this.txtChangeName.TabIndex = 10;
            this.txtChangeName.UseSelectable = true;
            this.txtChangeName.WaterMark = "CHANGE NAME IF YOU WANT";
            this.txtChangeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChangeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(687, 379);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(173, 60);
            this.btnUpdateCustomer.TabIndex = 9;
            this.btnUpdateCustomer.Text = "UPDATE INFO";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // txtMyPassword
            // 
            // 
            // 
            // 
            this.txtMyPassword.CustomButton.Image = null;
            this.txtMyPassword.CustomButton.Location = new System.Drawing.Point(316, 1);
            this.txtMyPassword.CustomButton.Name = "";
            this.txtMyPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMyPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMyPassword.CustomButton.TabIndex = 1;
            this.txtMyPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMyPassword.CustomButton.UseSelectable = true;
            this.txtMyPassword.CustomButton.Visible = false;
            this.txtMyPassword.Lines = new string[0];
            this.txtMyPassword.Location = new System.Drawing.Point(205, 348);
            this.txtMyPassword.MaxLength = 32767;
            this.txtMyPassword.Name = "txtMyPassword";
            this.txtMyPassword.PasswordChar = '\0';
            this.txtMyPassword.PromptText = "MY PASSWORD";
            this.txtMyPassword.ReadOnly = true;
            this.txtMyPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMyPassword.SelectedText = "";
            this.txtMyPassword.SelectionLength = 0;
            this.txtMyPassword.SelectionStart = 0;
            this.txtMyPassword.ShortcutsEnabled = true;
            this.txtMyPassword.Size = new System.Drawing.Size(338, 23);
            this.txtMyPassword.TabIndex = 7;
            this.txtMyPassword.UseSelectable = true;
            this.txtMyPassword.WaterMark = "MY PASSWORD";
            this.txtMyPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMyPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "MY CONTACT";
            // 
            // txtMyContact
            // 
            this.txtMyContact.Location = new System.Drawing.Point(205, 261);
            this.txtMyContact.Multiline = true;
            this.txtMyContact.Name = "txtMyContact";
            this.txtMyContact.ReadOnly = true;
            this.txtMyContact.Size = new System.Drawing.Size(338, 30);
            this.txtMyContact.TabIndex = 4;
            // 
            // txtMyEmail
            // 
            this.txtMyEmail.Location = new System.Drawing.Point(205, 158);
            this.txtMyEmail.Multiline = true;
            this.txtMyEmail.Name = "txtMyEmail";
            this.txtMyEmail.ReadOnly = true;
            this.txtMyEmail.Size = new System.Drawing.Size(338, 30);
            this.txtMyEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MY EMAIL";
            // 
            // txtMyName
            // 
            this.txtMyName.Location = new System.Drawing.Point(205, 53);
            this.txtMyName.Multiline = true;
            this.txtMyName.Name = "txtMyName";
            this.txtMyName.ReadOnly = true;
            this.txtMyName.Size = new System.Drawing.Size(338, 30);
            this.txtMyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY NAME";
            // 
            // CustomerPersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 691);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "CustomerPersonalInfo";
            this.Text = "MY PERSONAL INFORMATION";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.CustomerPersonalInfo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txtMyPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMyContact;
        private System.Windows.Forms.TextBox txtMyEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPass;
        private System.Windows.Forms.Button btnRefrestUpdate;
        private MetroFramework.Controls.MetroTextBox txtChangeContact;
        private MetroFramework.Controls.MetroTextBox txtChangePassword;
        private MetroFramework.Controls.MetroTextBox txtChangeName;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Panel panel3;
    }
}