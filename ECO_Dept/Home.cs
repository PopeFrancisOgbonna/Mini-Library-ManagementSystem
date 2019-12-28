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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timer1.Start();
            lblTab.Height = btnDash.Height;
            lblTab.Top = btnDash.Top;
        }
        public  string userPass;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            lblTab.Height = btnProfile.Height;
            lblTab.Top = btnProfile.Top;

            Profile pro = new Profile();
            pro.oldpass = userPass;
            pro.lblUserName.Text ="Username: "+ lblUser.Text;
            pro.ShowDialog();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            lblTab.Height = btnDash.Height;
            lblTab.Top = btnDash.Top;
        }

        private void btnManualReg_Click(object sender, EventArgs e)
        {
            lblTab.Height = btnManualReg.Height;
            lblTab.Top = btnManualReg.Top;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            lblTab.Height = btnOut.Height;
            lblTab.Top = btnOut.Top;
            SignOut manualOut = new SignOut();
            manualOut.ShowDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            lblTab.Height = btnIn.Height;
            lblTab.Top = btnIn.Top;
            SignIn manualIn = new SignIn();
            manualIn.ShowDialog();
        }

        private void toolSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }

        private void toolReport_Click(object sender, EventArgs e)
        {

        }

        private void toolAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This software is designed by Xpress SoftwareLab for the ECO wing to manage Traning Manual Library.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For help contact the ECO Supervisor or Xpress SoftwareLab. Tel: +2347031620728  Email: xpressdreams.ng@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
