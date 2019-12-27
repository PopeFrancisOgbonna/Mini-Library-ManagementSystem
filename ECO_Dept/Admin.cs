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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
        }

        private void txtService_TextChanged(object sender, EventArgs e)
        {
            if(txtService.Text != "") { btnClear.Visible = true; }
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            if(txtRole.Text != "") { btnSave.Visible = true; }
        }
    }
}
