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
using static Library_System.frmAdminDashboard;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_System.Forms
{
    public partial class frmViewStaff : Form
    {
        private string connectionString = "Data Source=DESKTOP-QLTR339\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True;";
        private UserRole currentUserRole;
        private string username;

        public frmViewStaff(UserRole role, string username)
        {
            InitializeComponent();
            currentUserRole = role;
            this.username = username;
            
            dgvStaff.SelectionChanged += dgvStaff_SelectionChanged;
        }

        private void frmViewStaff_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{currentUserRole} {username}";
            LoadStaffsData();
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
        // Loads the data from the SQL using vwStaff
        private void LoadStaffsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM vwStaffs", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvStaff.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Gets the StaffId
        private int GetSelectedStaffId()
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgvStaff.SelectedRows[0].Cells["StaffID"].Value);
            }
            return -1;
        }
        // A function that inserts the user's input inside the DataGridView
        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("spInsertStaff", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@StaffFirstName", txtStaffFirstName.Text);
                        cmd.Parameters.AddWithValue("@StaffLastName", txtStaffLastName.Text);
                        cmd.Parameters.AddWithValue("@StaffEmail", txtStaffEmail.Text);
                        cmd.Parameters.AddWithValue("@StaffUsername", txtStaffUsername.Text);
                        cmd.Parameters.AddWithValue("@StaffPassword", txtStaffPassword.Text);
                        cmd.Parameters.AddWithValue("@StaffRegistrationDate", dtpStaffRegistrationDate.Value);
                        cmd.Parameters.AddWithValue("@RoleId", 1);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadStaffsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // A function that updates the values inside the DataGridView
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                int staffIdToUpdate = GetSelectedStaffId();

                if (staffIdToUpdate != -1)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("spUpdateStaff", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@StaffID", staffIdToUpdate);
                            cmd.Parameters.AddWithValue("@StaffFirstName", txtStaffFirstName.Text);
                            cmd.Parameters.AddWithValue("@StaffLastName", txtStaffLastName.Text);
                            cmd.Parameters.AddWithValue("@StaffEmail", txtStaffEmail.Text);
                            cmd.Parameters.AddWithValue("@StaffUsername", txtStaffUsername.Text);
                            cmd.Parameters.AddWithValue("@StaffPassword", txtStaffPassword.Text);
                            cmd.Parameters.AddWithValue("@StaffRegistrationDate", dtpStaffRegistrationDate.Value);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadStaffsData();
                }
                else
                {
                    MessageBox.Show("Please select an staff from the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Function to delete values
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                int staffIdToDelete = GetSelectedStaffId();

                if (staffIdToDelete != -1)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("spDeleteStaff", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@StaffID", staffIdToDelete);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadStaffsData();
                }
                else
                {
                    MessageBox.Show("Please select an staff from the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtStaffFirstName.Text = txtStaffLastName.Text = txtStaffEmail.Text = txtStaffUsername.Text = txtStaffPassword.Text = string.Empty;
            dtpStaffRegistrationDate.Value = DateTime.Now;
        }


        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvStaff.SelectedCells.Count > 0 && dgvStaff.SelectedCells[0].RowIndex >= 0)
                {
                    int staffIdToUpdate = Convert.ToInt32(dgvStaff.Rows[dgvStaff.SelectedCells[0].RowIndex].Cells["StaffID"].Value);

                    using (var connection = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand("SELECT * FROM vwStaffs WHERE StaffID = @StaffID", connection))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", staffIdToUpdate);

                        using (var adapter = new SqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                var row = dt.Rows[0];

                                txtStaffFirstName.Text = row["StaffFirstName"].ToString();
                                txtStaffLastName.Text = row["StaffLastName"].ToString();
                                txtStaffEmail.Text = row["StaffEmail"].ToString();
                                txtStaffUsername.Text = row["StaffUsername"].ToString();
                                txtStaffPassword.Text = row["StaffPassword"].ToString();
                                dtpStaffRegistrationDate.Value = Convert.ToDateTime(row["StaffRegistrationDate"]);
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
