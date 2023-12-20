namespace Library_System.Forms
{
    partial class frmViewTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTransaction));
            this.btnTransaction = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMember = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnStaff = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.White;
            this.btnTransaction.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnTransaction.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTransaction.Location = new System.Drawing.Point(30, 414);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(119, 41);
            this.btnTransaction.TabIndex = 36;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(186, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 518);
            this.panel1.TabIndex = 34;
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.White;
            this.btnMember.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnMember.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnMember.Location = new System.Drawing.Point(30, 367);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(119, 41);
            this.btnMember.TabIndex = 35;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
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
            this.lblUsername.TabIndex = 32;
            this.lblUsername.Text = "Username";
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnStaff.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnStaff.Location = new System.Drawing.Point(30, 320);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(119, 41);
            this.btnStaff.TabIndex = 33;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
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
            this.lblWelcome.TabIndex = 30;
            this.lblWelcome.Text = "Welcome!";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAdmin.Location = new System.Drawing.Point(30, 275);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(119, 41);
            this.btnAdmin.TabIndex = 31;
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
            this.pbProfile.TabIndex = 29;
            this.pbProfile.TabStop = false;
            // 
            // frmViewTransaction
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
            this.Name = "frmViewTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Transaction";
            this.Load += new System.EventHandler(this.frmViewTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.PictureBox pbProfile;
    }
}