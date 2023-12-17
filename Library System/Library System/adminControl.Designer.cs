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
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.dgAdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAdminFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAdminLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAdminEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAdminUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAdminPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAdminRegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.AllowUserToDeleteRows = false;
            this.dgvAdmins.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgAdminId,
            this.dgAdminFirstName,
            this.dgAdminLastName,
            this.dgAdminEmail,
            this.dgAdminUsername,
            this.dgAdminPassword,
            this.dgAdminRegistrationDate});
            this.dgvAdmins.Location = new System.Drawing.Point(29, 131);
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.RowHeadersWidth = 51;
            this.dgvAdmins.RowTemplate.Height = 24;
            this.dgvAdmins.Size = new System.Drawing.Size(622, 441);
            this.dgvAdmins.TabIndex = 1;
            // 
            // dgAdminId
            // 
            this.dgAdminId.DataPropertyName = "AdminId";
            this.dgAdminId.HeaderText = "Admin Id";
            this.dgAdminId.MinimumWidth = 6;
            this.dgAdminId.Name = "dgAdminId";
            this.dgAdminId.ReadOnly = true;
            this.dgAdminId.Visible = false;
            this.dgAdminId.Width = 125;
            // 
            // dgAdminFirstName
            // 
            this.dgAdminFirstName.DataPropertyName = "AdminFirstName";
            this.dgAdminFirstName.HeaderText = "Admin First Name";
            this.dgAdminFirstName.MinimumWidth = 6;
            this.dgAdminFirstName.Name = "dgAdminFirstName";
            this.dgAdminFirstName.ReadOnly = true;
            this.dgAdminFirstName.Width = 125;
            // 
            // dgAdminLastName
            // 
            this.dgAdminLastName.DataPropertyName = "AdminLastName";
            this.dgAdminLastName.HeaderText = "Admin Last Name";
            this.dgAdminLastName.MinimumWidth = 6;
            this.dgAdminLastName.Name = "dgAdminLastName";
            this.dgAdminLastName.ReadOnly = true;
            this.dgAdminLastName.Width = 125;
            // 
            // dgAdminEmail
            // 
            this.dgAdminEmail.DataPropertyName = "AdminEmail";
            this.dgAdminEmail.HeaderText = "Admin Email";
            this.dgAdminEmail.MinimumWidth = 6;
            this.dgAdminEmail.Name = "dgAdminEmail";
            this.dgAdminEmail.ReadOnly = true;
            this.dgAdminEmail.Width = 125;
            // 
            // dgAdminUsername
            // 
            this.dgAdminUsername.DataPropertyName = "AdminUsername";
            this.dgAdminUsername.HeaderText = "Admin Username";
            this.dgAdminUsername.MinimumWidth = 6;
            this.dgAdminUsername.Name = "dgAdminUsername";
            this.dgAdminUsername.ReadOnly = true;
            this.dgAdminUsername.Width = 125;
            // 
            // dgAdminPassword
            // 
            this.dgAdminPassword.DataPropertyName = "AdminPassword";
            this.dgAdminPassword.HeaderText = "Admin Password";
            this.dgAdminPassword.MinimumWidth = 6;
            this.dgAdminPassword.Name = "dgAdminPassword";
            this.dgAdminPassword.ReadOnly = true;
            this.dgAdminPassword.Width = 125;
            // 
            // dgAdminRegistrationDate
            // 
            this.dgAdminRegistrationDate.DataPropertyName = "AdminRegistrationDate";
            this.dgAdminRegistrationDate.HeaderText = "Admin Registration Date";
            this.dgAdminRegistrationDate.MinimumWidth = 6;
            this.dgAdminRegistrationDate.Name = "dgAdminRegistrationDate";
            this.dgAdminRegistrationDate.ReadOnly = true;
            this.dgAdminRegistrationDate.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDelete.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.Location = new System.Drawing.Point(489, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 45);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // adminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvAdmins);
            this.Name = "adminControl";
            this.Size = new System.Drawing.Size(678, 589);
            this.Load += new System.EventHandler(this.adminControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdminFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdminLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdminEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdminUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdminPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdminRegistrationDate;
        private System.Windows.Forms.Button btnDelete;
    }
}
