using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzaySimulasyon
{
    internal class UzayAraci
    {
        private string uzay_araci_adi;
        private string durum;
        private string cikis_gezegeni;
        private string varis_gezegeni;
        private DateTime cikis_tarihi;
        private int mesafe_saat_olarak;

        public UzayAraci(string p_uzay_araci_adi,  string p_cikis_gezegeni, string p_varis_gezegeni, DateTime p_cikis_tarihi, int p_mesafe_saat_olarak, string p_durum = "BEKLIYOR") 
        { 
            this.uzay_araci_adi = p_uzay_araci_adi;
            this.durum = p_durum;
            this.cikis_gezegeni = p_cikis_gezegeni;
            this.varis_gezegeni = p_varis_gezegeni;
            this.cikis_tarihi = p_cikis_tarihi;
            this.mesafe_saat_olarak = p_mesafe_saat_olarak;
        }


        public string Uzay_araci_adi
        {
            get { return this.uzay_araci_adi; }
            set { this.uzay_araci_adi = value; }
        }

        public string Durum
        {
            get { return this.durum; }
            set { this.durum = value; }
        }

        public string Cikis_gezegeni
        {
            get { return cikis_gezegeni; }
            set { this.cikis_gezegeni = value; }
        }

        public string Varis_gezegeni
        {
            get { return varis_gezegeni; }
            set { varis_gezegeni = value;}
        }

        public DateTime Cikis_tarihi
        {
            get { return this.cikis_tarihi; }
            set { this.cikis_tarihi = value; }
        }

        public int Mesafe_saat_
        {
            get { return this.mesafe_saat_olarak; }
            set { this.mesafe_saat_olarak = value; }
        }

        public static bool TumAraclarVardiMi(List<UzayAraci> araclar)
        {
            bool kosul = true;

            foreach(UzayAraci arac in araclar)
            {
                if(arac.durum == "VARDI")
                    continue;
                else
                    kosul = false;
            }

            if (kosul)
                return true;
            else return false;
        }
    }
}
