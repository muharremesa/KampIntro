using System;

namespace Metotlar
{
    
    class Program
    {
        static void Main(string[] args)
        {
            String Adi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati =15;
            urun1.Acıklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati =20;
            urun2.Acıklama = "Diyarbakır Karpuzu";
            //Dizi oluşturduk
            Urun[] urunler = new Urun[] {urun1,urun2 };
           
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("--------------");


            }
            Console.WriteLine("--------------Metotlar---------");

            //instance-örnek
            //Encapsulation yanı yenı bır ozellık daha eklemıs olduk urunlerde StokAdedi diye patlama olmadı.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);




        }
    }
}
