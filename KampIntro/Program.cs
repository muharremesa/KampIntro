using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            String KategorEtiketi = "Kategori";
            int OgrenciSayısı = 32000;
            bool SistemeGirisYapmişMi=true;
            double DolarDun = 7.55;
            double DolarBugun = 7.45;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(DolarDun<DolarBugun)
            {
                Console.WriteLine("Artış Butonu Göster");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if (SistemeGirisYapmişMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            
        }
    }
}
