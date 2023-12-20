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


namespace Library_System.Forms
{
    public partial class frmViewMember : Form
    {
        private string connectionString = "Data Source=DESKTOP-QLTR339\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True;";
        private UserRole currentUserRole;
        private string username;

        public frmViewMember(UserRole role, string username)
        {
            InitializeComponent();
            currentUserRole = role;
            this.username = username;
        }

        private void frmViewMember_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{currentUserRole} {username}";
            LoadMembersData();

            dgvMember.SelectionChanged += dgvMember_SelectionChanged;
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
        private void LoadMembersData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM vwMembers", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvMember.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Gets the MemberId
        private int GetSelectedMemberId()
        {
            if (dgvMember.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgvMember.SelectedRows[0].Cells["MemberID"].Value);
            }
            return -1;
        }

        // A function that inserts the user's input inside the DataGridView
        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("spInsertMember", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MemberFirstName", txtMemberFirstName.Text);
                        cmd.Parameters.AddWithValue("@MemberLastName", txtMemberLastName.Text);
                        cmd.Parameters.AddWithValue("@MemberEmail", txtMemberEmail.Text);
                        cmd.Parameters.AddWithValue("@MemberUsername", txtMemberUsername.Text);
                        cmd.Parameters.AddWithValue("@MemberPassword", txtMemberPassword.Text);
                        cmd.Parameters.AddWithValue("@MemberRegistrationDate", dtpMemberRegistrationDate.Value);
                        cmd.Parameters.AddWithValue("@RoleId", 1);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadMembersData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            try
            {
                int memberIdToUpdate = GetSelectedMemberId();

                if (memberIdToUpdate != -1)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("spUpdateMember", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@MemberFirstName", txtMemberFirstName.Text);
                            cmd.Parameters.AddWithValue("@MemberLastName", txtMemberLastName.Text);
                            cmd.Parameters.AddWithValue("@MemberEmail", txtMemberEmail.Text);
                            cmd.Parameters.AddWithValue("@MemberUsername", txtMemberUsername.Text);
                            cmd.Parameters.AddWithValue("@MemberPassword", txtMemberPassword.Text);
                            cmd.Parameters.AddWithValue("@MemberRegistrationDate", dtpMemberRegistrationDate.Value);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadMembersData();
                }
                else
                {
                    MessageBox.Show("Please select an member from the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Function to delete values
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            try
            {
                int memberIdToDelete = GetSelectedMemberId();

                if (memberIdToDelete != -1)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("spDeleteMember", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@MemberID", memberIdToDelete);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadMembersData();
                }
                else
                {
                    MessageBox.Show("Please select an member from the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtMemberFirstName.Text = txtMemberLastName.Text = txtMemberEmail.Text = txtMemberUsername.Text = txtMemberPassword.Text = string.Empty;
            dtpMemberRegistrationDate.Value = DateTime.Now;
        }

        private void dgvMember_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvMember.SelectedCells.Count > 0 && dgvMember.SelectedCells[0].RowIndex >= 0)
                {
                    int memberIdToUpdate = Convert.ToInt32(dgvMember.Rows[dgvMember.SelectedCells[0].RowIndex].Cells["StaffID"].Value);

                    using (var connection = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand("SELECT * FROM vwMembers WHERE MemberID = @MemberID", connection))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberIdToUpdate);

                        using (var adapter = new SqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                var row = dt.Rows[0];

                                txtMemberFirstName.Text = row["MemberFirstName"].ToString();
                                txtMemberLastName.Text = row["MemberLastName"].ToString();
                                txtMemberEmail.Text = row["MemberEmail"].ToString();
                                txtMemberUsername.Text = row["MemberUsername"].ToString();
                                txtMemberPassword.Text = row["MemberPassword"].ToString();
                                dtpMemberRegistrationDate.Value = Convert.ToDateTime(row["MemberRegistrationDate"]);
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
