using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzaySimulasyon
{
    internal static class Zaman
    {
        public static void Gezegenler_bir_saat_ilerlet(List<Gezegen> gezegen_list)
        {
            foreach(Gezegen gezegen in gezegen_list)
            {
                gezegen.Gezegendeki_tarih = gezegen.Gezegendeki_tarih.AddHours(24 / (double)gezegen.Gunun_kac_saat_oldugu);
            }

        }

        public static void Omur_azalt(List<Kisi> kisiler)
        {
            foreach (Kisi kisi in kisiler)
            {
                if (kisi.Kalan_omur > 0)
                    kisi.Kalan_omur -= 1;
                else
                    kisi.Durum = "ÖLDÜ";
            }
        }

        public static void Yolda_olan_araclari_bir_saat_ilerlet(List<UzayAraci> araclar) 
        {
            foreach(UzayAraci arac in araclar)
            {
                if(arac.Mesafe_saat_ > 0 && arac.Durum == "YOLDA")
                {
                    arac.Mesafe_saat_ -= 1;
                }
                else if (arac.Mesafe_saat_ == 0 && arac.Durum == "YOLDA")
                {
                    arac.Durum = "VARDI";
                }
            }
        }
    }
}
