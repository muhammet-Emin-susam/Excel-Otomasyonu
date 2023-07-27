using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcellResim.Properties;
using System.IO;
using DevExpress.Spreadsheet;
using ClosedXML.Excel;
using DevExpress.Utils;
using DocumentFormat.OpenXml.Spreadsheet;
using IronXL;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;

namespace ExcellResim.Forms
{
    public partial class Excell : DevExpress.XtraEditors.XtraForm
    {
        public Excell()
        {
            InitializeComponent();
        }

        private readonly Forms.Connect c;
        private void Excell_Load(object sender, EventArgs e)
        {
            //Forms.Connect c = new Forms.Connect();
            if (Settings.Default["ConnectionString"].ToString() == string.Empty || Settings.Default["ConnectionString"].ToString() == null)
            {
                XtraMessageBox.Show("Lütfen Önce Veritabanı Bağlantısını Kurunuz.", "Uyarı", MessageBoxButtons.OK);
                Forms.Connect co = new Forms.Connect();
                co.Show();
            }
            else
            {
                SqlConnection baglanti = new SqlConnection();

                baglanti.ConnectionString = Settings.Default["ConnectionString"].ToString();
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT * FROM sys.tables";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TabloSecimi.Items.Add(dr[0]);
                }
                baglanti.Close();
            }



        }

        private void TabloSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentdatetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string LogFolder = @"C:\Users\muham\Deneme";
            string connectionString = Settings.Default["ConnectionString"].ToString();
            string queryString = "SELECT * FROM " + TabloSecimi.Text;
            string filePath = @"C:\Users\muham\Deneme";
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = true;
            save.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası |*.xls";
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
 
                        

                    // Connect to the SQL Server database and retrieve the data you want to export
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(queryString, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                // Create a new Excel application and workbook
                                Application excelApp = new Application();
                                Workbook excelWorkbook = excelApp.Workbooks.Add();
                                Worksheet excelWorksheet = excelWorkbook.Worksheets[1];

                                // Add the headers to the first row
                                int col = 1;
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    excelWorksheet.Cells[1, col].Value2 = reader.GetName(i);
                                    col++;
                                }

                                // Iterate through the rows of data and insert them into the worksheet, starting from the second row
                                int row = 2;
                                while (reader.Read())
                                {
                                    col = 1;
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        excelWorksheet.Cells[row, col].Value2 = reader[i];
                                        col++;
                                    }
                                    row++;
                                }
                                
                                // Save the workbook and close the Excel application
                                excelWorkbook.SaveAs(save.FileName);
                                excelWorkbook.Close();
                                excelApp.Quit();
                            }
                        }
                    }
                    using (FileStream stream = new FileStream(save.FileName, FileMode.Open))
                    {
                        ExcelSpread.LoadDocument(stream);
                    }
                    Cursor.Current = Cursors.Default;
                    //var spr = ExcelSpread.Document;
                    //spr.LoadDocument(save.FileName);
                }

                catch (Exception exception)
                {
                    using (StreamWriter sw = File.CreateText(LogFolder + "\\" + "ErrorLog_" + currentdatetime + ".log"))
                    {
                        sw.WriteLine(exception.ToString());
                    }

                }
            }
        }
    }
}













