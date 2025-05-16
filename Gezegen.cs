using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzaySimulasyon
{
    internal class Gezegen
    {
        private string gezegen_adi;
        private int gunun_kac_saat_oldugu;
        private DateTime gezegendeki_tarih;

        public Gezegen(string p_gezegen_adi, int p_gunun_kac_saat_oldugu, DateTime p_gezegendeki_tarih)
        {
            this.gezegen_adi = p_gezegen_adi;
            this.gunun_kac_saat_oldugu = p_gunun_kac_saat_oldugu;
            this.gezegendeki_tarih = p_gezegendeki_tarih;
        }

        public string Gezegen_adi
        {
            get { return gezegen_adi; }
            set { gezegen_adi = value; }
        }

        public int Gunun_kac_saat_oldugu
        {
            get { return this.gunun_kac_saat_oldugu; }
            set { this.gunun_kac_saat_oldugu = value; }
        }

        public DateTime Gezegendeki_tarih
        {
            get { return gezegendeki_tarih;}
            set { this.gezegendeki_tarih = value; }
        }

        public static DateTime get_tarih_by_name(string name, List<Gezegen> gezegenler)
        {
            DateTime tarih = new DateTime();

            foreach (Gezegen gezegen in gezegenler)
            {
                if(gezegen.Gezegen_adi == name)
                {
                    tarih = gezegen.Gezegendeki_tarih;
                }
                
            }

            return tarih;
        }
    }
}
