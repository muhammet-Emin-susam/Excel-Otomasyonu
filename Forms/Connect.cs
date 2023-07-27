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
namespace ExcellResim.Forms
{
    public partial class Connect : DevExpress.XtraEditors.XtraForm
    {
        public Connect()
        {
            InitializeComponent();
        }
       public string connetionString = null;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //string connetionString = null;
            SqlConnection cnn;
            //connetionString = "Data Source=DESKTOP-2FVNIE6;Initial Catalog=DBKatalog;User ID=sa;Password=sapass";
            connetionString = "Data Source=" + SunucuAdi.Text + ";Initial Catalog=" + TabloAdi.Text + ";User ID=" + KullaniciAdi.Text + ";Password=" + Sifre.Text + ";";
            connetionString = Settings.Default["ConnectionString"].ToString();
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                XtraMessageBox.Show("Bağlantınız Başarıyla Kurulmuştur.", "Başarılı", MessageBoxButtons.OK);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}