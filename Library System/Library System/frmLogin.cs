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

        private void lblRegisterHere_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;

            if (userRepo.Authentication(username, password, out UserRole role))
            {
                MessageBox.Show($"Login successful! Welcome to LibraLearn, {role} {username}!");
            }
            else
            {
                MessageBox.Show("Login failed. Invalid Username/Password.");
            }
        }

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
