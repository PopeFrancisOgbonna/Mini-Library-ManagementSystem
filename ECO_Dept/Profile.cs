using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECO_Dept
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            groupBox1.Visible = true;
            txtUser.Enabled = true;
            txtOldPass.Enabled = false;
            txtNewPass.Enabled = false;
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            groupBox1.Visible = true;
            txtUser.Enabled = false;
            txtNewPass.Enabled = true;
            txtOldPass.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
