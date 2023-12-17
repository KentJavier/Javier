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
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.gpSearchStaff = new System.Windows.Forms.GroupBox();
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.gpSearchStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteStaff.Location = new System.Drawing.Point(495, 113);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(162, 45);
            this.btnDeleteStaff.TabIndex = 36;
            this.btnDeleteStaff.Text = "Delete Account";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            // 
            // dgvStaff
            // 
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(15, 179);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(642, 395);
            this.dgvStaff.TabIndex = 37;
            // 
            // gpSearchStaff
            // 
            this.gpSearchStaff.Controls.Add(this.txtSearchStaff);
            this.gpSearchStaff.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.gpSearchStaff.ForeColor = System.Drawing.Color.White;
            this.gpSearchStaff.Location = new System.Drawing.Point(15, 52);
            this.gpSearchStaff.Name = "gpSearchStaff";
            this.gpSearchStaff.Size = new System.Drawing.Size(436, 106);
            this.gpSearchStaff.TabIndex = 41;
            this.gpSearchStaff.TabStop = false;
            this.gpSearchStaff.Text = "SEARCH ACCOUNT";
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtSearchStaff.Location = new System.Drawing.Point(37, 43);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(361, 33);
            this.txtSearchStaff.TabIndex = 39;
            // 
            // staffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.gpSearchStaff);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Name = "staffControl";
            this.Size = new System.Drawing.Size(676, 590);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.gpSearchStaff.ResumeLayout(false);
            this.gpSearchStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.GroupBox gpSearchStaff;
        private System.Windows.Forms.TextBox txtSearchStaff;
    }
}
