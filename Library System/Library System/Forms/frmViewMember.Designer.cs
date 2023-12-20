namespace Library_System.Forms
{
    partial class frmViewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewMember));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.gpMemberAcc = new System.Windows.Forms.GroupBox();
            this.btnResetText = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.txtMemberFirstName = new System.Windows.Forms.TextBox();
            this.lblMemberRole = new System.Windows.Forms.Label();
            this.lblMemberRegistrationDate = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblMemberFirstName = new System.Windows.Forms.Label();
            this.dtpMemberRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.lblMemberPassword = new System.Windows.Forms.Label();
            this.txtMemberLastName = new System.Windows.Forms.TextBox();
            this.txtMemberPassword = new System.Windows.Forms.TextBox();
            this.lblMemberLastName = new System.Windows.Forms.Label();
            this.lblMemberUsername = new System.Windows.Forms.Label();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.txtMemberUsername = new System.Windows.Forms.TextBox();
            this.lblMemberEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.gpMemberAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.gpMemberAcc);
            this.panel1.Location = new System.Drawing.Point(186, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 518);
            this.panel1.TabIndex = 19;
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
            this.lblUsername.TabIndex = 18;
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
            this.lblWelcome.TabIndex = 17;
            this.lblWelcome.Text = "Welcome!";
            // 
            // pbProfile
            // 
            this.pbProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbProfile.Image")));
            this.pbProfile.Location = new System.Drawing.Point(15, 21);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(151, 140);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 12;
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
            // gpMemberAcc
            // 
            this.gpMemberAcc.Controls.Add(this.btnResetText);
            this.gpMemberAcc.Controls.Add(this.btnDeleteMember);
            this.gpMemberAcc.Controls.Add(this.btnUpdateMember);
            this.gpMemberAcc.Controls.Add(this.btnCreateMember);
            this.gpMemberAcc.Controls.Add(this.txtMemberFirstName);
            this.gpMemberAcc.Controls.Add(this.lblMemberRole);
            this.gpMemberAcc.Controls.Add(this.lblMemberRegistrationDate);
            this.gpMemberAcc.Controls.Add(this.cmbRole);
            this.gpMemberAcc.Controls.Add(this.lblMemberFirstName);
            this.gpMemberAcc.Controls.Add(this.dtpMemberRegistrationDate);
            this.gpMemberAcc.Controls.Add(this.lblMemberPassword);
            this.gpMemberAcc.Controls.Add(this.txtMemberLastName);
            this.gpMemberAcc.Controls.Add(this.txtMemberPassword);
            this.gpMemberAcc.Controls.Add(this.lblMemberLastName);
            this.gpMemberAcc.Controls.Add(this.lblMemberUsername);
            this.gpMemberAcc.Controls.Add(this.txtMemberEmail);
            this.gpMemberAcc.Controls.Add(this.txtMemberUsername);
            this.gpMemberAcc.Controls.Add(this.lblMemberEmail);
            this.gpMemberAcc.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.gpMemberAcc.ForeColor = System.Drawing.Color.White;
            this.gpMemberAcc.Location = new System.Drawing.Point(17, 11);
            this.gpMemberAcc.Name = "gpMemberAcc";
            this.gpMemberAcc.Size = new System.Drawing.Size(744, 228);
            this.gpMemberAcc.TabIndex = 45;
            this.gpMemberAcc.TabStop = false;
            this.gpMemberAcc.Text = "Member Account";
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
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.White;
            this.btnDeleteMember.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDeleteMember.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteMember.Location = new System.Drawing.Point(565, 173);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(75, 37);
            this.btnDeleteMember.TabIndex = 46;
            this.btnDeleteMember.Text = "Delete";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.BackColor = System.Drawing.Color.White;
            this.btnUpdateMember.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnUpdateMember.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateMember.Location = new System.Drawing.Point(484, 173);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateMember.TabIndex = 45;
            this.btnUpdateMember.Text = "Update";
            this.btnUpdateMember.UseVisualStyleBackColor = false;
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.BackColor = System.Drawing.Color.White;
            this.btnCreateMember.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnCreateMember.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCreateMember.Location = new System.Drawing.Point(404, 173);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(75, 37);
            this.btnCreateMember.TabIndex = 44;
            this.btnCreateMember.Text = "Create";
            this.btnCreateMember.UseVisualStyleBackColor = false;
            // 
            // txtMemberFirstName
            // 
            this.txtMemberFirstName.BackColor = System.Drawing.Color.White;
            this.txtMemberFirstName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtMemberFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtMemberFirstName.Location = new System.Drawing.Point(122, 76);
            this.txtMemberFirstName.Name = "txtMemberFirstName";
            this.txtMemberFirstName.Size = new System.Drawing.Size(230, 33);
            this.txtMemberFirstName.TabIndex = 29;
            // 
            // lblMemberRole
            // 
            this.lblMemberRole.AutoSize = true;
            this.lblMemberRole.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblMemberRole.ForeColor = System.Drawing.Color.White;
            this.lblMemberRole.Location = new System.Drawing.Point(17, 38);
            this.lblMemberRole.Name = "lblMemberRole";
            this.lblMemberRole.Size = new System.Drawing.Size(47, 21);
            this.lblMemberRole.TabIndex = 43;
            this.lblMemberRole.Text = "Role";
            // 
            // lblMemberRegistrationDate
            // 
            this.lblMemberRegistrationDate.AutoSize = true;
            this.lblMemberRegistrationDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblMemberRegistrationDate.ForeColor = System.Drawing.Color.White;
            this.lblMemberRegistrationDate.Location = new System.Drawing.Point(220, 38);
            this.lblMemberRegistrationDate.Name = "lblMemberRegistrationDate";
            this.lblMemberRegistrationDate.Size = new System.Drawing.Size(154, 21);
            this.lblMemberRegistrationDate.TabIndex = 36;
            this.lblMemberRegistrationDate.Text = "Registration Date";
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.cmbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(70, 35);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 29);
            this.cmbRole.TabIndex = 35;
            // 
            // lblMemberFirstName
            // 
            this.lblMemberFirstName.AutoSize = true;
            this.lblMemberFirstName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblMemberFirstName.ForeColor = System.Drawing.Color.White;
            this.lblMemberFirstName.Location = new System.Drawing.Point(17, 79);
            this.lblMemberFirstName.Name = "lblMemberFirstName";
            this.lblMemberFirstName.Size = new System.Drawing.Size(99, 21);
            this.lblMemberFirstName.TabIndex = 37;
            this.lblMemberFirstName.Text = "First Name";
            // 
            // dtpMemberRegistrationDate
            // 
            this.dtpMemberRegistrationDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtpMemberRegistrationDate.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dtpMemberRegistrationDate.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpMemberRegistrationDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.dtpMemberRegistrationDate.Location = new System.Drawing.Point(392, 35);
            this.dtpMemberRegistrationDate.Name = "dtpMemberRegistrationDate";
            this.dtpMemberRegistrationDate.Size = new System.Drawing.Size(329, 33);
            this.dtpMemberRegistrationDate.TabIndex = 34;
            // 
            // lblMemberPassword
            // 
            this.lblMemberPassword.AutoSize = true;
            this.lblMemberPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblMemberPassword.ForeColor = System.Drawing.Color.White;
            this.lblMemberPassword.Location = new System.Drawing.Point(388, 130);
            this.lblMemberPassword.Name = "lblMemberPassword";
            this.lblMemberPassword.Size = new System.Drawing.Size(87, 21);
            this.lblMemberPassword.TabIndex = 42;
            this.lblMemberPassword.Text = "Password";
            // 
            // txtMemberLastName
            // 
            this.txtMemberLastName.BackColor = System.Drawing.Color.White;
            this.txtMemberLastName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtMemberLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtMemberLastName.Location = new System.Drawing.Point(122, 127);
            this.txtMemberLastName.Name = "txtMemberLastName";
            this.txtMemberLastName.Size = new System.Drawing.Size(230, 33);
            this.txtMemberLastName.TabIndex = 30;
            // 
            // txtMemberPassword
            // 
            this.txtMemberPassword.BackColor = System.Drawing.Color.White;
            this.txtMemberPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtMemberPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtMemberPassword.Location = new System.Drawing.Point(490, 127);
            this.txtMemberPassword.Name = "txtMemberPassword";
            this.txtMemberPassword.Size = new System.Drawing.Size(231, 33);
            this.txtMemberPassword.TabIndex = 33;
            // 
            // lblMemberLastName
            // 
            this.lblMemberLastName.AutoSize = true;
            this.lblMemberLastName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblMemberLastName.ForeColor = System.Drawing.Color.White;
            this.lblMemberLastName.Location = new System.Drawing.Point(19, 130);
            this.lblMemberLastName.Name = "lblMemberLastName";
            this.lblMemberLastName.Size = new System.Drawing.Size(97, 21);
            this.lblMemberLastName.TabIndex = 41;
            this.lblMemberLastName.Text = "Last Name";
            // 
            // lblMemberUsername
            // 
            this.lblMemberUsername.AutoSize = true;
            this.lblMemberUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblMemberUsername.ForeColor = System.Drawing.Color.White;
            this.lblMemberUsername.Location = new System.Drawing.Point(386, 82);
            this.lblMemberUsername.Name = "lblMemberUsername";
            this.lblMemberUsername.Size = new System.Drawing.Size(93, 21);
            this.lblMemberUsername.TabIndex = 39;
            this.lblMemberUsername.Text = "Username";
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.BackColor = System.Drawing.Color.White;
            this.txtMemberEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtMemberEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtMemberEmail.Location = new System.Drawing.Point(122, 176);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.Size = new System.Drawing.Size(230, 33);
            this.txtMemberEmail.TabIndex = 31;
            // 
            // txtMemberUsername
            // 
            this.txtMemberUsername.BackColor = System.Drawing.Color.White;
            this.txtMemberUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtMemberUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtMemberUsername.Location = new System.Drawing.Point(491, 79);
            this.txtMemberUsername.Name = "txtMemberUsername";
            this.txtMemberUsername.Size = new System.Drawing.Size(230, 33);
            this.txtMemberUsername.TabIndex = 32;
            // 
            // lblMemberEmail
            // 
            this.lblMemberEmail.AutoSize = true;
            this.lblMemberEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblMemberEmail.ForeColor = System.Drawing.Color.White;
            this.lblMemberEmail.Location = new System.Drawing.Point(19, 179);
            this.lblMemberEmail.Name = "lblMemberEmail";
            this.lblMemberEmail.Size = new System.Drawing.Size(55, 21);
            this.lblMemberEmail.TabIndex = 40;
            this.lblMemberEmail.Text = "Email";
            // 
            // frmViewMember
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
            this.Name = "frmViewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Member";
            this.Load += new System.EventHandler(this.frmViewMember_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.gpMemberAcc.ResumeLayout(false);
            this.gpMemberAcc.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpMemberAcc;
        private System.Windows.Forms.Button btnResetText;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.TextBox txtMemberFirstName;
        private System.Windows.Forms.Label lblMemberRole;
        private System.Windows.Forms.Label lblMemberRegistrationDate;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblMemberFirstName;
        private System.Windows.Forms.DateTimePicker dtpMemberRegistrationDate;
        private System.Windows.Forms.Label lblMemberPassword;
        private System.Windows.Forms.TextBox txtMemberLastName;
        private System.Windows.Forms.TextBox txtMemberPassword;
        private System.Windows.Forms.Label lblMemberLastName;
        private System.Windows.Forms.Label lblMemberUsername;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.TextBox txtMemberUsername;
        private System.Windows.Forms.Label lblMemberEmail;
    }
}