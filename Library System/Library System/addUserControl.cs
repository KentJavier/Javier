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
    public partial class addUserControl : UserControl
    {
        private UserRepository userRepo;

        public addUserControl()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();

            // Use enum values for roles    
            cmbRolesAU.Items.Add(UserRole.Admin);
            cmbRolesAU.Items.Add(UserRole.Staff);
            cmbRolesAU.Items.Add(UserRole.Member);
        }

        void ClearText() 
        {
            cmbRolesAU.Text = txtFirstNameAU.Text = txtLastNameAU.Text = txtEmailAU.Text = txtUsernameAU.Text = txtPasswordAU.Text = " ";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstNameAU.Text) || String.IsNullOrEmpty(txtLastNameAU.Text) || String.IsNullOrEmpty(txtEmailAU.Text) || String.IsNullOrEmpty(txtUsernameAU.Text) || String.IsNullOrEmpty(txtPasswordAU.Text) || dtpRegistrationDateAU.Value == dtpRegistrationDateAU.MinDate || cmbRolesAU.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFirstNameAU, "Your first name is required!");
                errorProvider1.SetError(txtLastNameAU, "Your last name is required!");
                errorProvider1.SetError(txtEmailAU, "Your email is required!");
                errorProvider1.SetError(txtUsernameAU, "Your username is required!");
                errorProvider1.SetError(txtPasswordAU, "Your password is required!");
                errorProvider1.SetError(dtpRegistrationDateAU, "Please select a valid registration date!");
                errorProvider1.SetError(cmbRolesAU, "Please select a role!");
                return;
            }

            errorProvider1.Clear();

            try
            {
                UserRole selectedRole = (UserRole)cmbRolesAU.SelectedItem;
                ErrorCode res = userRepo.Register(txtFirstNameAU.Text, txtLastNameAU.Text, txtEmailAU.Text, txtUsernameAU.Text, txtPasswordAU.Text, dtpRegistrationDateAU.Value, (int)selectedRole);

                if (res == ErrorCode.Success)
                {
                    txtFirstNameAU.Clear();
                    txtLastNameAU.Clear();
                    txtEmailAU.Clear();
                    txtUsernameAU.Clear();
                    txtPasswordAU.Clear();
                    dtpRegistrationDateAU.Value = DateTime.Now;
                    cmbRolesAU.SelectedIndex = -1;

                    MessageBox.Show("A new account has been added successfully!");
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

        private void addUserControl_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cmbRolesAU;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}
