using Library_System.AppData;
using Library_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class frmAdminDashboard : Form
    {
        private string connectionString = "Data Source=DESKTOP-QLTR339\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True;";
        private UserRole currentUserRole;
        private string username;

        public frmAdminDashboard(UserRole role, string username)
        {
            InitializeComponent();
            currentUserRole = role;
            this.username = username;

            dgvAdmin.SelectionChanged += dgvAdmin_SelectionChanged;
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{currentUserRole} {username}";
            LoadAdminsData();
        }

        // Function to switch forms

        private void btnStaff_Click(object sender, EventArgs e)
        {
            // Check if the form is already open
            Form frm = Application.OpenForms[nameof(frmViewStaff)];

            if (frm != null)
            {
                // If open, bring it to the front
                frm.BringToFront();
            }
            else
            {
                // If not open, create a new instance
                frmViewStaff viewStaff = new frmViewStaff(UserRole.Admin, username);
                viewStaff.Show();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Check if the form is already open
            Form frm = Application.OpenForms[nameof(frmAdminDashboard)];

            if (frm != null)
            {
                // If the form is already open, bring it to the front
                frm.BringToFront();
            }
            else
            {
                // If the form is not open, create a new instance
                frmAdminDashboard adminDashboard = new frmAdminDashboard(UserRole.Admin, username);
                adminDashboard.Show();
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            // Check if the form is already open
            Form frm = Application.OpenForms[nameof(frmViewMember)];

            if (frm != null)
            {
                // If open, bring it to the front
                frm.BringToFront();
            }
            else
            {
                // If not open, create a new instance
                frmViewMember viewMember = new frmViewMember(UserRole.Admin, username);
                viewMember.Show();
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            // Checks if the form is open
            Form frm = Application.OpenForms[nameof(frmViewTransaction)];

            if (frm != null)
            {
                // If open, bring it to the front
                frm.BringToFront();
            }
            else
            {
                // If not open, create a new instance
                frmViewTransaction viewTransaction = new frmViewTransaction(UserRole.Admin, username);
                viewTransaction.Show();
            }
        }
        // Loads the data from the SQL using vwAdmins
        private void LoadAdminsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM vwAdmins", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvAdmin.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Gets the AdminId
        private int GetSelectedAdminId()
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgvAdmin.SelectedRows[0].Cells["AdminID"].Value);
            }
            return -1;
        }

        // A function that inserts the user's input inside the DataGridView
        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("spInsertAdmin", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@AdminFirstName", txtAdminFirstName.Text);
                        cmd.Parameters.AddWithValue("@AdminLastName", txtAdminLastName.Text);
                        cmd.Parameters.AddWithValue("@AdminEmail", txtAdminEmail.Text);
                        cmd.Parameters.AddWithValue("@AdminUsername", txtAdminUsername.Text);
                        cmd.Parameters.AddWithValue("@AdminPassword", txtAdminPassword.Text);
                        cmd.Parameters.AddWithValue("@AdminRegistrationDate", dtpAdminRegistrationDate.Value);
                        cmd.Parameters.AddWithValue("@RoleId", 1);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadAdminsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // A function that updates the values inside the DataGridView
        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                int adminIdToUpdate = GetSelectedAdminId();

                if (adminIdToUpdate != -1)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("spUpdateAdmin", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@AdminID", adminIdToUpdate);
                            cmd.Parameters.AddWithValue("@AdminFirstName", txtAdminFirstName.Text);
                            cmd.Parameters.AddWithValue("@AdminLastName", txtAdminLastName.Text);
                            cmd.Parameters.AddWithValue("@AdminEmail", txtAdminEmail.Text);
                            cmd.Parameters.AddWithValue("@AdminUsername", txtAdminUsername.Text);
                            cmd.Parameters.AddWithValue("@AdminPassword", txtAdminPassword.Text);
                            cmd.Parameters.AddWithValue("@AdminRegistrationDate", dtpAdminRegistrationDate.Value);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadAdminsData();
                }
                else
                {
                    MessageBox.Show("Please select an admin from the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Function to delete values
        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                int adminIdToDelete = GetSelectedAdminId();

                if (adminIdToDelete != -1)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("spDeleteAdmin", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@AdminID", adminIdToDelete);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadAdminsData();
                }
                else
                {
                    MessageBox.Show("Please select an admin from the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function to clear text in textbox
        private void btnResetText_Click(object sender, EventArgs e)
        {
            txtAdminFirstName.Text = txtAdminLastName.Text = txtAdminEmail.Text = txtAdminUsername.Text = txtAdminPassword.Text = string.Empty;
            dtpAdminRegistrationDate.Value = DateTime.Now;
        }

        // To paste values from cell to textbox
        private void dgvAdmin_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvAdmin.SelectedCells.Count > 0 && dgvAdmin.SelectedCells[0].RowIndex >= 0)
                {
                    int adminIdToUpdate = Convert.ToInt32(dgvAdmin.Rows[dgvAdmin.SelectedCells[0].RowIndex].Cells["AdminID"].Value);

                    using (var connection = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand("SELECT * FROM vwAdmins WHERE AdminID = @AdminID", connection))
                    {
                        cmd.Parameters.AddWithValue("@AdminID", adminIdToUpdate);

                        using (var adapter = new SqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                var row = dt.Rows[0];

                                txtAdminFirstName.Text = row["AdminFirstName"].ToString();
                                txtAdminLastName.Text = row["AdminLastName"].ToString();
                                txtAdminEmail.Text = row["AdminEmail"].ToString();
                                txtAdminUsername.Text = row["AdminUsername"].ToString();
                                txtAdminPassword.Text = row["AdminPassword"].ToString();
                                dtpAdminRegistrationDate.Value = Convert.ToDateTime(row["AdminRegistrationDate"]);
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

