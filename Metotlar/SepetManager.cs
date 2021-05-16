using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Spete Ürün ekleme işlemi

        //naming convention
        //basit bir fonksiyon ile yanı metotla yaptık
        //parametre vermek ne ekliyeceksek sepete Urun tipi kucuk urun asagıda kullanmak için
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urun.Adi );
        }
       
    }
}
