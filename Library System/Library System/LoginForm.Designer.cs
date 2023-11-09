namespace Library_System
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLfUsername = new System.Windows.Forms.TextBox();
            this.lblLfUsername = new System.Windows.Forms.Label();
            this.lblLfPassword = new System.Windows.Forms.Label();
            this.txtLfPassword = new System.Windows.Forms.TextBox();
            this.btnLfLogin = new System.Windows.Forms.Button();
            this.btnLfRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.SystemColors.Control;
            this.lblLogin.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.lblLogin.Location = new System.Drawing.Point(59, 36);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(88, 27);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "LOGIN";
            // 
            // txtLfUsername
            // 
            this.txtLfUsername.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.txtLfUsername.Location = new System.Drawing.Point(21, 140);
            this.txtLfUsername.Name = "txtLfUsername";
            this.txtLfUsername.Size = new System.Drawing.Size(177, 27);
            this.txtLfUsername.TabIndex = 1;
            // 
            // lblLfUsername
            // 
            this.lblLfUsername.AutoSize = true;
            this.lblLfUsername.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblLfUsername.Location = new System.Drawing.Point(20, 108);
            this.lblLfUsername.Name = "lblLfUsername";
            this.lblLfUsername.Size = new System.Drawing.Size(130, 24);
            this.lblLfUsername.TabIndex = 2;
            this.lblLfUsername.Text = "USERNAME";
            // 
            // lblLfPassword
            // 
            this.lblLfPassword.AutoSize = true;
            this.lblLfPassword.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblLfPassword.Location = new System.Drawing.Point(20, 190);
            this.lblLfPassword.Name = "lblLfPassword";
            this.lblLfPassword.Size = new System.Drawing.Size(134, 24);
            this.lblLfPassword.TabIndex = 4;
            this.lblLfPassword.Text = "PASSWORD";
            // 
            // txtLfPassword
            // 
            this.txtLfPassword.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.txtLfPassword.Location = new System.Drawing.Point(21, 225);
            this.txtLfPassword.Name = "txtLfPassword";
            this.txtLfPassword.Size = new System.Drawing.Size(177, 27);
            this.txtLfPassword.TabIndex = 3;
            // 
            // btnLfLogin
            // 
            this.btnLfLogin.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.btnLfLogin.Location = new System.Drawing.Point(24, 291);
            this.btnLfLogin.Name = "btnLfLogin";
            this.btnLfLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLfLogin.TabIndex = 5;
            this.btnLfLogin.Text = "LOGIN";
            this.btnLfLogin.UseVisualStyleBackColor = true;
            // 
            // btnLfRegister
            // 
            this.btnLfRegister.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.btnLfRegister.Location = new System.Drawing.Point(116, 291);
            this.btnLfRegister.Name = "btnLfRegister";
            this.btnLfRegister.Size = new System.Drawing.Size(82, 23);
            this.btnLfRegister.TabIndex = 6;
            this.btnLfRegister.Text = "REGISTER";
            this.btnLfRegister.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(217, 354);
            this.Controls.Add(this.btnLfRegister);
            this.Controls.Add(this.btnLfLogin);
            this.Controls.Add(this.lblLfPassword);
            this.Controls.Add(this.txtLfPassword);
            this.Controls.Add(this.lblLfUsername);
            this.Controls.Add(this.txtLfUsername);
            this.Controls.Add(this.lblLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLfUsername;
        private System.Windows.Forms.Label lblLfUsername;
        private System.Windows.Forms.Label lblLfPassword;
        private System.Windows.Forms.TextBox txtLfPassword;
        private System.Windows.Forms.Button btnLfLogin;
        private System.Windows.Forms.Button btnLfRegister;
    }
}

