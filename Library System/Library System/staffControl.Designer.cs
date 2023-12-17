namespace Library_System
{
    partial class staffControl
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
            this.dgvStaffs = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgStaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStaffFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStaffLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStaffEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStaffUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStaffPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStaffRegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaffs
            // 
            this.dgvStaffs.AllowUserToDeleteRows = false;
            this.dgvStaffs.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgStaffId,
            this.dgStaffFirstName,
            this.dgStaffLastName,
            this.dgStaffEmail,
            this.dgStaffUsername,
            this.dgStaffPassword,
            this.dgStaffRegistrationDate});
            this.dgvStaffs.Location = new System.Drawing.Point(29, 131);
            this.dgvStaffs.Name = "dgvStaffs";
            this.dgvStaffs.ReadOnly = true;
            this.dgvStaffs.RowHeadersWidth = 51;
            this.dgvStaffs.RowTemplate.Height = 24;
            this.dgvStaffs.Size = new System.Drawing.Size(622, 441);
            this.dgvStaffs.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDelete.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.Location = new System.Drawing.Point(489, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 45);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgStaffId
            // 
            this.dgStaffId.DataPropertyName = "StaffId";
            this.dgStaffId.HeaderText = "StaffId";
            this.dgStaffId.MinimumWidth = 6;
            this.dgStaffId.Name = "dgStaffId";
            this.dgStaffId.ReadOnly = true;
            this.dgStaffId.Visible = false;
            this.dgStaffId.Width = 125;
            // 
            // dgStaffFirstName
            // 
            this.dgStaffFirstName.DataPropertyName = "StaffFirstName";
            this.dgStaffFirstName.HeaderText = "Staff First Name";
            this.dgStaffFirstName.MinimumWidth = 6;
            this.dgStaffFirstName.Name = "dgStaffFirstName";
            this.dgStaffFirstName.ReadOnly = true;
            this.dgStaffFirstName.Width = 125;
            // 
            // dgStaffLastName
            // 
            this.dgStaffLastName.DataPropertyName = "StaffLastName";
            this.dgStaffLastName.HeaderText = "Staff Last Name";
            this.dgStaffLastName.MinimumWidth = 6;
            this.dgStaffLastName.Name = "dgStaffLastName";
            this.dgStaffLastName.ReadOnly = true;
            this.dgStaffLastName.Width = 125;
            // 
            // dgStaffEmail
            // 
            this.dgStaffEmail.DataPropertyName = "StaffEmail";
            this.dgStaffEmail.HeaderText = "Staff Email";
            this.dgStaffEmail.MinimumWidth = 6;
            this.dgStaffEmail.Name = "dgStaffEmail";
            this.dgStaffEmail.ReadOnly = true;
            this.dgStaffEmail.Width = 125;
            // 
            // dgStaffUsername
            // 
            this.dgStaffUsername.DataPropertyName = "StaffUsername";
            this.dgStaffUsername.HeaderText = "Staff Username";
            this.dgStaffUsername.MinimumWidth = 6;
            this.dgStaffUsername.Name = "dgStaffUsername";
            this.dgStaffUsername.ReadOnly = true;
            this.dgStaffUsername.Width = 125;
            // 
            // dgStaffPassword
            // 
            this.dgStaffPassword.DataPropertyName = "StaffPassword";
            this.dgStaffPassword.HeaderText = "Staff Password";
            this.dgStaffPassword.MinimumWidth = 6;
            this.dgStaffPassword.Name = "dgStaffPassword";
            this.dgStaffPassword.ReadOnly = true;
            this.dgStaffPassword.Width = 125;
            // 
            // dgStaffRegistrationDate
            // 
            this.dgStaffRegistrationDate.DataPropertyName = "StaffRegistrationDate";
            this.dgStaffRegistrationDate.HeaderText = "Staff Registration Date";
            this.dgStaffRegistrationDate.MinimumWidth = 6;
            this.dgStaffRegistrationDate.Name = "dgStaffRegistrationDate";
            this.dgStaffRegistrationDate.ReadOnly = true;
            this.dgStaffRegistrationDate.Width = 125;
            // 
            // staffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvStaffs);
            this.Name = "staffControl";
            this.Size = new System.Drawing.Size(678, 589);
            this.Load += new System.EventHandler(this.staffControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffs;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStaffFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStaffLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStaffEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStaffUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStaffPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStaffRegistrationDate;
    }
}
