using System;

namespace SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //class SinifAdi
            //{
            //    [Erişim Belirleyici] [Veri Tipi] ÖzellikAdı;
            //    [Erişim Belirleyici]
            //    [Geri Dönüş Değerinin Tipi]
            //    MetotAdi([Parametreler])
            //    {
            //        //Metot Gövdesi
            //    }
            //}

            //Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal // sadece kendi bulunduğu proje içerisinde erişebilir
            // * Protected // sadece tanımlandığı sınıfta veya kalıtım alındğı yerden erişilebilir
            Calisan calisan = new Calisan();
            calisan.Ad = "Ayetullah";
            calisan.Soyad = "Ünlü";
            calisan.No = 12345678;
            calisan.Departman = "Yazılım";
            calisan.CalisanBilgiler();
            Console.WriteLine("**************");
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Deniz";
            calisan1.Soyad = "Arda";
            calisan1.No = 32689301;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgiler();
        }

        class Calisan {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;
            
            public void CalisanBilgiler()
            {
                Console.WriteLine("Calisan Adi: {0}", Ad);
                Console.WriteLine("Calisan Soyadi: {0}", Soyad);
                Console.WriteLine("Calisan No: {0}", No);
                Console.WriteLine("Calisan Departmanı: {0}", Departman);
            }
        }
    }
}
