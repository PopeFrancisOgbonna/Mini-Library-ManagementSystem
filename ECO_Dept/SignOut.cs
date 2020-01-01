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
    public partial class SignOut : Form
    {
        public SignOut()
        {
            InitializeComponent();
            loadData();
            dataGridView1.Visible = true;
        }
        //Database connection property
        private string connectionString = @"Database=.;Initial Catalog=Airforce_Library;Integrated Security=true;";
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
               using (SqlConnection connect =new SqlConnection(connectionString))
                {
                    int qIn = 0;

                    string query = "insert into Borrow_Manual(SVC_No,Rank,Name,Item_Description,Qty_Out,Sign_Out,Qty_In,Qty_Bal)values(@param,@param1,@param2,@param3,@param4,@param5,@param6,@param7)";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@param", txtService.Text.Trim());
                    command.Parameters.AddWithValue("@param1", txtRank.Text.Trim());
                    command.Parameters.AddWithValue("@param2", txtName.Text.Trim());
                    command.Parameters.AddWithValue("@param3", txtItem.Text.Trim());
                    command.Parameters.AddWithValue("@param4", txtQuantity.Text.Trim());
                    command.Parameters.AddWithValue("@param5", dateTimePicker1.Value.ToShortDateString());
                    command.Parameters.AddWithValue("@param6", qIn);
                    command.Parameters.AddWithValue("@param7", txtQuantity.Text.Trim());

                    try
                    {
                        connect.Open();
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Record Saved!");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    string query = "update Borrow_Manual set SVC_No=@param,Rank=@param1,Name=@param2,Item_Description=@param3,Qty_Out=@param4 where ID=@param5";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@param", txtService.Text.Trim());
                    command.Parameters.AddWithValue("@param1", txtRank.Text.Trim());
                    command.Parameters.AddWithValue("@param2", txtName.Text.Trim());
                    command.Parameters.AddWithValue("@param3", txtItem.Text.Trim());
                    command.Parameters.AddWithValue("@param4", txtQuantity.Text.Trim());
                    command.Parameters.AddWithValue("@param5", txtID.Text.Trim());

                    try
                    {
                        connect.Open();
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Record Updated!");
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
            else
            {
                MessageBox.Show("Select a record by double clicking the Datagrid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text !="")
            {
                string query = "delete Borrow_Manual where ID=@param";
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@param", txtID.Text.Trim());
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
                txtID.Clear();
            }
            else
            {
                MessageBox.Show("Select a record by double clicking the Datagrid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadData()
        {
            SqlConnection connect = new SqlConnection(connectionString);
            string query = "select ID,SVC_No as 'Service No.',Rank,Name,Item_Description as 'Item Description',Qty_Out as 'Quantity Collected',Sign_Out as'Date Collected'from Borrow_Manual;";
            SqlCommand command = new SqlCommand(query,connect);
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataTable tbl = new DataTable();
            adapt.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtService.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRank.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtItem.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            lbliD.Visible = true;
            txtID.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            txtID.Enabled = false;
        }
    }
}
