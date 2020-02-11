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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
        public string oldpass;//holds old password
        public string service;//holds service number 
        //Database connection property
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Airforce_Library.mdf;Integrated Security=True;Connect Timeout=30;";
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            groupBox1.Visible = true;
            txtUser.Enabled = true;
            txtOldPass.Enabled = false;
            txtNewPass.Enabled = false;
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            groupBox1.Visible = true;
            txtUser.Enabled = false;
            txtNewPass.Enabled = true;
            txtOldPass.Enabled = true;
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUser.Enabled)
            {
                if (txtUser.Text == "")
                {
                    MessageBox.Show("Please Enter a new user name");
                }
                else
                {
                    using (SqlConnection connect=new SqlConnection(connectionString))
                    {
                        string query = "update users set UserName=@param where SVC_No=@param1";
                        SqlCommand command = new SqlCommand(query, connect);
                        command.Parameters.AddWithValue("@param", txtUser.Text.Trim());
                        command.Parameters.AddWithValue("@param1", service);
                        try
                        {
                            connect.Open();
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Username Changed Successfully.");
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
            else
            {
                if (txtOldPass.Text != oldpass || txtNewPass.Text == "")
                {
                    MessageBox.Show("Ensure your Old password is correct and Enter a New one", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        string query = "update users set Password=@param where SVC_No=@param1";
                        SqlCommand command = new SqlCommand(query, connect);
                        command.Parameters.AddWithValue("@param", txtNewPass.Text.Trim());
                        command.Parameters.AddWithValue("@param1", service);
                        try
                        {
                            connect.Open();
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Password Changed Successfully.");
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
        }
    }
}
