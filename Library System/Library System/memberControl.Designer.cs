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
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.gpSearchMember = new System.Windows.Forms.GroupBox();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.gpSearchMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMember
            // 
            this.dgvMember.BackgroundColor = System.Drawing.Color.White;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(15, 179);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.Size = new System.Drawing.Size(642, 395);
            this.dgvMember.TabIndex = 0;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.White;
            this.btnDeleteMember.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDeleteMember.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteMember.Location = new System.Drawing.Point(495, 113);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(162, 45);
            this.btnDeleteMember.TabIndex = 35;
            this.btnDeleteMember.Text = "Delete Account";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            // 
            // gpSearchMember
            // 
            this.gpSearchMember.Controls.Add(this.txtSearchMember);
            this.gpSearchMember.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.gpSearchMember.ForeColor = System.Drawing.Color.White;
            this.gpSearchMember.Location = new System.Drawing.Point(15, 52);
            this.gpSearchMember.Name = "gpSearchMember";
            this.gpSearchMember.Size = new System.Drawing.Size(436, 106);
            this.gpSearchMember.TabIndex = 41;
            this.gpSearchMember.TabStop = false;
            this.gpSearchMember.Text = "SEARCH ACCOUNT";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtSearchMember.Location = new System.Drawing.Point(37, 43);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(361, 33);
            this.txtSearchMember.TabIndex = 39;
            // 
            // memberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.gpSearchMember);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.dgvMember);
            this.Name = "memberControl";
            this.Size = new System.Drawing.Size(676, 590);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.gpSearchMember.ResumeLayout(false);
            this.gpSearchMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.GroupBox gpSearchMember;
        private System.Windows.Forms.TextBox txtSearchMember;
    }
}
