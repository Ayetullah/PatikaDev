using System;
using System.Collections;
using System.Collections.Generic;

namespace KoleksiyonlarlaIlgiliAlgoritmaSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru1();
            //Soru2();
            Soru3();
            
        }

        private static void Soru1()
        {
            int asalSayıToplamı = 0;
            int asalOlmayanSayıToplamı = 0;
            List<int> asal = new List<int>();
            List<int> asalOlmayan = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                int kontrol = 0;
                Console.WriteLine($"{i}. pozitif sayıyı giriniz");
                string console = Console.ReadLine();
                if (int.TryParse(console, out int sayi) && sayi > 0)
                {
                    for (int j = 2; j < sayi; j++)
                    {
                        if (sayi % j == 0)
                        {
                            kontrol++;
                            break;
                        }
                    }

                    if (kontrol != 0 && sayi != 2)
                    {
                        asalOlmayan.Add(sayi);
                        asalSayıToplamı += 0;
                    }
                    else
                    {
                        asal.Add(sayi);
                        asalSayıToplamı += sayi;
                    }

                }
            }

            asal.Sort();
            asal.Reverse();

            asalOlmayan.Sort();
            asalOlmayan.Reverse();

            Console.WriteLine("Asal liste eleman sayısı: {0}", asal.Count);
            if(asal.Count > 0)
            {
                Console.WriteLine("Asal liste eleman sayısının ortalaması: {0}", (asalSayıToplamı / asal.Count));
            }
            
            asal.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Asal olmayan liste eleman sayısı: {0}", asalOlmayan.Count);
            if (asalOlmayan.Count > 0)
            {
                Console.WriteLine("Asal liste eleman sayısının ortalaması: {0}", (asalOlmayanSayıToplamı / asalOlmayan.Count));
            }

            asalOlmayan.ForEach(x => Console.WriteLine(x));
        }

        private static void Soru2()
        {
            int[] sayilar = new int[20];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i+1}. sayıyı giriniz: ");
                int.TryParse(Console.ReadLine(), out int sayi);
                sayilar[i] = sayi;
            }

            Array.Sort(sayilar);
            float kTop = sayilar[0] + sayilar[1] + sayilar[2];
            float bTop = sayilar[sayilar.Length - 1] + sayilar[sayilar.Length - 2] + sayilar[sayilar.Length - 3];
            float kOrt = (kTop)/3;
            float bOrt = (bTop)/3;
            Console.WriteLine("Listedeki ilk 3 kücük elemanların:\n Toplamı: {0}\n Ortalaması: {1}",kTop,kOrt);
            Console.WriteLine("Listedeki son 3 büyük elemanların:\n Toplamı: {0}\n Ortalaması: {1}",bTop,bOrt);
        }

        private static void Soru3()
        {
            Console.WriteLine("Bir cümle giriniz: ");
            var text = Console.ReadLine();
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<char> sesliList = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                foreach (var item in sesliHarfler)
                {
                    if(text[i] == item)
                    {
                        sesliList.Add(text[i]);
                    }
                }
            }

            sesliList.Sort();
            sesliList.ForEach(x => Console.WriteLine(x));
        }
    }
}
