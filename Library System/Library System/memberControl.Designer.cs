namespace Library_System
{
    partial class memberControl
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
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.dgMemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMemberFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMemberLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMemberEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMemberUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMemberPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMemberRegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgMemberId,
            this.dgMemberFirstName,
            this.dgMemberLastName,
            this.dgMemberEmail,
            this.dgMemberUsername,
            this.dgMemberPassword,
            this.dgMemberRegistrationDate});
            this.dgvMembers.Location = new System.Drawing.Point(29, 131);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(622, 441);
            this.dgvMembers.TabIndex = 1;
            // 
            // dgMemberId
            // 
            this.dgMemberId.DataPropertyName = "MemberId";
            this.dgMemberId.HeaderText = "MemberId";
            this.dgMemberId.MinimumWidth = 6;
            this.dgMemberId.Name = "dgMemberId";
            this.dgMemberId.ReadOnly = true;
            this.dgMemberId.Visible = false;
            this.dgMemberId.Width = 125;
            // 
            // dgMemberFirstName
            // 
            this.dgMemberFirstName.DataPropertyName = "MemberFirstName";
            this.dgMemberFirstName.HeaderText = "Membe First Name";
            this.dgMemberFirstName.MinimumWidth = 6;
            this.dgMemberFirstName.Name = "dgMemberFirstName";
            this.dgMemberFirstName.ReadOnly = true;
            this.dgMemberFirstName.Width = 125;
            // 
            // dgMemberLastName
            // 
            this.dgMemberLastName.DataPropertyName = "MemberLastName";
            this.dgMemberLastName.HeaderText = "Member Last Name";
            this.dgMemberLastName.MinimumWidth = 6;
            this.dgMemberLastName.Name = "dgMemberLastName";
            this.dgMemberLastName.ReadOnly = true;
            this.dgMemberLastName.Width = 125;
            // 
            // dgMemberEmail
            // 
            this.dgMemberEmail.DataPropertyName = "MemberEmail";
            this.dgMemberEmail.HeaderText = "Member Email";
            this.dgMemberEmail.MinimumWidth = 6;
            this.dgMemberEmail.Name = "dgMemberEmail";
            this.dgMemberEmail.ReadOnly = true;
            this.dgMemberEmail.Width = 125;
            // 
            // dgMemberUsername
            // 
            this.dgMemberUsername.DataPropertyName = "MemberUsername";
            this.dgMemberUsername.HeaderText = "Member Username";
            this.dgMemberUsername.MinimumWidth = 6;
            this.dgMemberUsername.Name = "dgMemberUsername";
            this.dgMemberUsername.ReadOnly = true;
            this.dgMemberUsername.Width = 125;
            // 
            // dgMemberPassword
            // 
            this.dgMemberPassword.DataPropertyName = "MemberPassword";
            this.dgMemberPassword.HeaderText = "Member Password";
            this.dgMemberPassword.MinimumWidth = 6;
            this.dgMemberPassword.Name = "dgMemberPassword";
            this.dgMemberPassword.ReadOnly = true;
            this.dgMemberPassword.Width = 125;
            // 
            // dgMemberRegistrationDate
            // 
            this.dgMemberRegistrationDate.DataPropertyName = "MemberRegistrationDate";
            this.dgMemberRegistrationDate.HeaderText = "Member Registration Date";
            this.dgMemberRegistrationDate.MinimumWidth = 6;
            this.dgMemberRegistrationDate.Name = "dgMemberRegistrationDate";
            this.dgMemberRegistrationDate.ReadOnly = true;
            this.dgMemberRegistrationDate.Width = 125;
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
            // memberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvMembers);
            this.Name = "memberControl";
            this.Size = new System.Drawing.Size(678, 589);
            this.Load += new System.EventHandler(this.memberControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMemberFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMemberLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMemberEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMemberUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMemberPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMemberRegistrationDate;
    }
}
