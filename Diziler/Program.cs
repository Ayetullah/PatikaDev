using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };
            int[] dizi;
            dizi = new int[5];

            //Dizilere Değer atama
            renkler[0] = "Mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle diziler kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. sayıyı giriniz: s");
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var item in sayiDizisi)
            {
                toplam += item;
            }
            
            Console.WriteLine($"Ortalama: {toplam / diziUzunlugu}");
        }
    }
}
