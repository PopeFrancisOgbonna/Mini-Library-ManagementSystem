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
        public  string userPass; //holds password
        public string homeRole;//holds user database role
        public string uName;//Holds the Name of User(not username)
        public string service;//holds he service number
        
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
            pro.service = service;
            pro.lblName.Text = uName;
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
            Report report = new Report();
            report.ShowDialog();
        }

        private void toolAdmin_Click(object sender, EventArgs e)
        {
            if (homeRole.ToLower() != "admin")
            {
                MessageBox.Show("You don't have Admin Right", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Admin admin = new Admin();
                admin.ShowDialog();
            }
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

        private void toolDatabaseBackup_Click(object sender, EventArgs e)
        {
            if (homeRole.ToLower() != "admin")
            {
                MessageBox.Show("You don't have Admin Right", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DbBackup backup = new DbBackup();
                backup.ShowDialog();
            }
        }

        private void toolRestore_Click(object sender, EventArgs e)
        {
            if (homeRole.ToLower() != "admin")
            {
                MessageBox.Show("You don't have Admin Right", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("To avoid Data loss please contact the IT Personnel", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Restore_DB restore = new Restore_DB();
                //restore.ShowDialog();
            }
        }
    }
}
