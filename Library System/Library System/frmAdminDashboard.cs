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
        private String username;

        public frmAdminDashboard(UserRole userRole, string username)
        {
            InitializeComponent();
            userRepo = new UserRepository();
            currentUserRole = userRole;
            this.username = username; 
        }

        private void fmrAdminDashboard_Load(object sender, EventArgs e)
        {
            lblProfileName.Text = $"{currentUserRole} {username}";

            this.ActiveControl = btnViewAdmin;

            adminControl.Show();
            staffControl.Hide();
            memberControl.Hide();
            transactionControl.Hide();
        }

        private void btnViewAdmin_Click(object sender, EventArgs e)
        {
            staffControl.Hide();
            memberControl.Hide();
            transactionControl.Hide();

            adminControl.Show();
            adminControl.BringToFront();
        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            adminControl.Hide();
            memberControl.Hide();
            transactionControl.Hide();

            staffControl.Show();
            staffControl.BringToFront();
        }

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            adminControl.Hide();
            staffControl.Hide();
            transactionControl.Hide();

            memberControl.Show();
            memberControl.BringToFront();
        }

        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            adminControl.Hide();
            staffControl.Hide();
            memberControl.Hide();

            transactionControl.Show();
            transactionControl.BringToFront();
        }
    }
}
