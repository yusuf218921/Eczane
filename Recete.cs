using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane
{
    internal class Recete
    {
        int id;
        Hasta hasta;
        Ilac ilac;
        string receteTarih;

        public Recete(int id, Hasta hasta, Ilac ilac, string receteTarih)
        {
            this.id = id;
            this.hasta = hasta;
            this.ilac = ilac;
            this.receteTarih = receteTarih;
        }

        public int Id { get { return id; } }
        public Hasta Hasta { get {  return hasta; } }
        public Ilac Ilac { get { return ilac; } }
        public string ReceteTarih { get {  return receteTarih; } }
    }
}
