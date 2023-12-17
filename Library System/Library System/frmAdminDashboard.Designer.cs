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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnViewStaff = new System.Windows.Forms.Button();
            this.btnViewAdmin = new System.Windows.Forms.Button();
            this.btnViewMember = new System.Windows.Forms.Button();
            this.btnViewTransaction = new System.Windows.Forms.Button();
            this.transactionControl = new Library_System.transactionControl();
            this.staffControl = new Library_System.staffControl();
            this.memberControl = new Library_System.memberControl();
            this.adminControl = new Library_System.adminControl();
            this.addUserControl = new Library_System.addUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome,";
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Lucida Sans Unicode", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblProfileName.Location = new System.Drawing.Point(12, 231);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(147, 27);
            this.lblProfileName.TabIndex = 2;
            this.lblProfileName.Text = "placeholder";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.White;
            this.btnAddAccount.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnAddAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAccount.Location = new System.Drawing.Point(12, 285);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(162, 45);
            this.btnAddAccount.TabIndex = 5;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnViewStaff
            // 
            this.btnViewStaff.BackColor = System.Drawing.Color.White;
            this.btnViewStaff.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnViewStaff.ForeColor = System.Drawing.Color.Black;
            this.btnViewStaff.Location = new System.Drawing.Point(12, 387);
            this.btnViewStaff.Name = "btnViewStaff";
            this.btnViewStaff.Size = new System.Drawing.Size(162, 45);
            this.btnViewStaff.TabIndex = 6;
            this.btnViewStaff.Text = "View Staff";
            this.btnViewStaff.UseVisualStyleBackColor = false;
            this.btnViewStaff.Click += new System.EventHandler(this.btnViewStaff_Click);
            // 
            // btnViewAdmin
            // 
            this.btnViewAdmin.BackColor = System.Drawing.Color.White;
            this.btnViewAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnViewAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnViewAdmin.Location = new System.Drawing.Point(12, 336);
            this.btnViewAdmin.Name = "btnViewAdmin";
            this.btnViewAdmin.Size = new System.Drawing.Size(162, 45);
            this.btnViewAdmin.TabIndex = 7;
            this.btnViewAdmin.Text = "View Admin";
            this.btnViewAdmin.UseVisualStyleBackColor = false;
            this.btnViewAdmin.Click += new System.EventHandler(this.btnViewAdmin_Click);
            // 
            // btnViewMember
            // 
            this.btnViewMember.BackColor = System.Drawing.Color.White;
            this.btnViewMember.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnViewMember.ForeColor = System.Drawing.Color.Black;
            this.btnViewMember.Location = new System.Drawing.Point(12, 438);
            this.btnViewMember.Name = "btnViewMember";
            this.btnViewMember.Size = new System.Drawing.Size(162, 45);
            this.btnViewMember.TabIndex = 8;
            this.btnViewMember.Text = "View Member";
            this.btnViewMember.UseVisualStyleBackColor = false;
            this.btnViewMember.Click += new System.EventHandler(this.btnViewMember_Click);
            // 
            // btnViewTransaction
            // 
            this.btnViewTransaction.BackColor = System.Drawing.Color.White;
            this.btnViewTransaction.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnViewTransaction.ForeColor = System.Drawing.Color.Black;
            this.btnViewTransaction.Location = new System.Drawing.Point(12, 489);
            this.btnViewTransaction.Name = "btnViewTransaction";
            this.btnViewTransaction.Size = new System.Drawing.Size(162, 45);
            this.btnViewTransaction.TabIndex = 9;
            this.btnViewTransaction.Text = "View Transaction";
            this.btnViewTransaction.UseVisualStyleBackColor = false;
            this.btnViewTransaction.Click += new System.EventHandler(this.btnViewTransaction_Click);
            // 
            // transactionControl
            // 
            this.transactionControl.BackColor = System.Drawing.Color.SteelBlue;
            this.transactionControl.Location = new System.Drawing.Point(193, -3);
            this.transactionControl.Name = "transactionControl";
            this.transactionControl.Size = new System.Drawing.Size(676, 590);
            this.transactionControl.TabIndex = 14;
            // 
            // staffControl
            // 
            this.staffControl.BackColor = System.Drawing.Color.SteelBlue;
            this.staffControl.Location = new System.Drawing.Point(193, -3);
            this.staffControl.Name = "staffControl";
            this.staffControl.Size = new System.Drawing.Size(676, 590);
            this.staffControl.TabIndex = 13;
            // 
            // memberControl
            // 
            this.memberControl.BackColor = System.Drawing.Color.SteelBlue;
            this.memberControl.Location = new System.Drawing.Point(193, -3);
            this.memberControl.Name = "memberControl";
            this.memberControl.Size = new System.Drawing.Size(676, 590);
            this.memberControl.TabIndex = 12;
            // 
            // adminControl
            // 
            this.adminControl.BackColor = System.Drawing.Color.SteelBlue;
            this.adminControl.Location = new System.Drawing.Point(193, -3);
            this.adminControl.Name = "adminControl";
            this.adminControl.Size = new System.Drawing.Size(676, 590);
            this.adminControl.TabIndex = 11;
            // 
            // addUserControl
            // 
            this.addUserControl.BackColor = System.Drawing.Color.SteelBlue;
            this.addUserControl.Location = new System.Drawing.Point(193, -3);
            this.addUserControl.Name = "addUserControl";
            this.addUserControl.Size = new System.Drawing.Size(681, 590);
            this.addUserControl.TabIndex = 10;
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 584);
            this.Controls.Add(this.transactionControl);
            this.Controls.Add(this.staffControl);
            this.Controls.Add(this.memberControl);
            this.Controls.Add(this.adminControl);
            this.Controls.Add(this.addUserControl);
            this.Controls.Add(this.btnViewTransaction);
            this.Controls.Add(this.btnViewMember);
            this.Controls.Add(this.btnViewAdmin);
            this.Controls.Add(this.btnViewStaff);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.lblProfileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.fmrAdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnViewStaff;
        private System.Windows.Forms.Button btnViewAdmin;
        private System.Windows.Forms.Button btnViewMember;
        private System.Windows.Forms.Button btnViewTransaction;
        private addUserControl addUserControl;
        private adminControl adminControl;
        private memberControl memberControl;
        private staffControl staffControl;
        private transactionControl transactionControl;
    }
}