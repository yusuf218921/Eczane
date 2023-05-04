using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane
{
    internal class Ilac
    {
        int id;
        string ilacAd;
        string barkod;
        string receteTur;
        string aktifTarih;
        string firmaAd;
        string atcKod;
        string atcAd;
        float fiyat;

        public Ilac(int id, string ilacAd, string barkod, string receteTur, string aktifTarih, string firmaAd, string atcKod, string atcAd, float fiyat)
        {
            this.id = id;
            this.ilacAd = ilacAd;
            this.barkod = barkod;
            this.receteTur = receteTur;
            this.aktifTarih = aktifTarih;
            this.firmaAd = firmaAd;
            this.atcKod = atcKod;
            this.atcAd = atcAd;
            this.fiyat = fiyat;
        }
        public int getId() { return id; }
        public string getIlacAd() {  return ilacAd; }
        public string getBarkod() {  return barkod; }
        public string getReceteTur() {  return receteTur; }
        public string getFirmaAd() {  return firmaAd; }
        public string getatcKod() {  return atcKod; }
        public float getFiyat() {  return fiyat; }
        public string getAktifTarih() { return aktifTarih; }
        public string getAtcAd() { return atcAd; }
    }
}
