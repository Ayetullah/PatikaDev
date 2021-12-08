using System;

namespace Metotlar_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!\n{0}", outSayi);
            } else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar metotlar = new Metotlar();
            metotlar.Topla(2, 3, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metot aşırı yükleme - Overloading
            metotlar.EkranaYazdir(999);
            metotlar.EkranaYazdir(Convert.ToString(999));
            metotlar.EkranaYazdir("Ayetullah","Ünlü");

            //metot imzası
            //metotadi + parametre sayisi + parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri, string veri2)
        {
            Console.WriteLine("{0} {1}",veri, veri2);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}
