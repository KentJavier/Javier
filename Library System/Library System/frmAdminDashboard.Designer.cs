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
            this.btnAdminsMenu = new System.Windows.Forms.Button();
            this.btnMemberMenu = new System.Windows.Forms.Button();
            this.btnTransactionMenu = new System.Windows.Forms.Button();
            this.btnStaffMenu = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUsernameProfile = new System.Windows.Forms.Label();
            this.pbUserProfile = new System.Windows.Forms.PictureBox();
            this.addUserControl = new Library_System.addUserControl();
            this.adminControl = new Library_System.adminControl();
            this.memberControl = new Library_System.memberControl();
            this.staffControl = new Library_System.staffControl();
            this.transactionControl = new Library_System.transactionControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminsMenu
            // 
            this.btnAdminsMenu.BackColor = System.Drawing.Color.White;
            this.btnAdminsMenu.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.btnAdminsMenu.Location = new System.Drawing.Point(2, 317);
            this.btnAdminsMenu.Name = "btnAdminsMenu";
            this.btnAdminsMenu.Size = new System.Drawing.Size(206, 57);
            this.btnAdminsMenu.TabIndex = 31;
            this.btnAdminsMenu.Text = "Admins";
            this.btnAdminsMenu.UseVisualStyleBackColor = false;
            this.btnAdminsMenu.Click += new System.EventHandler(this.btnAdminsMenu_Click);
            // 
            // btnMemberMenu
            // 
            this.btnMemberMenu.BackColor = System.Drawing.Color.White;
            this.btnMemberMenu.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.btnMemberMenu.Location = new System.Drawing.Point(2, 446);
            this.btnMemberMenu.Name = "btnMemberMenu";
            this.btnMemberMenu.Size = new System.Drawing.Size(206, 57);
            this.btnMemberMenu.TabIndex = 30;
            this.btnMemberMenu.Text = "Members";
            this.btnMemberMenu.UseVisualStyleBackColor = false;
            this.btnMemberMenu.Click += new System.EventHandler(this.btnMemberMenu_Click);
            // 
            // btnTransactionMenu
            // 
            this.btnTransactionMenu.BackColor = System.Drawing.Color.White;
            this.btnTransactionMenu.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.btnTransactionMenu.Location = new System.Drawing.Point(2, 509);
            this.btnTransactionMenu.Name = "btnTransactionMenu";
            this.btnTransactionMenu.Size = new System.Drawing.Size(206, 57);
            this.btnTransactionMenu.TabIndex = 29;
            this.btnTransactionMenu.Text = "Transactions";
            this.btnTransactionMenu.UseVisualStyleBackColor = false;
            this.btnTransactionMenu.Click += new System.EventHandler(this.btnTransactionMenu_Click);
            // 
            // btnStaffMenu
            // 
            this.btnStaffMenu.BackColor = System.Drawing.Color.White;
            this.btnStaffMenu.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.btnStaffMenu.Location = new System.Drawing.Point(2, 383);
            this.btnStaffMenu.Name = "btnStaffMenu";
            this.btnStaffMenu.Size = new System.Drawing.Size(206, 57);
            this.btnStaffMenu.TabIndex = 28;
            this.btnStaffMenu.Text = "Staffs";
            this.btnStaffMenu.UseVisualStyleBackColor = false;
            this.btnStaffMenu.Click += new System.EventHandler(this.btnStaffMenu_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.White;
            this.btnAddUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.btnAddUser.Location = new System.Drawing.Point(2, 254);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(206, 57);
            this.btnAddUser.TabIndex = 27;
            this.btnAddUser.Text = "Add Users";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F);
            this.lblWelcome.Location = new System.Drawing.Point(12, 166);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(176, 42);
            this.lblWelcome.TabIndex = 26;
            this.lblWelcome.Text = "Welcome,";
            // 
            // lblUsernameProfile
            // 
            this.lblUsernameProfile.AutoSize = true;
            this.lblUsernameProfile.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.lblUsernameProfile.Location = new System.Drawing.Point(13, 208);
            this.lblUsernameProfile.Name = "lblUsernameProfile";
            this.lblUsernameProfile.Size = new System.Drawing.Size(156, 31);
            this.lblUsernameProfile.TabIndex = 25;
            this.lblUsernameProfile.Text = "placeholder";
            // 
            // pbUserProfile
            // 
            this.pbUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbUserProfile.Image")));
            this.pbUserProfile.Location = new System.Drawing.Point(31, 28);
            this.pbUserProfile.Name = "pbUserProfile";
            this.pbUserProfile.Size = new System.Drawing.Size(142, 126);
            this.pbUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserProfile.TabIndex = 24;
            this.pbUserProfile.TabStop = false;
            // 
            // addUserControl
            // 
            this.addUserControl.BackColor = System.Drawing.Color.SteelBlue;
            this.addUserControl.Location = new System.Drawing.Point(214, 3);
            this.addUserControl.Name = "addUserControl";
            this.addUserControl.Size = new System.Drawing.Size(678, 589);
            this.addUserControl.TabIndex = 32;
            // 
            // adminControl
            // 
            this.adminControl.BackColor = System.Drawing.Color.SteelBlue;
            this.adminControl.Location = new System.Drawing.Point(214, 3);
            this.adminControl.Name = "adminControl";
            this.adminControl.Size = new System.Drawing.Size(678, 589);
            this.adminControl.TabIndex = 33;
            // 
            // memberControl
            // 
            this.memberControl.BackColor = System.Drawing.Color.SteelBlue;
            this.memberControl.Location = new System.Drawing.Point(214, 3);
            this.memberControl.Name = "memberControl";
            this.memberControl.Size = new System.Drawing.Size(678, 589);
            this.memberControl.TabIndex = 34;
            // 
            // staffControl
            // 
            this.staffControl.BackColor = System.Drawing.Color.SteelBlue;
            this.staffControl.Location = new System.Drawing.Point(214, 3);
            this.staffControl.Name = "staffControl";
            this.staffControl.Size = new System.Drawing.Size(678, 589);
            this.staffControl.TabIndex = 35;
            // 
            // transactionControl
            // 
            this.transactionControl.BackColor = System.Drawing.Color.SteelBlue;
            this.transactionControl.Location = new System.Drawing.Point(214, 3);
            this.transactionControl.Name = "transactionControl";
            this.transactionControl.Size = new System.Drawing.Size(678, 589);
            this.transactionControl.TabIndex = 36;
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 589);
            this.Controls.Add(this.transactionControl);
            this.Controls.Add(this.staffControl);
            this.Controls.Add(this.memberControl);
            this.Controls.Add(this.adminControl);
            this.Controls.Add(this.addUserControl);
            this.Controls.Add(this.btnAdminsMenu);
            this.Controls.Add(this.btnMemberMenu);
            this.Controls.Add(this.btnTransactionMenu);
            this.Controls.Add(this.btnStaffMenu);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblUsernameProfile);
            this.Controls.Add(this.pbUserProfile);
            this.Name = "frmAdminDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminsMenu;
        private System.Windows.Forms.Button btnMemberMenu;
        private System.Windows.Forms.Button btnTransactionMenu;
        private System.Windows.Forms.Button btnStaffMenu;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUsernameProfile;
        private System.Windows.Forms.PictureBox pbUserProfile;
        private addUserControl addUserControl;
        private adminControl adminControl;
        private memberControl memberControl;
        private staffControl staffControl;
        private transactionControl transactionControl;
    }
}