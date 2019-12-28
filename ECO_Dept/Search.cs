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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            txtName.Visible = true;
            btnSearch.Visible = false; 
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtName.Visible = false;
            btnSearch.Visible = false;
        }

        private void btnBorrowed_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtName.Visible = false;
            btnSearch.Visible = false;
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtName.Visible = false;
            btnSearch.Visible = false;
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtName.Visible = false;
            btnSearch.Visible = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
        }
    }
}
