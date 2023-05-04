using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane
{
    public partial class ReceteEkranı : Form
    {
        Kullanici Kullanici;
        public ReceteEkranı(Kullanici kullanici)
        {
            InitializeComponent();
            this.Kullanici = kullanici;
            
        }

        private void buttonHastaEkle_Click(object sender, EventArgs e)
        {
            HastaKayitEkrani hastaKayitEkrani = new HastaKayitEkrani();
            hastaKayitEkrani.Show();
        }
    }
}
