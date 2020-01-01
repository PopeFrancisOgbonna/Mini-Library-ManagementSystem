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
    public partial class DbBackup : Form
    {
        public DbBackup()
        {
            InitializeComponent();
        }
        //Database connection property
        private string connectionString = @"Data Source=.;Initial Catalog=Airforce_Library;Integrated Security=true;";
        private void btnBackup_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string day = date.Day + "_" + date.Month;
            //create a Folder to backup our files
            string dir = @"C:\AirForce_Database";
            if (!Directory.Exists(dir)) // creates the directory if it doesn't exist
            {
                Directory.CreateDirectory(dir);
            }
            //Database
            string Db = "Airforce_Library";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    string str = "USE " + Db + ";";
                    string query = "BACKUP DATABASE " + Db + " TO DISK='C:\\AirForce_Database\\" + Db + "_" + day + ".Bak' WITH FORMAT,MEDIANAME='Z_SQLServerBackups of" + Db + "';";
                    SqlCommand command = new SqlCommand(str, connect);
                    SqlCommand command1 = new SqlCommand(query, connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Backup completed Successfully","Database Backup",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

        }
    }
}
