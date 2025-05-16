using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UzaySimulasyon
{
    // her bir txt için ayrı statik okuma metodu. Main de kullanılarak listeler oluşturulabilir.
    internal static class DosyaOkuma
    {

        public static List<Kisi> KisiOku(string filePath)
        {
            // reads kisi.txt, each line is a kisi object, stores them in a list and return it.

            List<Kisi> kisiler = new List<Kisi>();

            foreach (string line in File.ReadLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split('#', 4);
                if (parts.Length == 4)
                {
                    Kisi kisi;

                    string isim = parts[0].Trim();
                    int yas = Int32.Parse(parts[1].Trim());
                    int kalan_omur = int.Parse(parts[2].Trim());
                    string uzay_araci = parts[3].Trim();

                    kisi = new Kisi(isim, yas, kalan_omur, uzay_araci);

                    kisiler.Add(kisi);
                }
            }

            return kisiler;

        }

        public static List<UzayAraci> AracOku(string filePath)
        {
            List<UzayAraci> araclar = new List<UzayAraci>();

            foreach (string line in File.ReadLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split('#', 5);
                if (parts.Length == 5)
                {
                    UzayAraci arac;

                    string ad = parts[0].Trim();
                    string cikis_gezegeni = parts[1].Trim();
                    string varis_gezegeni = parts[2].Trim();

                    var tarih_split = parts[3].Trim().Split('.', 3);

                    DateTime cikis_tarihi = new DateTime(Int32.Parse(tarih_split[2]), Int32.Parse(tarih_split[1]), Int32.Parse(tarih_split[0]));
                    int mesafe_saat = Int32.Parse(parts[4].Trim());

                    arac = new UzayAraci(ad, cikis_gezegeni, varis_gezegeni, cikis_tarihi, mesafe_saat);

                    araclar.Add(arac);
                }
            }

            return araclar;

        }

        public static List<Gezegen> GezegenOku(string filePath)
        {
            List<Gezegen> gezegenler = new List<Gezegen>();

            foreach (string line in File.ReadLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split('#', 3);
                if (parts.Length == 3)
                {
                    Gezegen gezegen;

                    string ad = parts[0].Trim();
                    int gun_kac_saat = Int32.Parse(parts[1].Trim());

                    var tarih_split = parts[2].Trim().Split('.', 3);

                    DateTime gezegendeki_tarih = new DateTime(Int32.Parse(tarih_split[2]), Int32.Parse(tarih_split[1]), Int32.Parse(tarih_split[0]));
                    

                    gezegen = new Gezegen(ad, gun_kac_saat, gezegendeki_tarih);

                    gezegenler.Add(gezegen);
                }
            }

            return gezegenler;

        }
    }
}
