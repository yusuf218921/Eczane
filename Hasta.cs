using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane
{
    internal class Hasta
    {
        int hastaId;
        string hastaAdi;
        string hastaSoyadi;
        string tc;
        string dogumTarih;
        //List<Recete> receteler = new List<Recete>();
        
        public Hasta (int hastaId,string hastaAdi,string hastaSoyadi,string tc,string dogumTarih)
        {
            this.hastaId = hastaId;
            this.hastaSoyadi = hastaSoyadi;
            this.hastaAdi = hastaAdi;
            this.tc = tc;
            this.dogumTarih = dogumTarih;
        }

        public int HastaId { get { return hastaId; } }
        public string HastaAdi { get {  return hastaAdi; } }
        public string HastaSoyadi { get {  return hastaSoyadi; } }
        public string TC { get { return tc; } }
        public string DogumTarih { get { return dogumTarih; } }
        /*public void addRecete(Recete recete)
        {
            receteler.Add(recete);
        }
        */
    }
}
