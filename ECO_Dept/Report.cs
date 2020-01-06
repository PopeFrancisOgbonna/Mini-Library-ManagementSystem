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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using DGVPrinterHelper;

namespace ECO_Dept
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        //Database connection property
        private string connectionString = @"Data Source=.;Initial Catalog=Airforce_Library;Integrated Security=true;";
        private void btnSpecific_Click(object sender, EventArgs e)
        {
            lblFrom.Visible = true;
            lblTo.Visible = true;
            frmDate.Visible = true;
            toDate.Visible = true;
            btnShow.Visible = true;
        }

        private void btnAll_Click(object sender, EventArgs e)
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
            btnShow.Visible = false;
            lblFrom.Visible = false;
            lblTo.Visible = false;
            frmDate.Visible = false;
            toDate.Visible = false;
            dataGridView1.Visible = true;
            btnExport.Visible = true;
            btnPrint.Visible = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveToPDF(dataGridView1, "ECO_Record");
        }
        private void saveToPDF(DataGridView grd,string file)
        {
            BaseFont font = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,BaseFont.CP1250,BaseFont.EMBEDDED);
            PdfPTable tbl = new PdfPTable(grd.Columns.Count);
            tbl.DefaultCell.Padding = 2;
            tbl.WidthPercentage = 100;
            tbl.HorizontalAlignment = Element.ALIGN_LEFT;
            tbl.DefaultCell.BorderWidth =0.6f;

            iTextSharp.text.Font text = new iTextSharp.text.Font(font, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in grd.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                tbl.AddCell(cell);
            }
            //add data rows
            foreach (DataGridViewRow row in grd.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    tbl.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiles = new SaveFileDialog();
            savefiles.FileName = file;
            savefiles.DefaultExt = ".pdf";
            if (savefiles.ShowDialog() == DialogResult.OK)
            {
                using(FileStream stream =new FileStream(savefiles.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(doc, stream);
                    doc.Open();
                    doc.Add(tbl);
                    doc.Close();
                    stream.Close();
                    MessageBox.Show("Document Saved Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (frmDate.Value.Date == DateTime.Now.Date||frmDate.Value.Date>DateTime.Now.Date|| toDate.Value.Date > DateTime.Now.Date|| frmDate.Value.Date > toDate.Value.Date)
            {
                MessageBox.Show("Choose a Valid Date please.","Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                using(SqlConnection connect=new SqlConnection(connectionString))
                {
                    string query = "select ID,SVC_No as 'Service No.',Rank,Name,Item_Description as 'Item Description',Qty_Out as 'Quantity Collected',Sign_Out as 'Date Collected',Qty_In as 'Quantity Returned',Qty_Bal as 'Quantity Remaining',Sign_In as 'Date Returned',Remark from Borrow_Manual where Sign_Out between @param and @param1;";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@param", frmDate.Value.ToShortDateString());
                    command.Parameters.AddWithValue("@param1", toDate.Value.ToShortDateString());
                    SqlDataAdapter adapt = new SqlDataAdapter(command);
                    DataTable tbl = new DataTable();
                    adapt.Fill(tbl);
                    dataGridView1.DataSource = tbl;
                    dataGridView1.Visible = true;
                    btnExport.Visible = true;
                    btnPrint.Visible = true;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "RESTRICTED";
            print.SubTitle = string.Format("ECO Training Manual Library Report\nDate:{0}", DateTime.Now.Date.ToString());
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "RESTRICTED";
            print.FooterSpacing = 12;
            print.PrintDataGridView(dataGridView1);
            
        }
        
    }
}
