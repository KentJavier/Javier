using Library_System.AppData;
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
    public partial class frmAdminDashboard : Form
    {

        private UserRepository userRepo;
        private UserRole currentUserRole;
        private string username;

        public frmAdminDashboard(UserRole userRole, string username)
        {
            InitializeComponent();
       
            userRepo = new UserRepository();
            currentUserRole = userRole;
            this.username = username;
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            addUserControl.Show();
            adminControl.Hide();
            staffControl.Hide();
            memberControl.Hide();
            transactionControl.Hide();

            // Set the label text based on the current user
            lblUsernameProfile.Text = $"{currentUserRole} {username}";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addUserControl.Show();
            adminControl.Hide();
            staffControl.Hide();
            memberControl.Hide();
            transactionControl.Hide();

            addUserControl.Show();
            addUserControl.BringToFront();
        }

        private void btnAdminsMenu_Click(object sender, EventArgs e)
        {
            addUserControl.Show();
            staffControl.Hide();
            memberControl.Hide();
            transactionControl.Hide();

            adminControl.Show();
            adminControl.BringToFront();
        }

        private void btnStaffMenu_Click(object sender, EventArgs e)
        {
            addUserControl.Show();
            adminControl.Hide();
            memberControl.Hide();
            transactionControl.Hide();

            staffControl.Show();
            staffControl.BringToFront();
        }

        private void btnMemberMenu_Click(object sender, EventArgs e)
        {
            addUserControl.Show();
            adminControl.Hide();
            staffControl.Hide();
            transactionControl.Hide();

            memberControl.Show();
            memberControl.BringToFront();
        }

        private void btnTransactionMenu_Click(object sender, EventArgs e)
        {
            addUserControl.Show();
            adminControl.Hide();
            staffControl.Hide();
            memberControl.Hide();

            transactionControl.Show();
            transactionControl.BringToFront();
        }


    }
}
