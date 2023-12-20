using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class frmLogin : Form
    {
        private UserRepository userRepo;

        public frmLogin()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }
        // Opens the register form
        private void lblRegisterHere_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }
        // Logs in user to a specific role dashboard
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;

            try
            {
                if (userRepo.Authentication(username, password, out UserRole role))
                {
                    MessageBox.Show($"Login successful! Welcome to LibraLearn, {role} {username}!");
                    // Chooses what the respective dashboard of the user role that is used to login
                    switch (role)
                    {
                        case UserRole.Admin:
                            frmAdminDashboard adminDashboard = new frmAdminDashboard(UserRole.Admin, username);
                            this.Hide();
                            adminDashboard.ShowDialog();
                            this.Close();
                            break;

                        case UserRole.Staff:
                            frmStaffDashboard staffDashboard = new frmStaffDashboard(UserRole.Staff, username);
                            this.Hide();
                            staffDashboard.ShowDialog();
                            this.Close();
                            break;

                        case UserRole.Member:
                            frmMemberDashboard memberDashboard = new frmMemberDashboard();
                            this.Hide();
                            memberDashboard.ShowDialog();
                            this.Close();
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Login failed. Invalid Username/Password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        // Method to show hidden password
        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
            {
                txtPasswordLogin.UseSystemPasswordChar = false;
            }
            else 
            {
                txtPasswordLogin.UseSystemPasswordChar = true;
            }
        }
    }
}
    