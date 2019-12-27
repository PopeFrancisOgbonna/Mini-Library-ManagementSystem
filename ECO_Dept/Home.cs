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
            lblUser.Text = "Pope Francis Ogbonna";
            lblTab.Height = btnDash.Height;
            lblTab.Top = btnDash.Top;
        }

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
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            lblTab.Height = btnIn.Height;
            lblTab.Top = btnIn.Top;
        }

        private void toolSearch_Click(object sender, EventArgs e)
        {

        }

        private void toolReport_Click(object sender, EventArgs e)
        {

        }

        private void toolAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }
    }
}
