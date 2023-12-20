namespace Library_System.Forms
{
    partial class frmViewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewStaff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.gpStaffAcc = new System.Windows.Forms.GroupBox();
            this.btnResetText = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnCreateStaff = new System.Windows.Forms.Button();
            this.txtStaffFirstName = new System.Windows.Forms.TextBox();
            this.lblStaffRole = new System.Windows.Forms.Label();
            this.lblStaffRegistrationDate = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblStaffFirstName = new System.Windows.Forms.Label();
            this.dtpStaffRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.lblStaffPassword = new System.Windows.Forms.Label();
            this.txtStaffLastName = new System.Windows.Forms.TextBox();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.lblStaffLastName = new System.Windows.Forms.Label();
            this.lblStaffUsername = new System.Windows.Forms.Label();
            this.txtStaffEmail = new System.Windows.Forms.TextBox();
            this.txtStaffUsername = new System.Windows.Forms.TextBox();
            this.lblStaffEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.gpStaffAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.gpStaffAcc);
            this.panel1.Location = new System.Drawing.Point(186, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 518);
            this.panel1.TabIndex = 27;
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
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.White;
            this.btnTransaction.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnTransaction.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTransaction.Location = new System.Drawing.Point(30, 414);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(119, 41);
            this.btnTransaction.TabIndex = 24;
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
            this.btnMember.TabIndex = 23;
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
            this.btnStaff.TabIndex = 22;
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
            this.btnAdmin.TabIndex = 21;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
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
            // gpStaffAcc
            // 
            this.gpStaffAcc.Controls.Add(this.btnResetText);
            this.gpStaffAcc.Controls.Add(this.btnDeleteStaff);
            this.gpStaffAcc.Controls.Add(this.btnUpdateStaff);
            this.gpStaffAcc.Controls.Add(this.btnCreateStaff);
            this.gpStaffAcc.Controls.Add(this.txtStaffFirstName);
            this.gpStaffAcc.Controls.Add(this.lblStaffRole);
            this.gpStaffAcc.Controls.Add(this.lblStaffRegistrationDate);
            this.gpStaffAcc.Controls.Add(this.cmbRole);
            this.gpStaffAcc.Controls.Add(this.lblStaffFirstName);
            this.gpStaffAcc.Controls.Add(this.dtpStaffRegistrationDate);
            this.gpStaffAcc.Controls.Add(this.lblStaffPassword);
            this.gpStaffAcc.Controls.Add(this.txtStaffLastName);
            this.gpStaffAcc.Controls.Add(this.txtStaffPassword);
            this.gpStaffAcc.Controls.Add(this.lblStaffLastName);
            this.gpStaffAcc.Controls.Add(this.lblStaffUsername);
            this.gpStaffAcc.Controls.Add(this.txtStaffEmail);
            this.gpStaffAcc.Controls.Add(this.txtStaffUsername);
            this.gpStaffAcc.Controls.Add(this.lblStaffEmail);
            this.gpStaffAcc.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.gpStaffAcc.ForeColor = System.Drawing.Color.White;
            this.gpStaffAcc.Location = new System.Drawing.Point(17, 11);
            this.gpStaffAcc.Name = "gpStaffAcc";
            this.gpStaffAcc.Size = new System.Drawing.Size(744, 228);
            this.gpStaffAcc.TabIndex = 45;
            this.gpStaffAcc.TabStop = false;
            this.gpStaffAcc.Text = "Staff Account";
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
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteStaff.Location = new System.Drawing.Point(565, 173);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 37);
            this.btnDeleteStaff.TabIndex = 46;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.Color.White;
            this.btnUpdateStaff.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnUpdateStaff.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateStaff.Location = new System.Drawing.Point(484, 173);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateStaff.TabIndex = 45;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            // 
            // btnCreateStaff
            // 
            this.btnCreateStaff.BackColor = System.Drawing.Color.White;
            this.btnCreateStaff.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnCreateStaff.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCreateStaff.Location = new System.Drawing.Point(404, 173);
            this.btnCreateStaff.Name = "btnCreateStaff";
            this.btnCreateStaff.Size = new System.Drawing.Size(75, 37);
            this.btnCreateStaff.TabIndex = 44;
            this.btnCreateStaff.Text = "Create";
            this.btnCreateStaff.UseVisualStyleBackColor = false;
            // 
            // txtStaffFirstName
            // 
            this.txtStaffFirstName.BackColor = System.Drawing.Color.White;
            this.txtStaffFirstName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtStaffFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtStaffFirstName.Location = new System.Drawing.Point(122, 76);
            this.txtStaffFirstName.Name = "txtStaffFirstName";
            this.txtStaffFirstName.Size = new System.Drawing.Size(230, 33);
            this.txtStaffFirstName.TabIndex = 29;
            // 
            // lblStaffRole
            // 
            this.lblStaffRole.AutoSize = true;
            this.lblStaffRole.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblStaffRole.ForeColor = System.Drawing.Color.White;
            this.lblStaffRole.Location = new System.Drawing.Point(17, 38);
            this.lblStaffRole.Name = "lblStaffRole";
            this.lblStaffRole.Size = new System.Drawing.Size(47, 21);
            this.lblStaffRole.TabIndex = 43;
            this.lblStaffRole.Text = "Role";
            // 
            // lblStaffRegistrationDate
            // 
            this.lblStaffRegistrationDate.AutoSize = true;
            this.lblStaffRegistrationDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblStaffRegistrationDate.ForeColor = System.Drawing.Color.White;
            this.lblStaffRegistrationDate.Location = new System.Drawing.Point(220, 38);
            this.lblStaffRegistrationDate.Name = "lblStaffRegistrationDate";
            this.lblStaffRegistrationDate.Size = new System.Drawing.Size(154, 21);
            this.lblStaffRegistrationDate.TabIndex = 36;
            this.lblStaffRegistrationDate.Text = "Registration Date";
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
            // lblStaffFirstName
            // 
            this.lblStaffFirstName.AutoSize = true;
            this.lblStaffFirstName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblStaffFirstName.ForeColor = System.Drawing.Color.White;
            this.lblStaffFirstName.Location = new System.Drawing.Point(17, 79);
            this.lblStaffFirstName.Name = "lblStaffFirstName";
            this.lblStaffFirstName.Size = new System.Drawing.Size(99, 21);
            this.lblStaffFirstName.TabIndex = 37;
            this.lblStaffFirstName.Text = "First Name";
            // 
            // dtpStaffRegistrationDate
            // 
            this.dtpStaffRegistrationDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtpStaffRegistrationDate.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dtpStaffRegistrationDate.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpStaffRegistrationDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.dtpStaffRegistrationDate.Location = new System.Drawing.Point(392, 35);
            this.dtpStaffRegistrationDate.Name = "dtpStaffRegistrationDate";
            this.dtpStaffRegistrationDate.Size = new System.Drawing.Size(329, 33);
            this.dtpStaffRegistrationDate.TabIndex = 34;
            // 
            // lblStaffPassword
            // 
            this.lblStaffPassword.AutoSize = true;
            this.lblStaffPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblStaffPassword.ForeColor = System.Drawing.Color.White;
            this.lblStaffPassword.Location = new System.Drawing.Point(388, 130);
            this.lblStaffPassword.Name = "lblStaffPassword";
            this.lblStaffPassword.Size = new System.Drawing.Size(87, 21);
            this.lblStaffPassword.TabIndex = 42;
            this.lblStaffPassword.Text = "Password";
            // 
            // txtStaffLastName
            // 
            this.txtStaffLastName.BackColor = System.Drawing.Color.White;
            this.txtStaffLastName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtStaffLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtStaffLastName.Location = new System.Drawing.Point(122, 127);
            this.txtStaffLastName.Name = "txtStaffLastName";
            this.txtStaffLastName.Size = new System.Drawing.Size(230, 33);
            this.txtStaffLastName.TabIndex = 30;
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.BackColor = System.Drawing.Color.White;
            this.txtStaffPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtStaffPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtStaffPassword.Location = new System.Drawing.Point(490, 127);
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.Size = new System.Drawing.Size(231, 33);
            this.txtStaffPassword.TabIndex = 33;
            // 
            // lblStaffLastName
            // 
            this.lblStaffLastName.AutoSize = true;
            this.lblStaffLastName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblStaffLastName.ForeColor = System.Drawing.Color.White;
            this.lblStaffLastName.Location = new System.Drawing.Point(19, 130);
            this.lblStaffLastName.Name = "lblStaffLastName";
            this.lblStaffLastName.Size = new System.Drawing.Size(97, 21);
            this.lblStaffLastName.TabIndex = 41;
            this.lblStaffLastName.Text = "Last Name";
            // 
            // lblStaffUsername
            // 
            this.lblStaffUsername.AutoSize = true;
            this.lblStaffUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblStaffUsername.ForeColor = System.Drawing.Color.White;
            this.lblStaffUsername.Location = new System.Drawing.Point(386, 82);
            this.lblStaffUsername.Name = "lblStaffUsername";
            this.lblStaffUsername.Size = new System.Drawing.Size(93, 21);
            this.lblStaffUsername.TabIndex = 39;
            this.lblStaffUsername.Text = "Username";
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.BackColor = System.Drawing.Color.White;
            this.txtStaffEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtStaffEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtStaffEmail.Location = new System.Drawing.Point(122, 176);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(230, 33);
            this.txtStaffEmail.TabIndex = 31;
            // 
            // txtStaffUsername
            // 
            this.txtStaffUsername.BackColor = System.Drawing.Color.White;
            this.txtStaffUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtStaffUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtStaffUsername.Location = new System.Drawing.Point(491, 79);
            this.txtStaffUsername.Name = "txtStaffUsername";
            this.txtStaffUsername.Size = new System.Drawing.Size(230, 33);
            this.txtStaffUsername.TabIndex = 32;
            // 
            // lblStaffEmail
            // 
            this.lblStaffEmail.AutoSize = true;
            this.lblStaffEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblStaffEmail.ForeColor = System.Drawing.Color.White;
            this.lblStaffEmail.Location = new System.Drawing.Point(19, 179);
            this.lblStaffEmail.Name = "lblStaffEmail";
            this.lblStaffEmail.Size = new System.Drawing.Size(55, 21);
            this.lblStaffEmail.TabIndex = 40;
            this.lblStaffEmail.Text = "Email";
            // 
            // frmViewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pbProfile);
            this.Name = "frmViewStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Staff";
            this.Load += new System.EventHandler(this.frmViewStaff_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.gpStaffAcc.ResumeLayout(false);
            this.gpStaffAcc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.GroupBox gpStaffAcc;
        private System.Windows.Forms.Button btnResetText;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnCreateStaff;
        private System.Windows.Forms.TextBox txtStaffFirstName;
        private System.Windows.Forms.Label lblStaffRole;
        private System.Windows.Forms.Label lblStaffRegistrationDate;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblStaffFirstName;
        private System.Windows.Forms.DateTimePicker dtpStaffRegistrationDate;
        private System.Windows.Forms.Label lblStaffPassword;
        private System.Windows.Forms.TextBox txtStaffLastName;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.Label lblStaffLastName;
        private System.Windows.Forms.Label lblStaffUsername;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.TextBox txtStaffUsername;
        private System.Windows.Forms.Label lblStaffEmail;
    }
}