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

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserpost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginPane.Visible = true;
            btnSignin.Visible = true;
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
