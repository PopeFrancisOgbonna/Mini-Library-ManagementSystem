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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        //Database connection property
        private string connectionString = @"Data Source=.;Initial Catalog=Airforce_Library;Integrated Security=true;";
        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            txtName.Visible = true;
            btnSearch.Visible = false;
            txtName.Clear();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            getAllRecords();
            label2.Visible = false;
            txtName.Visible = false;
            btnSearch.Visible = false;
        }

        private void btnBorrowed_Click(object sender, EventArgs e)
        {
            borrowedManual();
            label2.Visible = false;
            txtName.Visible = false;
            btnSearch.Visible = false;
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            returnedManual();
            label2.Visible = false;
            txtName.Visible = false;
            btnSearch.Visible = false;
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            pendingManual();
            label2.Visible = false;
            txtName.Visible = false;
            btnSearch.Visible = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
        }
        private void getAllRecords()
        {
            using(SqlConnection connect =new SqlConnection(connectionString))
            {
                string query = "select ID,SVC_No as 'Service No.',Rank,Name,Item_Description as 'Item Description',Qty_Out as 'Quantity Collected',Sign_Out as 'Date Collected',Qty_In as 'Quantity Returned',Qty_Bal as 'Quantity Remaining',Sign_In as 'Date Returned',Remark from Borrow_Manual;";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataTable tbl = new DataTable();
                adapt.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
        }
        private void borrowedManual()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select ID,SVC_No as 'Service No.',Rank,Name,Item_Description as 'Item Description',Qty_Out as 'Quantity Collected',Sign_Out as 'Date Collected',Qty_In as 'Quantity Returned',Qty_Bal as 'Quantity Remaining',Sign_In as 'Date Returned',Remark from Borrow_Manual where Qty_In=0";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataTable tbl1 = new DataTable();
                adapt.Fill(tbl1);
                dataGridView1.DataSource = tbl1;
            }
        }
        private void returnedManual()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select ID,SVC_No as 'Service No.',Rank,Name,Item_Description as 'Item Description',Qty_Out as 'Quantity Collected',Sign_Out as 'Date Collected',Qty_In as 'Quantity Returned',Qty_Bal as 'Quantity Remaining',Sign_In as 'Date Returned',Remark from Borrow_Manual where Qty_Bal=0";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataTable tbl2 = new DataTable();
                adapt.Fill(tbl2);
                dataGridView1.DataSource = tbl2;
            }
        }
        private void pendingManual()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select ID,SVC_No as 'Service No.',Rank,Name,Item_Description as 'Item Description',Qty_Out as 'Quantity Collected',Sign_Out as 'Date Collected',Qty_In as 'Quantity Returned',Qty_Bal as 'Quantity Remaining',Sign_In as 'Date Returned',Remark from Borrow_Manual where Qty_Bal>0;";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataTable tbl3 = new DataTable();
                adapt.Fill(tbl3);
                dataGridView1.DataSource = tbl3;
            }
        }
        private void personnel()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select ID,SVC_No as 'Service No.',Rank,Name,Item_Description as 'Item Description',Qty_Out as 'Quantity Collected',Sign_Out as 'Date Collected',Qty_In as 'Quantity Returned',Qty_Bal as 'Quantity Remaining',Sign_In as 'Date Returned',Remark from Borrow_Manual where lower(SVC_No)=@param";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@param", txtName.Text.Trim().ToLower());
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataTable tbl4 = new DataTable();
                adapt.Fill(tbl4);
                dataGridView1.DataSource = tbl4;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            personnel();
        }
    }
}
