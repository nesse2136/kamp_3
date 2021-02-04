using System;

namespace kamp_3
{
    class Program
    {
        static void Main(string[] args)

        //tekrar tekrar kullanılabilirliği sağlayanlara method denir
        //DRY = Clean cod = Best Practise
        //Dont repeat yourself
        //Best practise- temiz kod yazma teknikleridir.

        {
            string urunAdi1= "Elma";
            double fiyati1 = 15;
            string aciklama1 = "Amasya elması";

            string urunAdi2 = "Çilek";
            double fiyati2 = 10;
            string aciklama2 = "Diyarbakır çileği";

            string[] meyveler = new string[] {"Elma", "Çilek" };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 45;
            urun2.Aciklama = "Diyarbakır Çileği";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //type-safe -- tip güvenli
           foreach (Urun urun in urunler)
            {
             Console.WriteLine(urun.Adi);
             Console.WriteLine(urun.Fiyati);
             Console.WriteLine(urun.Aciklama);
             Console.WriteLine(".........");
            }
            {
                Console.WriteLine("............Metodlar..........");
                //instance -clas örneği
                //encapsulation stok adedini de clasa eklemeyle olan kolaylığa deniyor.

                SepetMenager sepetMenager = new SepetMenager();
                sepetMenager.Ekle(urun1);
                sepetMenager.Ekle(urun2);

                sepetMenager.Ekle2("Armut", "Yeşil armut", 12, 10);
                sepetMenager.Ekle2("Elma", "Yeşil elma", 12, 9);
                sepetMenager.Ekle2("Karpuz", "Diyarbakır kapuz", 12, 8);
            }
        }


    }
}
