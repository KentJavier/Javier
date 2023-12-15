namespace Library_System
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.pnlAdminMenu = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUsernameProfile = new System.Windows.Forms.Label();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.txtBookGenre = new System.Windows.Forms.TextBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lblBookQty = new System.Windows.Forms.Label();
            this.txtBookQty = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.dgBookCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBookGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBookMenu = new System.Windows.Forms.Label();
            this.lblAuthorMenu = new System.Windows.Forms.Label();
            this.pnlAdminMenu.SuspendLayout();
            this.gbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdminMenu
            // 
            this.pnlAdminMenu.BackColor = System.Drawing.Color.White;
            this.pnlAdminMenu.Controls.Add(this.lblAuthorMenu);
            this.pnlAdminMenu.Controls.Add(this.lblBookMenu);
            this.pnlAdminMenu.Controls.Add(this.lblWelcome);
            this.pnlAdminMenu.Controls.Add(this.lblUsernameProfile);
            this.pnlAdminMenu.Location = new System.Drawing.Point(-2, -1);
            this.pnlAdminMenu.Name = "pnlAdminMenu";
            this.pnlAdminMenu.Size = new System.Drawing.Size(202, 592);
            this.pnlAdminMenu.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F);
            this.lblWelcome.Location = new System.Drawing.Point(13, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(176, 42);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome,";
            // 
            // lblUsernameProfile
            // 
            this.lblUsernameProfile.AutoSize = true;
            this.lblUsernameProfile.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.lblUsernameProfile.Location = new System.Drawing.Point(14, 61);
            this.lblUsernameProfile.Name = "lblUsernameProfile";
            this.lblUsernameProfile.Size = new System.Drawing.Size(156, 31);
            this.lblUsernameProfile.TabIndex = 0;
            this.lblUsernameProfile.Text = "placeholder";
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.btnUpdateBook);
            this.gbBook.Controls.Add(this.btnClear);
            this.gbBook.Controls.Add(this.pbLogo);
            this.gbBook.Controls.Add(this.txtBookQty);
            this.gbBook.Controls.Add(this.lblBookQty);
            this.gbBook.Controls.Add(this.btnDeleteBook);
            this.gbBook.Controls.Add(this.txtBookGenre);
            this.gbBook.Controls.Add(this.lblBookGenre);
            this.gbBook.Controls.Add(this.txtBookTitle);
            this.gbBook.Controls.Add(this.lblBookTitle);
            this.gbBook.Controls.Add(this.btnAddBook);
            this.gbBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.gbBook.ForeColor = System.Drawing.Color.White;
            this.gbBook.Location = new System.Drawing.Point(226, 12);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(633, 287);
            this.gbBook.TabIndex = 5;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "LibraLearnBooks";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnAddBook.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddBook.Location = new System.Drawing.Point(51, 232);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(122, 40);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "ADD BOOK";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblBookTitle.Location = new System.Drawing.Point(35, 34);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(94, 21);
            this.lblBookTitle.TabIndex = 5;
            this.lblBookTitle.Text = "Book Title";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F);
            this.txtBookTitle.Location = new System.Drawing.Point(49, 58);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(314, 28);
            this.txtBookTitle.TabIndex = 6;
            // 
            // lblBookGenre
            // 
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblBookGenre.Location = new System.Drawing.Point(35, 93);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(106, 21);
            this.lblBookGenre.TabIndex = 9;
            this.lblBookGenre.Text = "Book Genre";
            // 
            // txtBookGenre
            // 
            this.txtBookGenre.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F);
            this.txtBookGenre.Location = new System.Drawing.Point(49, 117);
            this.txtBookGenre.Name = "txtBookGenre";
            this.txtBookGenre.Size = new System.Drawing.Size(314, 28);
            this.txtBookGenre.TabIndex = 10;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.White;
            this.btnDeleteBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDeleteBook.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteBook.Location = new System.Drawing.Point(347, 232);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(122, 40);
            this.btnDeleteBook.TabIndex = 3;
            this.btnDeleteBook.Text = "DELETE BOOK";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // lblBookQty
            // 
            this.lblBookQty.AutoSize = true;
            this.lblBookQty.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblBookQty.Location = new System.Drawing.Point(35, 158);
            this.lblBookQty.Name = "lblBookQty";
            this.lblBookQty.Size = new System.Drawing.Size(126, 21);
            this.lblBookQty.TabIndex = 11;
            this.lblBookQty.Text = "Book Quantity";
            // 
            // txtBookQty
            // 
            this.txtBookQty.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F);
            this.txtBookQty.Location = new System.Drawing.Point(49, 182);
            this.txtBookQty.Name = "txtBookQty";
            this.txtBookQty.Size = new System.Drawing.Size(314, 28);
            this.txtBookQty.TabIndex = 12;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(395, 54);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(195, 156);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnClear.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Location = new System.Drawing.Point(495, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "CLEAR TEXT";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.White;
            this.btnUpdateBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnUpdateBook.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateBook.Location = new System.Drawing.Point(198, 232);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(122, 40);
            this.btnUpdateBook.TabIndex = 14;
            this.btnUpdateBook.Text = "UPDATE BOOK";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgBookId,
            this.dgBookTitle,
            this.dgBookGenre,
            this.dgBookCopies});
            this.dgvBook.Location = new System.Drawing.Point(225, 305);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(634, 278);
            this.dgvBook.TabIndex = 6;
            // 
            // dgBookCopies
            // 
            this.dgBookCopies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgBookCopies.DataPropertyName = "BookCopies";
            this.dgBookCopies.HeaderText = "Book Quantity";
            this.dgBookCopies.MinimumWidth = 6;
            this.dgBookCopies.Name = "dgBookCopies";
            this.dgBookCopies.ReadOnly = true;
            // 
            // dgBookGenre
            // 
            this.dgBookGenre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgBookGenre.DataPropertyName = "BookGenre";
            this.dgBookGenre.HeaderText = "Book Genre";
            this.dgBookGenre.MinimumWidth = 6;
            this.dgBookGenre.Name = "dgBookGenre";
            this.dgBookGenre.ReadOnly = true;
            // 
            // dgBookTitle
            // 
            this.dgBookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgBookTitle.DataPropertyName = "BookTitle";
            this.dgBookTitle.HeaderText = "Book Title";
            this.dgBookTitle.MinimumWidth = 6;
            this.dgBookTitle.Name = "dgBookTitle";
            this.dgBookTitle.ReadOnly = true;
            // 
            // dgBookId
            // 
            this.dgBookId.DataPropertyName = "BookId";
            this.dgBookId.HeaderText = "BookId";
            this.dgBookId.MinimumWidth = 6;
            this.dgBookId.Name = "dgBookId";
            this.dgBookId.ReadOnly = true;
            this.dgBookId.Visible = false;
            this.dgBookId.Width = 79;
            // 
            // lblBookMenu
            // 
            this.lblBookMenu.AutoSize = true;
            this.lblBookMenu.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.lblBookMenu.Location = new System.Drawing.Point(47, 221);
            this.lblBookMenu.Name = "lblBookMenu";
            this.lblBookMenu.Size = new System.Drawing.Size(88, 31);
            this.lblBookMenu.TabIndex = 2;
            this.lblBookMenu.Text = "label1";
            // 
            // lblAuthorMenu
            // 
            this.lblAuthorMenu.AutoSize = true;
            this.lblAuthorMenu.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.lblAuthorMenu.Location = new System.Drawing.Point(47, 281);
            this.lblAuthorMenu.Name = "lblAuthorMenu";
            this.lblAuthorMenu.Size = new System.Drawing.Size(88, 31);
            this.lblAuthorMenu.TabIndex = 3;
            this.lblAuthorMenu.Text = "label1";
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(885, 589);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.pnlAdminMenu);
            this.Controls.Add(this.gbBook);
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.pnlAdminMenu.ResumeLayout(false);
            this.pnlAdminMenu.PerformLayout();
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdminMenu;
        private System.Windows.Forms.Label lblUsernameProfile;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtBookQty;
        private System.Windows.Forms.Label lblBookQty;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.TextBox txtBookGenre;
        private System.Windows.Forms.Label lblBookGenre;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBookGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBookCopies;
        private System.Windows.Forms.Label lblAuthorMenu;
        private System.Windows.Forms.Label lblBookMenu;
    }
}