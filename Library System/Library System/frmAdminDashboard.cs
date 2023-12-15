using Library_System.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_System
{
    public partial class frmAdminDashboard : Form
    {
        Books newBook = new Books();

        private UserRepository userRepo;
        private UserRole currentUserRole;
        private string username;

        public frmAdminDashboard(UserRole userRole, string username)
        {
            InitializeComponent();
            userRepo = new UserRepository();
            currentUserRole = userRole;
            this.username = username;
        }

        // Clear function
        void Clear()
        {
            txtBookTitle.Text = txtBookGenre.Text = txtBookQty.Text = "";
        }
        // Load data function
        void LoadData()
        {
            dgvBook.AutoGenerateColumns = false;
            using (LibrarySystemEntities db = new LibrarySystemEntities())
            {
                dgvBook.DataSource = db.Books.ToList<Books>();
            }
        }
        // Sets the lblUsername profile into the current user's role and username
        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            // Set the label text based on the current user
            lblUsernameProfile.Text = $"{currentUserRole} {username}";

            LoadData();
        }
        // Insert into function
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            newBook.BookTitle = txtBookTitle.Text.Trim();
            newBook.BookGenre = txtBookGenre.Text.Trim();
            newBook.BookCopies = Convert.ToInt32(txtBookQty.Text);

            using (LibrarySystemEntities db = new LibrarySystemEntities())
            {
                db.Books.Add(newBook);
                db.SaveChanges();
            }
            Clear();
            LoadData();
            MessageBox.Show("Book has been added successfully!");
        }
        // Resets the textbox
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        // Updates the value inside the table
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dgvBook.CurrentRow == null)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }

            int selectedBookId = Convert.ToInt32(dgvBook.CurrentRow.Cells["dgBookId"].Value);

            using (LibrarySystemEntities db = new LibrarySystemEntities())
            {
                Books newBook = db.Books.Find(selectedBookId);

                if (newBook == null)
                {
                    MessageBox.Show("Selected book not found.");
                    return;
                }

                // Update book properties
                newBook.BookTitle = txtBookTitle.Text.Trim();
                newBook.BookGenre = txtBookGenre.Text.Trim();

                // Try parsing BookCopies
                if (int.TryParse(txtBookQty.Text, out int bookCopies))
                {
                    newBook.BookCopies = bookCopies;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for Book Copies.");
                    return;
                }

                // Determine whether to Add or Modify
                if (newBook.BookId == 0)
                {
                    db.Books.Add(newBook);
                }
                else
                {
                    db.Entry(newBook).State = EntityState.Modified;
                }

                db.SaveChanges();
                Clear();
                LoadData();

                MessageBox.Show("Book has been updated successfully!");
            }
        }
        // Use to delete values inside a table
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this book?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvBook.CurrentRow == null)
                {
                    MessageBox.Show("Please select a book to delete.");
                    return;
                }

                int selectedBookId = Convert.ToInt32(dgvBook.CurrentRow.Cells["dgBookId"].Value);

                using (LibrarySystemEntities db = new LibrarySystemEntities())
                {
                    Books bookToDelete = db.Books.Find(selectedBookId);

                    if (bookToDelete != null)
                    {
                        db.Books.Remove(bookToDelete);
                        db.SaveChanges();
                        LoadData();
                        Clear();
                        MessageBox.Show("Book deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Selected book not found.");
                    }
                }
            }
        }

    }
}
