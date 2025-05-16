using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzaySimulasyon
{
    internal class Kisi
    {
        private string isim;
        private string durum;
        private int yas;
        private int kalan_omur;
        private string bulundugu_uzay_aracı_adi;

        public Kisi(string _isim, int _yas, int _kalan_omur, string _bulundugu_uzay_araci_adi, string _durum = "CANLI")
        {
            this.isim = _isim;
            this.durum = _durum;
            this.yas = _yas;
            this.kalan_omur = _kalan_omur;
            this.bulundugu_uzay_aracı_adi = _bulundugu_uzay_araci_adi;
            //this.durum = durum;
        }



        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }

        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }

        public int Kalan_omur
        {
            get { return kalan_omur; }
            set { kalan_omur = value; }

        }

        public string Bulundugu_uzay_araci_adi
        {
            get { return bulundugu_uzay_aracı_adi; }
            set { this.bulundugu_uzay_aracı_adi = value; }
        }
    }
}
