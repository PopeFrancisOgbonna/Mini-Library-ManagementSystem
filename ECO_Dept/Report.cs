using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ECO_Dept
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        //Database connection property
        private string connectionString = @"Data Source=.;Initial Catalog=Airforce_Library;Integrated Security=true;";
        private void btnSpecific_Click(object sender, EventArgs e)
        {
            lblFrom.Visible = true;
            lblTo.Visible = true;
            frmDate.Visible = true;
            toDate.Visible = true;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            using(SqlConnection connect =new SqlConnection(connectionString))
            {
                string query = "select * from Borrow_Manual;";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataTable tbl = new DataTable();
                adapt.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
            lblFrom.Visible = false;
            lblTo.Visible = false;
            frmDate.Visible = false;
            toDate.Visible = false;
            dataGridView1.Visible = true;
        }
    }
}
