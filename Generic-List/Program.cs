using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(12);
            sayiListesi.Add(22);
            sayiListesi.Add(4);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("sarı");
            renkListesi.Add("mavi");
            renkListesi.Add("kırmızı");
            renkListesi.ForEach(x => Console.WriteLine(x));
            sayiListesi.ForEach(x => Console.WriteLine(x));

            renkListesi.Remove("sarı");
            sayiListesi.Remove(4);
            renkListesi.ForEach(x => Console.WriteLine(x));
            sayiListesi.ForEach(x => Console.WriteLine(x));

            //Liste içinde arama
            if (sayiListesi.Contains(22))
            {
                Console.WriteLine("22 bulundu");
            }

            //Eleman ile index bulma
            Console.WriteLine(renkListesi.BinarySearch("mavi"));

            //diziyi listeye çeviröe
            string[] hayvanlar = new string[] { "kedi", "köpek", "fare" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            // listeyi temizleme
            hayvanlarListesi.Clear();

            //liste ile model
            List<Kullanici> kullaniciListesi = new List<Kullanici>()
            {
                new Kullanici()
                {
                    AdSoyad = "Ayetullah Ünlü",
                    Yas = 27
                }
            };

            kullaniciListesi.ForEach(x => Console.WriteLine("Adı Soyadı: {0}\nYas: {1}", x.AdSoyad, x.Yas));
        }

        public class Kullanici
        {
            public string AdSoyad { get; set; }
            public int Yas { get; set; }
        }
    }
}
