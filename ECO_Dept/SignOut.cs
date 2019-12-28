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
    public partial class SignOut : Form
    {
        public SignOut()
        {
            InitializeComponent();
        }

        private void txtService_TextChanged(object sender, EventArgs e)
        {
            if (txtService.Text != "")
            {
                btnClear.Visible = true;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                btnSave.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItem.Clear();
            txtName.Clear();
            txtQuantity.Clear();
            txtRank.Clear();
            txtService.Clear();
            txtID.Clear();
            txtID.Visible = false;
            lbliD.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItem.Text == "" || txtName.Text == "" || txtQuantity.Text == "" || txtRank.Text == "" || txtService.Text == "")
            {
                MessageBox.Show("Please fill out all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Saved");
            }
        }
    }
}
