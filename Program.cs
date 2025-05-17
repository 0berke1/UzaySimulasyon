// See https://aka.ms/new-console-template for more information
using UzaySimulasyon;

Console.WriteLine("Hello, World!");

List<Kisi> kisiler =  DosyaOkuma.KisiOku("Kisiler.txt");
List<UzayAraci> araclar = DosyaOkuma.AracOku("Araclar.txt");
List<Gezegen> gezegenler = DosyaOkuma.GezegenOku("Gezegenler.txt");

UzayAraci.Kisileri_Araclara_Yerlestir(kisiler, araclar);

while (!UzayAraci.TumAraclarVardiMi(araclar))
{
    Console.Clear();

    Zaman.Gezegenler_bir_saat_ilerlet(gezegenler);

    Zaman.Omur_azalt(kisiler);

    foreach(UzayAraci arac in araclar)
    {
        if(arac.Durum == "BEKLIYOR" && arac.Cikis_tarihi <= Gezegen.get_tarih_by_name(arac.Cikis_gezegeni, gezegenler))
        {
            arac.Durum = "YOLDA";
        }
    }

    Zaman.Yolda_olan_araclari_bir_saat_ilerlet(araclar);

    UzayAraci.Arac_Imha_Olacak_Mi(araclar);

    for (int i = 0; i < araclar.Count; i++)
    {
        Console.WriteLine(araclar[i].Uzay_araci_adi + "   " + araclar[i].Durum + "    " + araclar[i].Cikis_gezegeni + "   " + araclar[i].Varis_gezegeni + "    " + araclar[i].Mesafe_saat_ + "   " + Gezegen.get_tarih_by_name(araclar[i].Cikis_gezegeni, gezegenler) + "   " + araclar[i].Cikis_tarihi);
    }

    List<Kisi> _kisiler = araclar[5].Kisiler;

    
    foreach(Kisi kisi in _kisiler)
    {
        Console.WriteLine(kisi.Isim + " Kalan ömür:  " +  kisi.Kalan_omur);
    }
    

    //Console.WriteLine(_kisiler.Count);

    Thread.Sleep(100);
    
}
 