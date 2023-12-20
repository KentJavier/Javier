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
using static Library_System.frmAdminDashboard;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_System.Forms
{
    public partial class frmViewTransaction : Form
    {
        private LibrarySystemEntities db;
        private UserRole currentUserRole;
        private string username;

        public frmViewTransaction(UserRole role, string username)
        {
            InitializeComponent();
            currentUserRole = role;
            this.username = username;
        }

        private void frmViewTransaction_Load(object sender, EventArgs e)
        {

            lblUsername.Text = $"{currentUserRole} {username}";
        }

        // Function to switch forms

        private void btnStaff_Click(object sender, EventArgs e)
        {
            // Check if the form is already open
            Form frm = Application.OpenForms[nameof(frmViewStaff)];

            if (frm != null)
            {
                // If the form is already open, bring it to the front
                frm.BringToFront();
            }
            else
            {
                // If the form is not open, create a new instance
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
                // If the form is already open, bring it to the front
                frm.BringToFront();
            }
            else
            {
                // If the form is not open, create a new instance
                frmViewMember viewMember = new frmViewMember(UserRole.Admin, username);
                viewMember.Show();
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            // Check if the form is already open
            Form frm = Application.OpenForms[nameof(frmViewTransaction)];

            if (frm != null)
            {
                // If the form is already open, bring it to the front
                frm.BringToFront();
            }
            else
            {
                // If the form is not open, create a new instance
                frmViewTransaction viewTransaction = new frmViewTransaction(UserRole.Admin, username);
                viewTransaction.Show();
            }
        }

    }
}
