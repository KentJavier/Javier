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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.txtSearchAdmin = new System.Windows.Forms.TextBox();
            this.gpSearchAdmin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.gpSearchAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(15, 179);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(642, 395);
            this.dgvAdmin.TabIndex = 1;
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.BackColor = System.Drawing.Color.White;
            this.btnDeleteAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDeleteAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAdmin.Location = new System.Drawing.Point(495, 113);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(162, 45);
            this.btnDeleteAdmin.TabIndex = 37;
            this.btnDeleteAdmin.Text = "Delete Account";
            this.btnDeleteAdmin.UseVisualStyleBackColor = false;
            // 
            // txtSearchAdmin
            // 
            this.txtSearchAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtSearchAdmin.Location = new System.Drawing.Point(37, 43);
            this.txtSearchAdmin.Name = "txtSearchAdmin";
            this.txtSearchAdmin.Size = new System.Drawing.Size(361, 33);
            this.txtSearchAdmin.TabIndex = 39;
            // 
            // gpSearchAdmin
            // 
            this.gpSearchAdmin.Controls.Add(this.txtSearchAdmin);
            this.gpSearchAdmin.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.gpSearchAdmin.ForeColor = System.Drawing.Color.White;
            this.gpSearchAdmin.Location = new System.Drawing.Point(15, 52);
            this.gpSearchAdmin.Name = "gpSearchAdmin";
            this.gpSearchAdmin.Size = new System.Drawing.Size(436, 106);
            this.gpSearchAdmin.TabIndex = 40;
            this.gpSearchAdmin.TabStop = false;
            this.gpSearchAdmin.Text = "SEARCH ACCOUNT";
            // 
            // adminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.gpSearchAdmin);
            this.Controls.Add(this.btnDeleteAdmin);
            this.Controls.Add(this.dgvAdmin);
            this.Name = "adminControl";
            this.Size = new System.Drawing.Size(676, 590);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.gpSearchAdmin.ResumeLayout(false);
            this.gpSearchAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.TextBox txtSearchAdmin;
        private System.Windows.Forms.GroupBox gpSearchAdmin;
    }
}
