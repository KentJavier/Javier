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
    public partial class frmRegister : Form
    {
        private UserRepository userRepo;
        private System.Windows.Forms.ErrorProvider errorProvider1 = new System.Windows.Forms.ErrorProvider();

        public frmRegister()
        {
            InitializeComponent();

            userRepo = new UserRepository();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text)) 
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFirstName, "Your first name is required!");
                return;
            }

            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtLastName, "Your last name is required!");
                return;
            }

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Your email is required!");
                return;
            }

            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtUsername, "Your username is required!");
                return;
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Your password is required!");
                return;
            }

            if (dtpRegistrationDate.Value == dtpRegistrationDate.MinDate)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(dtpRegistrationDate, "Please select a valid registration date!");
                return;
            }

            if (cmbRoles.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbRoles, "Please select a role!");
                return;
            }

            errorProvider1.Clear();

            ErrorCode res = userRepo.Register(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text, dtpRegistrationDate.Value, cmbRoles.SelectedIndex);
            if (res == ErrorCode.Success)
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                dtpRegistrationDate.Value = DateTime.Now;
                cmbRoles.SelectedIndex = -1;

                MessageBox.Show("Account Registered succesfully!");
            }
            else 
            {
                MessageBox.Show("Error. Account registration failed.");
            }

        }
    }
}
