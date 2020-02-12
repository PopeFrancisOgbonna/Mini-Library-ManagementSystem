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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        int count; //for switching the edit user role modules
        //Database connection properties
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Airforce_Library.mdf;Integrated Security=True;Connect Timeout=30";
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
                loadData();
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                count += 1;
            }
        }

        private void txtService_TextChanged(object sender, EventArgs e)
        {
            if(txtService.Text != "")
            {
                btnClear.Visible = true;
            }
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
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPost.Text == "" || txtRank.Text == "" || txtRole.Text == "" || txtService.Text == "")
            {
                MessageBox.Show("Please fill out all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    try
                    {
                        string pass = "12345";
                        string query = "insert into users values(@param,@param1,@param2,@param3,@param4,@param5,@param6)";
                        SqlCommand command = new SqlCommand(query, connect);
                        command.Parameters.AddWithValue("@param", txtService.Text.Trim());
                        command.Parameters.AddWithValue("@param1", txtRank.Text.Trim()); 
                        command.Parameters.AddWithValue("@param2", txtName.Text.Trim());
                        command.Parameters.AddWithValue("@param3", txtPost.Text.Trim());
                        command.Parameters.AddWithValue("@param4", txtRole.Text.Trim());
                        command.Parameters.AddWithValue("@param5", txtName.Text.Trim());
                        command.Parameters.AddWithValue("@param6", pass);

                        connect.Open();
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Record Saved Successfully");
                            loadData();
                            dataGridView1.Visible = true;
                        }
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }
        private void loadData()
        {
            SqlConnection connect = new SqlConnection(connectionString);
            string query = "select user_ID as 'ID',SVC_No as 'Service No',Rank,Name,Post,Role from users";
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataTable tbl = new DataTable();
            adapt.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }
        int id=0;//Variable to hold the id of record to be updated or deleted
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtService.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRank.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtName.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPost.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtRole.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                string query="update users set SVC_No=@param,Rank=@param1,Name=@param2,Post=@param3,Role=@param4 where user_ID=@param5";
                using(SqlConnection connect=new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@param", txtService.Text.Trim());
                    command.Parameters.AddWithValue("@param1", txtRank.Text.Trim());
                    command.Parameters.AddWithValue("@param2", txtName.Text.Trim());
                    command.Parameters.AddWithValue("@param3", txtPost.Text.Trim());
                    command.Parameters.AddWithValue("@param4", txtRole.Text.Trim());
                    command.Parameters.AddWithValue("@param5", id);
                    try
                    {
                        connect.Open();
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Record Updated Successfully");
                            loadData();
                            dataGridView1.Visible = true;
                        }
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                id = 0;
            }
            else
            {
                MessageBox.Show("Select a record by double clicking the Datagrid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                string query = "delete users where user_ID=@param";
                using (SqlConnection connect=new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@param", id);
                    try
                    {
                        connect.Open();
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Record Deleted Successfully");
                            loadData();
                            dataGridView1.Visible = true;
                        }
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                id = 0;
            }
            else
            {
                MessageBox.Show("Select a record by double clicking the Datagrid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
