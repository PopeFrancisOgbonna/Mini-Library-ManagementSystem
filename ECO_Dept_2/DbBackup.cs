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
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Airforce_Library.mdf;Integrated Security=True;Connect Timeout=30;";
        private void btnBackup_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string day = date.Day + "_" + date.Month+"_"+date.Year;
            //create a Folder to backup our files
            string dir = @"C:\AirForce_Database";
            if (!Directory.Exists(dir)) // creates the directory if it doesn't exist
            {
                Directory.CreateDirectory(dir);
            }
            //Database
           // string Db = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Airforce_Library.mdf");//"Airforce_Library.mdf";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    // string str = "USE " + Db + ";";
                    string query = "BACKUP DATABASE [" +Application.StartupPath + "\\Airforce_Library.mdf] TO DISK='C:\\AirForce_Database\\AirForceLibrary_" + day + ".Bak';";
                  SqlCommand command1 = new SqlCommand(query, connect);
                    connect.Open();
                   // command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Backup completed Successfully","Database Backup",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
