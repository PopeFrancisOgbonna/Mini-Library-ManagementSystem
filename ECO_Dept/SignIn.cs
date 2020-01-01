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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            getBorrowedManual();
            dataGridView1.Visible = true;
            lblID.Visible = true;
            txtID.Visible = true;
        }
        //Database connection properties
        private string connectionString = @"Data Source=.;Initial Catalog=Airforce_Library;Integrated Security=true;";
        private void txtService_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {
            if (txtRemark.Text != "" && btnUpdateIn.Visible == false)
            {
                btnSaveIn.Visible = true;
            }
        }

        private void btnClearIn_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSaveIn_Click(object sender, EventArgs e)
        {
            if (txtRemain.Text == "" || txtRemark.Text == "" || txtReturned.Text == "")
            {
                MessageBox.Show("Please fill all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtID.Text != "")
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        string query = "update Borrow_Manual set Qty_In=@param,Qty_Bal=@param1,Sign_In=@param2,Remark=@param3 where ID=@param4";
                        SqlCommand command = new SqlCommand(query, connect);
                        command.Parameters.AddWithValue("@param", txtQuantityIn.Text.Trim());
                        command.Parameters.AddWithValue("@param1", txtRemain.Text.Trim());
                        command.Parameters.AddWithValue("@param2", dateTimePicker1.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@param3", txtRemark.Text.Trim());
                        command.Parameters.AddWithValue("@param4", txtID.Text.Trim());

                        try
                        {
                            connect.Open();
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Rceived.");
                                getBorrowedManual();
                            }
                            connect.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                        clearAll();
                    }
                }
                else
                {
                    MessageBox.Show("Select a record by double clicking the Datagrid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtReturned_TextChanged(object sender, EventArgs e)
        {
            if (txtReturned.Text != "")
            {
                btnClearIn.Visible = true;
            }
        }

        private void btnUpdateIn_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    string query = "update Borrow_Manual set Qty_In=@param,Qty_Bal=@param1,Sign_In=@param2,Remark=@param3 where ID=@param4";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@param", txtQuantityIn.Text.Trim());
                    command.Parameters.AddWithValue("@param1",txtRemain.Text.Trim());
                    command.Parameters.AddWithValue("@param2", dateTimePicker1.Value.ToShortDateString());
                    command.Parameters.AddWithValue("@param3", txtRemark.Text.Trim());
                    command.Parameters.AddWithValue("@param4",txtID.Text.Trim());

                    try
                    {
                        connect.Open();
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Record Updated!");
                            getReturnedItems();
                        }
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Select a record by double clicking the Datagrid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getBorrowedManual()
        {
            using(SqlConnection connect =new SqlConnection(connectionString))
            {
                string query = "select ID, SVC_No as 'Service No.',Name,Item_Description as 'Item Collected',Qty_Out as 'Quantity Collected'from Borrow_Manual where Qty_In !=Qty_Out;";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataTable tbl = new DataTable();
                adapt.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtServiceIn.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNameIn.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtItemIn.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtQuantityIn.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (btnUpdateIn.Visible)
            {
                txtReturned.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtRemain.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtRemark.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtID.Visible = true;
            lblID.Visible = true;
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            getReturnedItems();
            btnUpdateIn.Visible = true;
            btnSaveIn.Visible = false;
            btnAdd.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSaveIn.Visible = true;
            btnUpdateIn.Visible = false;
            getBorrowedManual();
        }
        private void getReturnedItems()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select ID, SVC_No as 'Service No.',Name,Item_Description as 'Item Collected',Qty_Out as 'Quantity Collected',Qty_In as 'Quantity Returned',Qty_Bal as 'Item Remaining',Sign_In as 'Date',Remark from Borrow_Manual where Qty_In !=0;";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataTable tbl1 = new DataTable();
                adapt.Fill(tbl1);
                dataGridView1.DataSource = tbl1;
            }
        }
        private void clearAll()
        {
            txtItemIn.Clear();
            txtNameIn.Clear();
            txtQuantityIn.Clear();
            txtRemain.Clear();
            txtRemark.Clear();
            txtReturned.Clear();
            txtServiceIn.Clear();
            txtID.Clear();
            txtID.Visible = false;
            lblID.Visible = false;
        }
    }
}
