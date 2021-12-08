using System;
using System.Collections.Generic;

namespace Csharp101_Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstQuestion();
            //SecondQuestion();
            //ThirdQuestion();
            //FourthQuestion();
        }

        static void FirstQuestion()
        {
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            List<int> sayılar = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz", i);
                sayılar.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in sayılar)
            {
                if(item%2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void SecondQuestion()
        {
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Farklı Pozitif bir sayı giriniz: ");
            int m = int.Parse(Console.ReadLine());
            List<int> sayılar = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz", i);
                sayılar.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in sayılar)
            {
                if (item % m == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void ThirdQuestion()
        {
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            List<string> kelimeler = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}. kelimeyi giriniz", i);
                kelimeler.Add(Console.ReadLine());
            }

            kelimeler.Reverse();
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
        }

        static void FourthQuestion()
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(" ");
            int toplamKelime = kelimeler.Length;
            int toplamHarf = 0;
            foreach (var item in kelimeler)
            {
                toplamHarf += item.Length;
            }

            Console.WriteLine("Toplam kelime: {0}", toplamKelime);
            Console.WriteLine("Toplam harf: {0}", toplamHarf);
        }
    }
}
