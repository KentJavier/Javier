using Library_System.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class frmStaffDashboard : Form
    {
        private string connectionString = "Data Source=DESKTOP-QLTR339\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True;";
        private UserRole currentUserRole;
        private string username;

        public frmStaffDashboard(UserRole role, string username)
        {
            InitializeComponent();
            currentUserRole = role;
            this.username = username;
            dgvBook.SelectionChanged += dgvBook_SelectionChanged;
        }

        private void frmStaffDashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{currentUserRole} {username}";
            LoadBooksData();
        }

        private void LoadBooksData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM vwBooks", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvBook.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedBookId()
        {
            if (dgvBook.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgvBook.SelectedRows[0].Cells["BookID"].Value);
            }
            return -1;
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("spInsertBook", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@BookTitle", txtBookTitle.Text);
                        cmd.Parameters.AddWithValue("@AuthorName", txtAuthorName.Text);
                        cmd.Parameters.AddWithValue("@BookGenre", txtBookGenre.Text);
                        cmd.Parameters.AddWithValue("@BookCopies", txtBookQty.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                LoadBooksData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                int bookIdToUpdate = GetSelectedBookId();

                if (bookIdToUpdate != -1)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("spUpdateBook", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@BookID", bookIdToUpdate);
                            cmd.Parameters.AddWithValue("@BookTitle", txtBookTitle.Text);
                            cmd.Parameters.AddWithValue("@AuthorName", txtAuthorName.Text);
                            cmd.Parameters.AddWithValue("@BookGenre", txtBookGenre.Text);
                            cmd.Parameters.AddWithValue("@BookCopies", txtBookQty.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadBooksData();
                }
                else
                {
                    MessageBox.Show("Please select a book from the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                int bookIdToDelete = GetSelectedBookId();

                if (bookIdToDelete != -1)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("spDeleteBook", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@BookID", bookIdToDelete);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadBooksData();
                }
                else
                {
                    MessageBox.Show("Please select a book from the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            txtBookTitle.Text = txtAuthorName.Text = txtBookGenre.Text = txtBookQty.Text = string.Empty;
        }

        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvBook.SelectedCells.Count > 0 && dgvBook.SelectedCells[0].RowIndex >= 0)
                {
                    int bookIdToUpdate = Convert.ToInt32(dgvBook.Rows[dgvBook.SelectedCells[0].RowIndex].Cells["BookID"].Value);

                    using (var connection = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand("SELECT * FROM vwBooks WHERE BookID = @BookID", connection))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookIdToUpdate);

                        using (var adapter = new SqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                var row = dt.Rows[0];

                                txtBookTitle.Text = row["BookTitle"].ToString();
                                txtAuthorName.Text = row["AuthorName"].ToString();
                                txtBookGenre.Text = row["BookGenre"].ToString();
                                txtBookQty.Text = row["BookCopies"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
