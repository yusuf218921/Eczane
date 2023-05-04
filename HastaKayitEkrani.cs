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

namespace Eczane
{
    public partial class HastaKayitEkrani : Form
    {
           
        
        public HastaKayitEkrani()
        {
            
            InitializeComponent();
        }

        

        private void buttonHastaKayit_Click(object sender, EventArgs e)
        {
            if(textboxAd.Text == "" || textboxSoyad.Text == "" || textboxTC.Text == "")
            {
                labelBaşarılı.Text = "Bilgiler Boş girilemez...";
            }
            else
            {
                string hastaAdi = textboxAd.Text;
                string hastaSoyadi = textboxSoyad.Text;
                string tc = textboxTC.Text;
                DateTime dateTime = dateTimePickerDogumTarih.Value;
                string dogumTarihi = dateTime.ToString("yyyy-MM-dd");
                DBConnection conn = new DBConnection();
                SqlConnection connection = conn.SqlConnection;
                connection.Open();
                string queryString = "INSERT INTO [Hasta] (tc,hastaAdi,hastaSoyadi,dogumTarihi) VALUES (@tc,@hastaAdi,@hastaSoyadi,@dogumTarihi)";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@tc", tc);
                command.Parameters.AddWithValue("@hastaAdi", hastaAdi);
                command.Parameters.AddWithValue("@hastaSoyadi", hastaSoyadi);
                command.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);
                command.ExecuteNonQuery();
                connection.Close();
                labelBaşarılı.Text = "Hasta Başarıyla Sisteme Eklendi";
            }
        }
        private void buttonGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
