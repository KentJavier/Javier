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

        public frmRegister()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();

            // Use enum values for roles    
            cmbRoles.Items.Add(UserRole.Admin);
            cmbRoles.Items.Add(UserRole.Staff);
            cmbRoles.Items.Add(UserRole.Member);
        }
        // Provides error warning if textbox is blank, also sends the user info to the sql table
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text) || dtpRegistrationDate.Value == dtpRegistrationDate.MinDate || cmbRoles.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFirstName, "Your first name is required!");
                errorProvider1.SetError(txtLastName, "Your last name is required!");
                errorProvider1.SetError(txtEmail, "Your email is required!");
                errorProvider1.SetError(txtUsername, "Your username is required!");
                errorProvider1.SetError(txtPassword, "Your password is required!");
                errorProvider1.SetError(dtpRegistrationDate, "Please select a valid registration date!");
                errorProvider1.SetError(cmbRoles, "Please select a role!");
                return;
            }

            errorProvider1.Clear();

            try
            {
                UserRole selectedRole = (UserRole)cmbRoles.SelectedItem;
                ErrorCode res = userRepo.Register(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text, dtpRegistrationDate.Value, (int)selectedRole);

                if (res == ErrorCode.Success)
                {
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtEmail.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    dtpRegistrationDate.Value = DateTime.Now;
                    cmbRoles.SelectedIndex = -1;

                    MessageBox.Show("Account Registered successfully!");
                }
                else
                {
                    MessageBox.Show("Error. Account registration failed. ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cmbRoles;
        }

    }
}