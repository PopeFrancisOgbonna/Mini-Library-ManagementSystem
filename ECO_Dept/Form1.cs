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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        public static string user;//Holds the username
        public static string role;
        public static string name;
        //Database properties
        private string connectionString = @"Database=.;Initial Catalog=Airforce_Library;Integrated Security=true";
        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            user = txtUsername.Text.ToUpper();
        }

        private void txtUserpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserpost_TextChanged(object sender, EventArgs e)
        {
            if (txtUserpost.Text != "")
            {
                btnSignin.Visible = true;
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {   // Checks user expected inputs are not left out
            if (txtUsername.Text == "" || txtUserpost.Text == "" || txtUserpass.Text == ""||txtServiceNo.Text=="")
            {
                MessageBox.Show("Please fill out all Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect=new SqlConnection(connectionString))
                {
                    string role = null;
                    string userName = null;
                    string pass = null;
                    string query = "select Role,UserName,Password,Name from users where SVC_No=@param";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@param", txtServiceNo.Text.Trim());
                    try
                    {
                        connect.Open();
                        SqlDataReader read = command.ExecuteReader();
                        if (read.Read())
                        {
                            role = read[0].ToString();
                            userName = read[1].ToString();
                            pass = read[2].ToString();
                            name = read[3].ToString();
                            read.Close();
                            connect.Close();
                            if (userName.ToUpper() == txtUsername.Text.Trim().ToUpper() && pass.ToUpper() == txtUserpass.Text.Trim().ToUpper())
                            {
                                Home home = new Home();
                                home.lblUser.Text = user;
                                home.homeRole = role;
                                home.uName = name;
                                home.service = txtServiceNo.Text.Trim();
                                home.userPass = txtUserpass.Text;
                                home.ShowDialog();
                                txtUserpass.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username and Password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Acess Denied, Please contact the ECO Supervisor", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                } 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginPane.Visible = true;
            btnSignin.Visible = false;
            btnCancel.Visible = true;
            homePane.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            homePane.Visible = true;
            loginPane.Visible = false;
            btnSignin.Visible = false;
            btnCancel.Visible = false;
        }
    }
}
