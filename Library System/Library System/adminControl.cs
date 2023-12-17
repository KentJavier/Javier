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
    public partial class adminControl : UserControl
    {
        Admins newAdmin = new Admins();

        public adminControl()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            dgvAdmins.AutoGenerateColumns = false;
            using (LibrarySystemEntities db = new LibrarySystemEntities())
            {
                dgvAdmins.DataSource = db.vwAdmins.ToList<vwAdmins>();
            }
        }
        private void adminControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count > 0)
            {
                int adminId = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["dgAdminId"].Value);

                using (LibrarySystemEntities db = new LibrarySystemEntities())
                {
                    Admins adminToDelete = db.Admins.Find(adminId);

                    if (adminToDelete != null)
                    {
                        db.Admins.Remove(adminToDelete);
                        db.SaveChanges();
                        LoadData(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
