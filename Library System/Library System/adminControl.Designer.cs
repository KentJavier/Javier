namespace Library_System
{
    partial class adminControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.gpAddAdmin = new System.Windows.Forms.GroupBox();
            this.lblAdminFName = new System.Windows.Forms.Label();
            this.txtAdminFName = new System.Windows.Forms.TextBox();
            this.txtAdminLName = new System.Windows.Forms.TextBox();
            this.lblAdminLName = new System.Windows.Forms.Label();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.lblAdminRegistrationDate = new System.Windows.Forms.Label();
            this.dtpAdminRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnResetText = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.gpAddAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(17, 304);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(642, 271);
            this.dgvAdmin.TabIndex = 1;
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.BackColor = System.Drawing.Color.White;
            this.btnDeleteAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDeleteAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAdmin.Location = new System.Drawing.Point(501, 88);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(100, 33);
            this.btnDeleteAdmin.TabIndex = 37;
            this.btnDeleteAdmin.Text = "Delete";
            this.btnDeleteAdmin.UseVisualStyleBackColor = false;
            // 
            // gpAddAdmin
            // 
            this.gpAddAdmin.Controls.Add(this.btnResetText);
            this.gpAddAdmin.Controls.Add(this.btnAddAdmin);
            this.gpAddAdmin.Controls.Add(this.lblAdminRegistrationDate);
            this.gpAddAdmin.Controls.Add(this.dtpAdminRegistrationDate);
            this.gpAddAdmin.Controls.Add(this.txtAdminPassword);
            this.gpAddAdmin.Controls.Add(this.lblAdminPassword);
            this.gpAddAdmin.Controls.Add(this.txtAdminUsername);
            this.gpAddAdmin.Controls.Add(this.lblAdminUsername);
            this.gpAddAdmin.Controls.Add(this.txtAdminEmail);
            this.gpAddAdmin.Controls.Add(this.lblAdminEmail);
            this.gpAddAdmin.Controls.Add(this.txtAdminLName);
            this.gpAddAdmin.Controls.Add(this.lblAdminLName);
            this.gpAddAdmin.Controls.Add(this.txtAdminFName);
            this.gpAddAdmin.Controls.Add(this.lblAdminFName);
            this.gpAddAdmin.Controls.Add(this.btnDeleteAdmin);
            this.gpAddAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.gpAddAdmin.ForeColor = System.Drawing.Color.White;
            this.gpAddAdmin.Location = new System.Drawing.Point(17, 12);
            this.gpAddAdmin.Name = "gpAddAdmin";
            this.gpAddAdmin.Size = new System.Drawing.Size(642, 225);
            this.gpAddAdmin.TabIndex = 40;
            this.gpAddAdmin.TabStop = false;
            this.gpAddAdmin.Text = "ADMIN ACCOUNTS";
            // 
            // lblAdminFName
            // 
            this.lblAdminFName.AutoSize = true;
            this.lblAdminFName.Location = new System.Drawing.Point(9, 29);
            this.lblAdminFName.Name = "lblAdminFName";
            this.lblAdminFName.Size = new System.Drawing.Size(155, 21);
            this.lblAdminFName.TabIndex = 38;
            this.lblAdminFName.Text = "Admin First name";
            // 
            // txtAdminFName
            // 
            this.txtAdminFName.Location = new System.Drawing.Point(29, 53);
            this.txtAdminFName.Name = "txtAdminFName";
            this.txtAdminFName.Size = new System.Drawing.Size(205, 33);
            this.txtAdminFName.TabIndex = 39;
            // 
            // txtAdminLName
            // 
            this.txtAdminLName.Location = new System.Drawing.Point(29, 116);
            this.txtAdminLName.Name = "txtAdminLName";
            this.txtAdminLName.Size = new System.Drawing.Size(205, 33);
            this.txtAdminLName.TabIndex = 41;
            // 
            // lblAdminLName
            // 
            this.lblAdminLName.AutoSize = true;
            this.lblAdminLName.Location = new System.Drawing.Point(9, 92);
            this.lblAdminLName.Name = "lblAdminLName";
            this.lblAdminLName.Size = new System.Drawing.Size(153, 21);
            this.lblAdminLName.TabIndex = 40;
            this.lblAdminLName.Text = "Admin Last name";
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Location = new System.Drawing.Point(29, 183);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(205, 33);
            this.txtAdminEmail.TabIndex = 43;
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.Location = new System.Drawing.Point(9, 159);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(114, 21);
            this.lblAdminEmail.TabIndex = 42;
            this.lblAdminEmail.Text = "Admin Email";
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Location = new System.Drawing.Point(272, 53);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(205, 33);
            this.txtAdminUsername.TabIndex = 45;
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Location = new System.Drawing.Point(252, 29);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(152, 21);
            this.lblAdminUsername.TabIndex = 44;
            this.lblAdminUsername.Text = "Admin Username";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(272, 116);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(205, 33);
            this.txtAdminPassword.TabIndex = 47;
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Location = new System.Drawing.Point(252, 92);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(146, 21);
            this.lblAdminPassword.TabIndex = 46;
            this.lblAdminPassword.Text = "Admin Password";
            // 
            // lblAdminRegistrationDate
            // 
            this.lblAdminRegistrationDate.AutoSize = true;
            this.lblAdminRegistrationDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblAdminRegistrationDate.ForeColor = System.Drawing.Color.White;
            this.lblAdminRegistrationDate.Location = new System.Drawing.Point(251, 159);
            this.lblAdminRegistrationDate.Name = "lblAdminRegistrationDate";
            this.lblAdminRegistrationDate.Size = new System.Drawing.Size(213, 21);
            this.lblAdminRegistrationDate.TabIndex = 49;
            this.lblAdminRegistrationDate.Text = "Admin Registration Date";
            // 
            // dtpAdminRegistrationDate
            // 
            this.dtpAdminRegistrationDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtpAdminRegistrationDate.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dtpAdminRegistrationDate.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpAdminRegistrationDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.dtpAdminRegistrationDate.Location = new System.Drawing.Point(272, 183);
            this.dtpAdminRegistrationDate.Name = "dtpAdminRegistrationDate";
            this.dtpAdminRegistrationDate.Size = new System.Drawing.Size(329, 33);
            this.dtpAdminRegistrationDate.TabIndex = 48;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.White;
            this.btnAddAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnAddAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddAdmin.Location = new System.Drawing.Point(501, 49);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(100, 33);
            this.btnAddAdmin.TabIndex = 50;
            this.btnAddAdmin.Text = "Add";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            // 
            // btnResetText
            // 
            this.btnResetText.BackColor = System.Drawing.Color.White;
            this.btnResetText.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnResetText.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnResetText.Location = new System.Drawing.Point(501, 127);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(100, 33);
            this.btnResetText.TabIndex = 51;
            this.btnResetText.Text = "Reset";
            this.btnResetText.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.textBox1.Location = new System.Drawing.Point(46, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 33);
            this.textBox1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Search Staff";
            // 
            // adminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpAddAdmin);
            this.Controls.Add(this.dgvAdmin);
            this.Name = "adminControl";
            this.Size = new System.Drawing.Size(676, 590);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.gpAddAdmin.ResumeLayout(false);
            this.gpAddAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.GroupBox gpAddAdmin;
        private System.Windows.Forms.TextBox txtAdminFName;
        private System.Windows.Forms.Label lblAdminFName;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.Label lblAdminEmail;
        private System.Windows.Forms.TextBox txtAdminLName;
        private System.Windows.Forms.Label lblAdminLName;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Label lblAdminRegistrationDate;
        private System.Windows.Forms.DateTimePicker dtpAdminRegistrationDate;
        private System.Windows.Forms.Button btnResetText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
