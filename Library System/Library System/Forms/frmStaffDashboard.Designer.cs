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
            this.gpBooks = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnResetText = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBookGenre = new System.Windows.Forms.TextBox();
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.txtBookQty = new System.Windows.Forms.TextBox();
            this.lblBookCopies = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnStaff = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBooks = new System.Windows.Forms.Button();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.pnlBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.gpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBooks
            // 
            this.pnlBooks.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlBooks.Controls.Add(this.dgvBook);
            this.pnlBooks.Controls.Add(this.gpBooks);
            this.pnlBooks.Location = new System.Drawing.Point(186, -1);
            this.pnlBooks.Name = "pnlBooks";
            this.pnlBooks.Size = new System.Drawing.Size(784, 518);
            this.pnlBooks.TabIndex = 8;
            // 
            // dgvBook
            // 
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(18, 267);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(740, 238);
            this.dgvBook.TabIndex = 46;
            // 
            // gpBooks
            // 
            this.gpBooks.Controls.Add(this.pbLogo);
            this.gpBooks.Controls.Add(this.btnResetText);
            this.gpBooks.Controls.Add(this.btnDeleteBook);
            this.gpBooks.Controls.Add(this.btnUpdateBook);
            this.gpBooks.Controls.Add(this.btnCreateBook);
            this.gpBooks.Controls.Add(this.txtBookTitle);
            this.gpBooks.Controls.Add(this.lblBookTitle);
            this.gpBooks.Controls.Add(this.txtBookGenre);
            this.gpBooks.Controls.Add(this.lblBookGenre);
            this.gpBooks.Controls.Add(this.txtBookQty);
            this.gpBooks.Controls.Add(this.lblBookCopies);
            this.gpBooks.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.gpBooks.ForeColor = System.Drawing.Color.White;
            this.gpBooks.Location = new System.Drawing.Point(18, 13);
            this.gpBooks.Name = "gpBooks";
            this.gpBooks.Size = new System.Drawing.Size(740, 213);
            this.gpBooks.TabIndex = 45;
            this.gpBooks.TabStop = false;
            this.gpBooks.Text = "Books";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(586, 33);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(141, 140);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 48;
            this.pbLogo.TabStop = false;
            // 
            // btnResetText
            // 
            this.btnResetText.BackColor = System.Drawing.Color.White;
            this.btnResetText.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnResetText.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnResetText.Location = new System.Drawing.Point(495, 112);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(75, 37);
            this.btnResetText.TabIndex = 47;
            this.btnResetText.Text = "Reset";
            this.btnResetText.UseVisualStyleBackColor = false;
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.White;
            this.btnDeleteBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnDeleteBook.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteBook.Location = new System.Drawing.Point(405, 112);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 37);
            this.btnDeleteBook.TabIndex = 46;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.White;
            this.btnUpdateBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnUpdateBook.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateBook.Location = new System.Drawing.Point(495, 46);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateBook.TabIndex = 45;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.BackColor = System.Drawing.Color.White;
            this.btnCreateBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnCreateBook.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCreateBook.Location = new System.Drawing.Point(405, 46);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(75, 37);
            this.btnCreateBook.TabIndex = 44;
            this.btnCreateBook.Text = "Create";
            this.btnCreateBook.UseVisualStyleBackColor = false;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.BackColor = System.Drawing.Color.White;
            this.txtBookTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtBookTitle.Location = new System.Drawing.Point(160, 46);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(230, 33);
            this.txtBookTitle.TabIndex = 29;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblBookTitle.ForeColor = System.Drawing.Color.White;
            this.lblBookTitle.Location = new System.Drawing.Point(22, 52);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(94, 21);
            this.lblBookTitle.TabIndex = 37;
            this.lblBookTitle.Text = "Book Title";
            // 
            // txtBookGenre
            // 
            this.txtBookGenre.BackColor = System.Drawing.Color.White;
            this.txtBookGenre.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtBookGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtBookGenre.Location = new System.Drawing.Point(160, 144);
            this.txtBookGenre.Name = "txtBookGenre";
            this.txtBookGenre.Size = new System.Drawing.Size(230, 33);
            this.txtBookGenre.TabIndex = 30;
            // 
            // lblBookGenre
            // 
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblBookGenre.ForeColor = System.Drawing.Color.White;
            this.lblBookGenre.Location = new System.Drawing.Point(22, 147);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(106, 21);
            this.lblBookGenre.TabIndex = 41;
            this.lblBookGenre.Text = "Book Genre";
            // 
            // txtBookQty
            // 
            this.txtBookQty.BackColor = System.Drawing.Color.White;
            this.txtBookQty.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.txtBookQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtBookQty.Location = new System.Drawing.Point(160, 94);
            this.txtBookQty.Name = "txtBookQty";
            this.txtBookQty.Size = new System.Drawing.Size(230, 33);
            this.txtBookQty.TabIndex = 31;
            // 
            // lblBookCopies
            // 
            this.lblBookCopies.AutoSize = true;
            this.lblBookCopies.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.lblBookCopies.ForeColor = System.Drawing.Color.White;
            this.lblBookCopies.Location = new System.Drawing.Point(20, 94);
            this.lblBookCopies.Name = "lblBookCopies";
            this.lblBookCopies.Size = new System.Drawing.Size(114, 21);
            this.lblBookCopies.TabIndex = 40;
            this.lblBookCopies.Text = "Book Copies";
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.White;
            this.btnTransaction.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnTransaction.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTransaction.Location = new System.Drawing.Point(30, 414);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(119, 41);
            this.btnTransaction.TabIndex = 35;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.White;
            this.btnMember.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnMember.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnMember.Location = new System.Drawing.Point(30, 367);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(119, 41);
            this.btnMember.TabIndex = 34;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.lblUsername.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUsername.Location = new System.Drawing.Point(11, 215);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 23);
            this.lblUsername.TabIndex = 32;
            this.lblUsername.Text = "Username";
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnStaff.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnStaff.Location = new System.Drawing.Point(30, 320);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(119, 41);
            this.btnStaff.TabIndex = 33;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblWelcome.Location = new System.Drawing.Point(7, 164);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(169, 40);
            this.lblWelcome.TabIndex = 30;
            this.lblWelcome.Text = "Welcome!";
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.White;
            this.btnBooks.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            this.btnBooks.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBooks.Location = new System.Drawing.Point(30, 275);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(119, 41);
            this.btnBooks.TabIndex = 31;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            // 
            // pbProfile
            // 
            this.pbProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbProfile.Image")));
            this.pbProfile.Location = new System.Drawing.Point(15, 21);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(151, 140);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 29;
            this.pbProfile.TabStop = false;
            // 
            // frmStaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 516);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.pnlBooks);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmStaffDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaffDashboard";
            this.Load += new System.EventHandler(this.frmStaffDashboard_Load);
            this.pnlBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.gpBooks.ResumeLayout(false);
            this.gpBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBooks;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.GroupBox gpBooks;
        private System.Windows.Forms.Button btnResetText;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBookGenre;
        private System.Windows.Forms.Label lblBookGenre;
        private System.Windows.Forms.TextBox txtBookQty;
        private System.Windows.Forms.Label lblBookCopies;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.DataGridView dgvBook;
    }
}