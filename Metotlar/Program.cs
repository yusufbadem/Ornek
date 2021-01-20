using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
             {
                string urunAdi = " Elma";
                double fiyatı = 15;
                string acıklama = "Amasya elması";

                string[] meyveler = new string[] { };

                Urun urun1 = new urunAdi();
                urun1.Adi = "Elma";
                urun1.Fiyatı = 15;
                urun1.Aciklama = "Amasya elması;

                Urun urun2 = new Urun();
                urun2.Adi = "karpuz";
                urun2.Fiyatı = 80;
                urun2.Aciklama = "Diyarbakır karpuzu";

                Urun[] urunler = new Urun[] { urun1, urun2 };


                foreach (Urun urun in urunler)
                {
                    Console.WriteLine(urun.Adi);
                    Console.WriteLine(urun.Fiyatı);
                    Console.WriteLine(urun.Aciklama);
                    Console.WriteLine("-------------");



                }

                Console.WriteLine("---------------MEtodlar---");

                SepetManager sepetManager = new SepetMAnager();
                sepetManager.Ekle(urun1);
                sepetManager.Ekle(urun2);




            }
        }
    }
}
