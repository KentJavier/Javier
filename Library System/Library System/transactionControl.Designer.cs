namespace Library_System
{
    partial class transactionControl
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
            this.dtgTransaction = new System.Windows.Forms.DataGridView();
            this.btnAddAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTransaction
            // 
            this.dtgTransaction.AllowUserToDeleteRows = false;
            this.dtgTransaction.BackgroundColor = System.Drawing.Color.White;
            this.dtgTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTransaction.Location = new System.Drawing.Point(29, 131);
            this.dtgTransaction.Name = "dtgTransaction";
            this.dtgTransaction.ReadOnly = true;
            this.dtgTransaction.RowHeadersWidth = 51;
            this.dtgTransaction.RowTemplate.Height = 24;
            this.dtgTransaction.Size = new System.Drawing.Size(622, 441);
            this.dtgTransaction.TabIndex = 0;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.White;
            this.btnAddAccount.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnAddAccount.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddAccount.Location = new System.Drawing.Point(489, 80);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(162, 45);
            this.btnAddAccount.TabIndex = 37;
            this.btnAddAccount.Text = "Delete Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            // 
            // transactionContorl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.dtgTransaction);
            this.Name = "transactionContorl";
            this.Size = new System.Drawing.Size(678, 589);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTransaction;
        private System.Windows.Forms.Button btnAddAccount;
    }
}
