using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane
{
    public class Kullanici
    {
        
        string kullaniciAdi;
        string sifre;

        public Kullanici(string username, string password)
        {
            this.kullaniciAdi = username;
            this.sifre = password;
        }

        public string KullaniciAdi { get { return kullaniciAdi; } }
        public string Sifre { get { return sifre; } }
    }
}
