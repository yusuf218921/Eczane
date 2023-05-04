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

namespace Eczane
{
    public partial class GirişEkrani : Form
    {
        Kullanici kullanici;
        
        public GirişEkrani()
        {
            InitializeComponent();
        }
        bool login = false;
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlConnection connection = db.SqlConnection;
            connection.Open();
            string queryString = "SELECT * FROM [Eczaci]";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                if (reader["kullaniciAdi"].ToString() == textboxKullaniciAdi.Text 
                    && reader["sifre"].ToString() == textboxSifre.Text) 
                {
                    kullanici = new Kullanici(textboxKullaniciAdi.Text, textboxSifre.Text);
                    login = true; 
                    break;
                }
                
            }
            connection.Close();
            if (login)
            {
                this.Hide();
                Form mainScreen = new ReceteEkranı(kullanici);
                mainScreen.Closed += (s, args) => this.Close();
                mainScreen.Show();
                
            }
            else labelMesaj.Text = "Kullanıcı adı veya şifre yanlış girildi...";
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_welcome_Click(object sender, EventArgs e)
        {

        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSifreGoster.Checked)
            {
                textboxSifre.UseSystemPasswordChar = false;
            }
            else
            {
                textboxSifre.UseSystemPasswordChar = true;
            }
        }
    }
}
