using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ECO_Dept
{
    public partial class Restore_DB : Form
    {
        public Restore_DB()
        {
            InitializeComponent();
        }
        //Database property
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Airforce_Library.mdf;Integrated Security=True;Connect Timeout=30;";
        private void btnRestore_Click(object sender, EventArgs e)
        {
            string database = "Airforce_Library";
            if (txtFile.Text == "")
            {
                MessageBox.Show("Please choose a Backup File", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using(SqlConnection connect =new SqlConnection(connectionString))
                {
                    string query = "USE master;";
                    string query1 = "ALTER DATABASE " + database + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    string query2 = "RESTORE DATABASE " + database + " FROM DISK='" + txtFile.Text + "' WITH REPLACE";
                    string query3 = "ALTER DATABASE " + database + " set MULTI_USER with NO_WAIT;";

                    SqlCommand command = new SqlCommand(query, connect);
                    SqlCommand command1 = new SqlCommand(query1, connect);
                    SqlCommand command2 = new SqlCommand(query2, connect);
                    SqlCommand command3 = new SqlCommand(query3, connect);
                    try
                    {
                        connect.Open();
                        //the code below sets the database to a single user mode to disable incoming commands from other users 
                        //and restores the database backup files
                        command.ExecuteNonQuery();
                        command1.ExecuteNonQuery();
                        command2.ExecuteNonQuery();

                        //The code below restores the Database to multi user mode 
                        command.ExecuteNonQuery();
                        command3.ExecuteNonQuery();
                        MessageBox.Show("Database Restored Successfull, Please Reload Application", "Data Restored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = @"C:\";
            file.Title = "Browse Backup file";
            file.CheckFileExists = true;
            file.CheckPathExists = true;
            file.DefaultExt = "BAK";
            file.Filter = "Text Files(*.bak)|*.bak";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.ReadOnlyChecked = true;
            file.ShowReadOnly = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = file.FileName;
            }
        }
    }
}
