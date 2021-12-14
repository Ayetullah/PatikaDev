using System;

namespace StatikSinifVeUyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayetullah", "Ünlü", "Yazılımcı");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100, 50));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Cikar(100, 50));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim = null, string soyisim = null, string departman = null)
        {
            Isim = isim;
            Soyisim = soyisim;
            Departman = departman;
            calisanSayisi += 1;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
