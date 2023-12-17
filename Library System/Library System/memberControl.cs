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
    public partial class memberControl : UserControl
    {
        Members mewMember = new Members();
        public memberControl()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            dgvMembers.AutoGenerateColumns = false;
            using (LibrarySystemEntities db = new LibrarySystemEntities())
            {
                dgvMembers.DataSource = db.vwMembers.ToList<vwMembers>();
            }
        }
        private void memberControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                int memberId = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["dgMemberId"].Value);

                using (LibrarySystemEntities db = new LibrarySystemEntities())
                {
                    Members memberToDelete = db.Members.Find(memberId);

                    if (memberToDelete != null)
                    {
                        db.Members.Remove(memberToDelete);
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
