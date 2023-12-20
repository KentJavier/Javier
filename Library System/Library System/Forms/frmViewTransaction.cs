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

        private void frmViewStaff_Load(object sender, EventArgs e)
        {
            FormSwitcher.SwitchToForm(this, new frmViewStaff(UserRole.Admin, username));
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            FormSwitcher.SwitchToForm(this, new frmViewTransaction(UserRole.Admin, username));
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormSwitcher.SwitchToForm(this, new frmAdminDashboard(UserRole.Admin, username));
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            FormSwitcher.SwitchToForm(this, new frmViewStaff(UserRole.Admin, username));
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            FormSwitcher.SwitchToForm(this, new frmViewMember(UserRole.Admin, username));
        }
    }
}
