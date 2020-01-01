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
        string connectionString = @"Data Source=.;Initial Catalog=Airforce_Library;Integrated Security=true;";
        private void btnRestore_Click(object sender, EventArgs e)
        {
            string database = "Airforce_Library";
            if (txtFile.Text != "")
            {

            }
            else
            {
                using(SqlConnection connect =new SqlConnection(connectionString))
                {
                    string query = "USE master;";
                    string query1 = "ALTER DATABASE " + database + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    string query2 = "RESTORE DATABASE " + database + " FROM DISK='" + txtFile.Text + "' WITH REPLACE";

                    SqlCommand command = new SqlCommand(query, connect);
                    SqlCommand command1 = new SqlCommand(query1, connect);
                    SqlCommand command2 = new SqlCommand(query2, connect);
                    try
                    {
                        connect.Open();
                        command.ExecuteNonQuery();
                        command1.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
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
