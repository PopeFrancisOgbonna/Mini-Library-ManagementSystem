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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        public static string user;
        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            user = txtUsername.Text;
        }

        private void txtUserpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserpost_TextChanged(object sender, EventArgs e)
        {
            if (txtUserpost.Text != "")
            {
                btnSignin.Visible = true;
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {   // Checks user expected inputs are not left out
            if (txtUsername.Text == "" || txtUserpost.Text == "" || txtUserpass.Text == "")
            {
                MessageBox.Show("Please fill out all Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Home home = new Home();
                home.lblUser.Text = user;
                home.userPass = txtUserpass.Text;
                home.ShowDialog();
                txtUserpass.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginPane.Visible = true;
            btnSignin.Visible = false;
            btnCancel.Visible = true;
            homePane.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            homePane.Visible = true;
            loginPane.Visible = false;
            btnSignin.Visible = false;
            btnCancel.Visible = false;
        }
    }
}
