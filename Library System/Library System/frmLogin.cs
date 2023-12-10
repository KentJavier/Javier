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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblRegisterHere_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();

            this.Hide();

            registerForm.ShowDialog();

            this.Close();
        }
    }
}
