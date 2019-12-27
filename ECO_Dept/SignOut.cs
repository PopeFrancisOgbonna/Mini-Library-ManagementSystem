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
        }
    }
}
