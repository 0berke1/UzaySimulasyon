using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private List<Kisi> kisiler;

        public UzayAraci(string p_uzay_araci_adi,  string p_cikis_gezegeni, string p_varis_gezegeni, DateTime p_cikis_tarihi, int p_mesafe_saat_olarak, string p_durum = "BEKLIYOR") 
        { 
            this.uzay_araci_adi = p_uzay_araci_adi;
            this.durum = p_durum;
            this.cikis_gezegeni = p_cikis_gezegeni;
            this.varis_gezegeni = p_varis_gezegeni;
            this.cikis_tarihi = p_cikis_tarihi;
            this.mesafe_saat_olarak = p_mesafe_saat_olarak;
            this.kisiler = new List<Kisi>();
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

        public List<Kisi> Kisiler
        {
            get {return this.kisiler;}
        }

        public static bool TumAraclarVardiMi(List<UzayAraci> araclar)
        {
            bool kosul = true;

            foreach(UzayAraci arac in araclar)
            {
                if(arac.durum == "VARDI" || arac.durum == "IMHA")
                    continue;
                else
                    kosul = false;
            }

            if (kosul)
                return true;
            else return false;
        }

        public static void Kisileri_Araclara_Yerlestir(List<Kisi> _kisiler,  List<UzayAraci> _araclar)
        {
            foreach(UzayAraci arac in _araclar)
            {
                foreach (Kisi kisi in _kisiler)
                {
                    if (kisi.Bulundugu_uzay_araci_adi == arac.uzay_araci_adi)
                    {
                        arac.kisiler.Add(kisi);
                    }
            }
            }
            
        }

        public static void Arac_Imha_Olacak_Mi(List<UzayAraci> araclar)
        {
            bool kosul = false;

            foreach(UzayAraci arac in araclar)
            {
                
                foreach(Kisi kisi in arac.kisiler)
                {
                    if(kisi.Durum == "CANLI")
                    {
                        kosul = false;
                        break;
                    }
                    else if(kisi.Durum == "ÖLDÜ")
                    {
                        kosul = true;
                    }
                }

                if (kosul)
                {
                    arac.Durum = "IMHA";
                }

            }
        }
    }
}
