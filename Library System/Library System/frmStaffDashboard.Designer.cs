namespace Library_System
{
    partial class frmStaffDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffDashboard));
            this.pnlBooks = new System.Windows.Forms.Panel();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.dgBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBookGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBookCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtBookQty = new System.Windows.Forms.TextBox();
            this.lblBookQty = new System.Windows.Forms.Label();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.txtBookGenre = new System.Windows.Forms.TextBox();
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.pbUserProfile = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUsernameProfile = new System.Windows.Forms.Label();
            this.btnMemberMenu = new System.Windows.Forms.Button();
            this.btnTransactionMenu = new System.Windows.Forms.Button();
            this.btnStaffMenu = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pnlBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.gbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBooks
            // 
            this.pnlBooks.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlBooks.Controls.Add(this.dgvBook);
            this.pnlBooks.Controls.Add(this.gbBook);
            this.pnlBooks.Location = new System.Drawing.Point(208, 1);
            this.pnlBooks.Name = "pnlBooks";
            this.pnlBooks.Size = new System.Drawing.Size(678, 589);
            this.pnlBooks.TabIndex = 8;
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
            this.dgvBook.Location = new System.Drawing.Point(20, 300);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(634, 278);
            this.dgvBook.TabIndex = 6;
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
            // dgBookTitle
            // 
            this.dgBookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgBookTitle.DataPropertyName = "BookTitle";
            this.dgBookTitle.HeaderText = "Book Title";
            this.dgBookTitle.MinimumWidth = 6;
            this.dgBookTitle.Name = "dgBookTitle";
            this.dgBookTitle.ReadOnly = true;
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
            // dgBookCopies
            // 
            this.dgBookCopies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgBookCopies.DataPropertyName = "BookCopies";
            this.dgBookCopies.HeaderText = "Book Quantity";
            this.dgBookCopies.MinimumWidth = 6;
            this.dgBookCopies.Name = "dgBookCopies";
            this.dgBookCopies.ReadOnly = true;
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
            this.gbBook.Location = new System.Drawing.Point(20, 7);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(634, 287);
            this.gbBook.TabIndex = 5;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "LibraLearnBooks";
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.White;
            this.btnUpdateBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnUpdateBook.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateBook.Location = new System.Drawing.Point(181, 232);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(122, 40);
            this.btnUpdateBook.TabIndex = 14;
            this.btnUpdateBook.Text = "UPDATE BOOK";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnClear.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Location = new System.Drawing.Point(468, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "CLEAR TEXT";
            this.btnClear.UseVisualStyleBackColor = false;
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
            // txtBookQty
            // 
            this.txtBookQty.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F);
            this.txtBookQty.Location = new System.Drawing.Point(39, 182);
            this.txtBookQty.Name = "txtBookQty";
            this.txtBookQty.Size = new System.Drawing.Size(314, 28);
            this.txtBookQty.TabIndex = 12;
            // 
            // lblBookQty
            // 
            this.lblBookQty.AutoSize = true;
            this.lblBookQty.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblBookQty.Location = new System.Drawing.Point(25, 158);
            this.lblBookQty.Name = "lblBookQty";
            this.lblBookQty.Size = new System.Drawing.Size(126, 21);
            this.lblBookQty.TabIndex = 11;
            this.lblBookQty.Text = "Book Quantity";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.White;
            this.btnDeleteBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDeleteBook.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteBook.Location = new System.Drawing.Point(323, 232);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(122, 40);
            this.btnDeleteBook.TabIndex = 3;
            this.btnDeleteBook.Text = "DELETE BOOK";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            // 
            // txtBookGenre
            // 
            this.txtBookGenre.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F);
            this.txtBookGenre.Location = new System.Drawing.Point(39, 117);
            this.txtBookGenre.Name = "txtBookGenre";
            this.txtBookGenre.Size = new System.Drawing.Size(314, 28);
            this.txtBookGenre.TabIndex = 10;
            // 
            // lblBookGenre
            // 
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblBookGenre.Location = new System.Drawing.Point(25, 93);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(106, 21);
            this.lblBookGenre.TabIndex = 9;
            this.lblBookGenre.Text = "Book Genre";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F);
            this.txtBookTitle.Location = new System.Drawing.Point(39, 58);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(314, 28);
            this.txtBookTitle.TabIndex = 6;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblBookTitle.Location = new System.Drawing.Point(25, 34);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(94, 21);
            this.lblBookTitle.TabIndex = 5;
            this.lblBookTitle.Text = "Book Title";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnAddBook.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddBook.Location = new System.Drawing.Point(39, 232);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(122, 40);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "ADD BOOK";
            this.btnAddBook.UseVisualStyleBackColor = false;
            // 
            // pbUserProfile
            // 
            this.pbUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbUserProfile.Image")));
            this.pbUserProfile.Location = new System.Drawing.Point(33, 27);
            this.pbUserProfile.Name = "pbUserProfile";
            this.pbUserProfile.Size = new System.Drawing.Size(142, 126);
            this.pbUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserProfile.TabIndex = 9;
            this.pbUserProfile.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F);
            this.lblWelcome.Location = new System.Drawing.Point(12, 156);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(176, 42);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Welcome,";
            // 
            // lblUsernameProfile
            // 
            this.lblUsernameProfile.AutoSize = true;
            this.lblUsernameProfile.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.lblUsernameProfile.Location = new System.Drawing.Point(19, 198);
            this.lblUsernameProfile.Name = "lblUsernameProfile";
            this.lblUsernameProfile.Size = new System.Drawing.Size(156, 31);
            this.lblUsernameProfile.TabIndex = 10;
            this.lblUsernameProfile.Text = "placeholder";
            // 
            // btnMemberMenu
            // 
            this.btnMemberMenu.BackColor = System.Drawing.Color.White;
            this.btnMemberMenu.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.btnMemberMenu.Location = new System.Drawing.Point(-4, 392);
            this.btnMemberMenu.Name = "btnMemberMenu";
            this.btnMemberMenu.Size = new System.Drawing.Size(206, 57);
            this.btnMemberMenu.TabIndex = 15;
            this.btnMemberMenu.Text = "Members";
            this.btnMemberMenu.UseVisualStyleBackColor = false;
            // 
            // btnTransactionMenu
            // 
            this.btnTransactionMenu.BackColor = System.Drawing.Color.White;
            this.btnTransactionMenu.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.btnTransactionMenu.Location = new System.Drawing.Point(-4, 455);
            this.btnTransactionMenu.Name = "btnTransactionMenu";
            this.btnTransactionMenu.Size = new System.Drawing.Size(206, 57);
            this.btnTransactionMenu.TabIndex = 14;
            this.btnTransactionMenu.Text = "Transactions";
            this.btnTransactionMenu.UseVisualStyleBackColor = false;
            // 
            // btnStaffMenu
            // 
            this.btnStaffMenu.BackColor = System.Drawing.Color.White;
            this.btnStaffMenu.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.btnStaffMenu.Location = new System.Drawing.Point(-4, 329);
            this.btnStaffMenu.Name = "btnStaffMenu";
            this.btnStaffMenu.Size = new System.Drawing.Size(206, 57);
            this.btnStaffMenu.TabIndex = 13;
            this.btnStaffMenu.Text = "Staffs";
            this.btnStaffMenu.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.White;
            this.btnAddUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F);
            this.btnAddUser.Location = new System.Drawing.Point(-4, 266);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(206, 57);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.Text = "Add Users";
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // frmStaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 589);
            this.Controls.Add(this.btnMemberMenu);
            this.Controls.Add(this.btnTransactionMenu);
            this.Controls.Add(this.btnStaffMenu);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblUsernameProfile);
            this.Controls.Add(this.pbUserProfile);
            this.Controls.Add(this.pnlBooks);
            this.Name = "frmStaffDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaffDashboard";
            this.pnlBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBooks;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBookGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBookCopies;
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
        private System.Windows.Forms.PictureBox pbUserProfile;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUsernameProfile;
        private System.Windows.Forms.Button btnMemberMenu;
        private System.Windows.Forms.Button btnTransactionMenu;
        private System.Windows.Forms.Button btnStaffMenu;
        private System.Windows.Forms.Button btnAddUser;
    }
}