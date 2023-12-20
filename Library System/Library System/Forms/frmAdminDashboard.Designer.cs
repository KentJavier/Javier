namespace Library_System
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.gpAdminAcc = new System.Windows.Forms.GroupBox();
            this.btnResetText = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.txtAdminFirstName = new System.Windows.Forms.TextBox();
            this.lblAdminRegistrationDate = new System.Windows.Forms.Label();
            this.lblAdminFirstName = new System.Windows.Forms.Label();
            this.dtpAdminRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.txtAdminLastName = new System.Windows.Forms.TextBox();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.lblAdminLastName = new System.Windows.Forms.Label();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.gpAdminAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.dgvAdmin);
            this.panel1.Controls.Add(this.gpAdminAcc);
            this.panel1.Location = new System.Drawing.Point(186, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 518);
            this.panel1.TabIndex = 27;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(17, 245);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(744, 260);
            this.dgvAdmin.TabIndex = 45;
            // 
            // gpAdminAcc
            // 
            this.gpAdminAcc.Controls.Add(this.btnResetText);
            this.gpAdminAcc.Controls.Add(this.btnDeleteAdmin);
            this.gpAdminAcc.Controls.Add(this.btnUpdateAdmin);
            this.gpAdminAcc.Controls.Add(this.btnCreateAdmin);
            this.gpAdminAcc.Controls.Add(this.txtAdminFirstName);
            this.gpAdminAcc.Controls.Add(this.lblAdminRegistrationDate);
            this.gpAdminAcc.Controls.Add(this.lblAdminFirstName);
            this.gpAdminAcc.Controls.Add(this.dtpAdminRegistrationDate);
            this.gpAdminAcc.Controls.Add(this.lblAdminPassword);
            this.gpAdminAcc.Controls.Add(this.txtAdminLastName);
            this.gpAdminAcc.Controls.Add(this.txtAdminPassword);
            this.gpAdminAcc.Controls.Add(this.lblAdminLastName);
            this.gpAdminAcc.Controls.Add(this.lblAdminUsername);
            this.gpAdminAcc.Controls.Add(this.txtAdminEmail);
            this.gpAdminAcc.Controls.Add(this.txtAdminUsername);
            this.gpAdminAcc.Controls.Add(this.lblAdminEmail);
            this.gpAdminAcc.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.gpAdminAcc.ForeColor = System.Drawing.Color.White;
            this.gpAdminAcc.Location = new System.Drawing.Point(17, 11);
            this.gpAdminAcc.Name = "gpAdminAcc";
            this.gpAdminAcc.Size = new System.Drawing.Size(744, 228);
            this.gpAdminAcc.TabIndex = 44;
            this.gpAdminAcc.TabStop = false;
            this.gpAdminAcc.Text = "Admin Account";
            // 
            // btnResetText
            // 
            this.btnResetText.BackColor = System.Drawing.Color.White;
            this.btnResetText.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnResetText.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnResetText.Location = new System.Drawing.Point(646, 173);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(75, 37);
            this.btnResetText.TabIndex = 47;
            this.btnResetText.Text = "Reset";
            this.btnResetText.UseVisualStyleBackColor = false;
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.BackColor = System.Drawing.Color.White;
            this.btnDeleteAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDeleteAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAdmin.Location = new System.Drawing.Point(565, 173);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(75, 37);
            this.btnDeleteAdmin.TabIndex = 46;
            this.btnDeleteAdmin.Text = "Delete";
            this.btnDeleteAdmin.UseVisualStyleBackColor = false;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.BackColor = System.Drawing.Color.White;
            this.btnUpdateAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnUpdateAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateAdmin.Location = new System.Drawing.Point(484, 173);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateAdmin.TabIndex = 45;
            this.btnUpdateAdmin.Text = "Update";
            this.btnUpdateAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.BackColor = System.Drawing.Color.White;
            this.btnCreateAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnCreateAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCreateAdmin.Location = new System.Drawing.Point(404, 173);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(75, 37);
            this.btnCreateAdmin.TabIndex = 44;
            this.btnCreateAdmin.Text = "Create";
            this.btnCreateAdmin.UseVisualStyleBackColor = false;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // txtAdminFirstName
            // 
            this.txtAdminFirstName.BackColor = System.Drawing.Color.White;
            this.txtAdminFirstName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtAdminFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtAdminFirstName.Location = new System.Drawing.Point(122, 76);
            this.txtAdminFirstName.Name = "txtAdminFirstName";
            this.txtAdminFirstName.Size = new System.Drawing.Size(230, 33);
            this.txtAdminFirstName.TabIndex = 29;
            // 
            // lblAdminRegistrationDate
            // 
            this.lblAdminRegistrationDate.AutoSize = true;
            this.lblAdminRegistrationDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblAdminRegistrationDate.ForeColor = System.Drawing.Color.White;
            this.lblAdminRegistrationDate.Location = new System.Drawing.Point(17, 34);
            this.lblAdminRegistrationDate.Name = "lblAdminRegistrationDate";
            this.lblAdminRegistrationDate.Size = new System.Drawing.Size(154, 21);
            this.lblAdminRegistrationDate.TabIndex = 36;
            this.lblAdminRegistrationDate.Text = "Registration Date";
            // 
            // lblAdminFirstName
            // 
            this.lblAdminFirstName.AutoSize = true;
            this.lblAdminFirstName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblAdminFirstName.ForeColor = System.Drawing.Color.White;
            this.lblAdminFirstName.Location = new System.Drawing.Point(17, 79);
            this.lblAdminFirstName.Name = "lblAdminFirstName";
            this.lblAdminFirstName.Size = new System.Drawing.Size(99, 21);
            this.lblAdminFirstName.TabIndex = 37;
            this.lblAdminFirstName.Text = "First Name";
            // 
            // dtpAdminRegistrationDate
            // 
            this.dtpAdminRegistrationDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtpAdminRegistrationDate.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dtpAdminRegistrationDate.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpAdminRegistrationDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.dtpAdminRegistrationDate.Location = new System.Drawing.Point(204, 26);
            this.dtpAdminRegistrationDate.Name = "dtpAdminRegistrationDate";
            this.dtpAdminRegistrationDate.Size = new System.Drawing.Size(329, 33);
            this.dtpAdminRegistrationDate.TabIndex = 34;
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblAdminPassword.ForeColor = System.Drawing.Color.White;
            this.lblAdminPassword.Location = new System.Drawing.Point(388, 130);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(87, 21);
            this.lblAdminPassword.TabIndex = 42;
            this.lblAdminPassword.Text = "Password";
            // 
            // txtAdminLastName
            // 
            this.txtAdminLastName.BackColor = System.Drawing.Color.White;
            this.txtAdminLastName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtAdminLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtAdminLastName.Location = new System.Drawing.Point(122, 127);
            this.txtAdminLastName.Name = "txtAdminLastName";
            this.txtAdminLastName.Size = new System.Drawing.Size(230, 33);
            this.txtAdminLastName.TabIndex = 30;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.BackColor = System.Drawing.Color.White;
            this.txtAdminPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtAdminPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtAdminPassword.Location = new System.Drawing.Point(490, 127);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(231, 33);
            this.txtAdminPassword.TabIndex = 33;
            // 
            // lblAdminLastName
            // 
            this.lblAdminLastName.AutoSize = true;
            this.lblAdminLastName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblAdminLastName.ForeColor = System.Drawing.Color.White;
            this.lblAdminLastName.Location = new System.Drawing.Point(19, 130);
            this.lblAdminLastName.Name = "lblAdminLastName";
            this.lblAdminLastName.Size = new System.Drawing.Size(97, 21);
            this.lblAdminLastName.TabIndex = 41;
            this.lblAdminLastName.Text = "Last Name";
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblAdminUsername.ForeColor = System.Drawing.Color.White;
            this.lblAdminUsername.Location = new System.Drawing.Point(386, 82);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(93, 21);
            this.lblAdminUsername.TabIndex = 39;
            this.lblAdminUsername.Text = "Username";
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.BackColor = System.Drawing.Color.White;
            this.txtAdminEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtAdminEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtAdminEmail.Location = new System.Drawing.Point(122, 176);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(230, 33);
            this.txtAdminEmail.TabIndex = 31;
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.BackColor = System.Drawing.Color.White;
            this.txtAdminUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtAdminUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtAdminUsername.Location = new System.Drawing.Point(491, 79);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(230, 33);
            this.txtAdminUsername.TabIndex = 32;
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblAdminEmail.ForeColor = System.Drawing.Color.White;
            this.lblAdminEmail.Location = new System.Drawing.Point(19, 179);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(55, 21);
            this.lblAdminEmail.TabIndex = 40;
            this.lblAdminEmail.Text = "Email";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.lblUsername.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUsername.Location = new System.Drawing.Point(11, 215);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 23);
            this.lblUsername.TabIndex = 26;
            this.lblUsername.Text = "Username";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblWelcome.Location = new System.Drawing.Point(7, 164);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(169, 40);
            this.lblWelcome.TabIndex = 25;
            this.lblWelcome.Text = "Welcome!";
            // 
            // pbProfile
            // 
            this.pbProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbProfile.Image")));
            this.pbProfile.Location = new System.Drawing.Point(15, 21);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(151, 140);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 20;
            this.pbProfile.TabStop = false;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.White;
            this.btnTransaction.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnTransaction.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTransaction.Location = new System.Drawing.Point(30, 414);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(119, 41);
            this.btnTransaction.TabIndex = 28;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.White;
            this.btnMember.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnMember.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnMember.Location = new System.Drawing.Point(30, 367);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(119, 41);
            this.btnMember.TabIndex = 27;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnStaff.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnStaff.Location = new System.Drawing.Point(30, 320);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(119, 41);
            this.btnStaff.TabIndex = 26;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAdmin.Location = new System.Drawing.Point(30, 275);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(119, 41);
            this.btnAdmin.TabIndex = 25;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 516);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pbProfile);
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.gpAdminAcc.ResumeLayout(false);
            this.gpAdminAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.GroupBox gpAdminAcc;
        private System.Windows.Forms.TextBox txtAdminFirstName;
        private System.Windows.Forms.Label lblAdminRegistrationDate;
        private System.Windows.Forms.Label lblAdminFirstName;
        private System.Windows.Forms.DateTimePicker dtpAdminRegistrationDate;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.TextBox txtAdminLastName;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label lblAdminLastName;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label lblAdminEmail;
        private System.Windows.Forms.Button btnResetText;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Button btnUpdateAdmin;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.DataGridView dgvAdmin;
    }
}