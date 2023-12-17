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
    public partial class staffControl : UserControl
    {
        Staffs newStaff = new Staffs();
        public staffControl()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dgvStaffs.AutoGenerateColumns = false;
            using (LibrarySystemEntities db = new LibrarySystemEntities())
            {
                dgvStaffs.DataSource = db.vwStaffs.ToList<vwStaffs>();
            }
        }
        private void staffControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaffs.SelectedRows.Count > 0)
            {
                int memberId = Convert.ToInt32(dgvStaffs.SelectedRows[0].Cells["dgStaffId"].Value);

                using (LibrarySystemEntities db = new LibrarySystemEntities())
                {
                    Staffs staffToDelete = db.Staffs.Find(memberId);

                    if (staffToDelete != null)
                    {
                        db.Staffs.Remove(staffToDelete);
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
