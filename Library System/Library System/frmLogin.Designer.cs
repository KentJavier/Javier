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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblRegisterHere = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblReminder = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLogin.Controls.Add(this.cbShowPass);
            this.pnlLogin.Controls.Add(this.lblRegisterHere);
            this.pnlLogin.Controls.Add(this.lblWelcome);
            this.pnlLogin.Controls.Add(this.lblReminder);
            this.pnlLogin.Controls.Add(this.pictureBox2);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPasswordLogin);
            this.pnlLogin.Controls.Add(this.lblPasswordLogin);
            this.pnlLogin.Controls.Add(this.txtUsernameLogin);
            this.pnlLogin.Controls.Add(this.lblUsernameLogin);
            this.pnlLogin.Location = new System.Drawing.Point(375, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(422, 495);
            this.pnlLogin.TabIndex = 2;
            // 
            // lblRegisterHere
            // 
            this.lblRegisterHere.AutoSize = true;
            this.lblRegisterHere.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterHere.ForeColor = System.Drawing.Color.White;
            this.lblRegisterHere.Location = new System.Drawing.Point(267, 433);
            this.lblRegisterHere.Name = "lblRegisterHere";
            this.lblRegisterHere.Size = new System.Drawing.Size(120, 21);
            this.lblRegisterHere.TabIndex = 10;
            this.lblRegisterHere.Text = "Register here";
            this.lblRegisterHere.Click += new System.EventHandler(this.lblRegisterHere_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.SteelBlue;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(26, 44);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(169, 40);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome!";
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.ForeColor = System.Drawing.Color.White;
            this.lblReminder.Location = new System.Drawing.Point(47, 433);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(200, 21);
            this.lblReminder.TabIndex = 7;
            this.lblReminder.Text = "Don\'t have an account?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(350, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnLogin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.Location = new System.Drawing.Point(54, 317);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 41);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.Color.White;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtPasswordLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPasswordLogin.Location = new System.Drawing.Point(54, 267);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(322, 33);
            this.txtPasswordLogin.TabIndex = 2;
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.lblPasswordLogin.Location = new System.Drawing.Point(47, 231);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(100, 23);
            this.lblPasswordLogin.TabIndex = 3;
            this.lblPasswordLogin.Text = "Password";
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.BackColor = System.Drawing.Color.White;
            this.txtUsernameLogin.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtUsernameLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsernameLogin.Location = new System.Drawing.Point(54, 165);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(322, 33);
            this.txtUsernameLogin.TabIndex = 1;
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsernameLogin.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.lblUsernameLogin.ForeColor = System.Drawing.Color.White;
            this.lblUsernameLogin.Location = new System.Drawing.Point(50, 130);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(106, 23);
            this.lblUsernameLogin.TabIndex = 1;
            this.lblUsernameLogin.Text = "Username";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(42, 109);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(285, 271);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F);
            this.cbShowPass.ForeColor = System.Drawing.Color.White;
            this.cbShowPass.Location = new System.Drawing.Point(251, 317);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(136, 21);
            this.cbShowPass.TabIndex = 12;
            this.cbShowPass.Text = "Show Password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 495);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraLearn Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRegisterHere;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.CheckBox cbShowPass;
    }
}

