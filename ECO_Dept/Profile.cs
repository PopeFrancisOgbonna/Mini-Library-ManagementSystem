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
        public string oldpass;
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
            if (txtUser.Enabled)
            {
                if (txtUser.Text == "")
                {
                    MessageBox.Show("Please Enter a new user name");
                }
                else
                { 
                MessageBox.Show("user Name Changed");
                }
            }
            else
            {
                if (txtOldPass.Text != oldpass || txtNewPass.Text == "")
                {
                    MessageBox.Show("Ensure your Old password is correct and Enter a New one", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Password Changd");
                }
            }
        }
    }
}
