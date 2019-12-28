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
        int count; //for switching the edit user role modules
        private void lblEdit_Click(object sender, EventArgs e)
        {
           
            if (count == 1)
            {
                dataGridView1.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                count -= 1;
            }
            else{
                dataGridView1.Visible = true;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                count += 1;
            }
        }

        private void txtService_TextChanged(object sender, EventArgs e)
        {
            if(txtService.Text != "") { btnClear.Visible = true; }
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            if(txtRole.Text != "") { btnSave.Visible = true; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPost.Clear();
            txtRank.Clear();
            txtRole.Clear();
            txtService.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPost.Text == "" || txtRank.Text == "" || txtRole.Text == "" || txtService.Text == "")
            {
                MessageBox.Show("Please fill out all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("confirmed!");
            }
        }
    }
}
