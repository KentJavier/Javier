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
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{currentUserRole} {username}";

            LoadAdminsData();
        }

        // Function to switch forms
        public static class FormSwitcher
        {
            public static void SwitchToForm(Form currentForm, Form newForm)
            {
                currentForm.Hide();
                newForm.Show();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormSwitcher.SwitchToForm(this, new frmAdminDashboard(UserRole.Admin, username));
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            FormSwitcher.SwitchToForm(this, new frmViewStaff(UserRole.Admin, username));
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            FormSwitcher.SwitchToForm(this, new frmViewMember(UserRole.Admin, username));
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            FormSwitcher.SwitchToForm(this, new frmViewTransaction(UserRole.Admin, username));
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

                            // The only parameter needed for deletion is AdminID
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

        // CellClick event to populate TextBoxes
        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Handle cell click to populate TextBoxes
                int adminIdToUpdate = Convert.ToInt32(dgvAdmin.Rows[e.RowIndex].Cells["AdminID"].Value);
 
            }
        }
    }
}
