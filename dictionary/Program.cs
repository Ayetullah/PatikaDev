using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10, "Ayetullah Ünlü");
            kullanicilar.Add(12, "Ali veli");
            kullanicilar.Add(15, "Deniz Arda");
            kullanicilar.Add(16, "Deniz An");

            Console.WriteLine("***** Kullanıcılara erişim *****");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count");
            Console.WriteLine(kullanicilar.Count);

            Console.WriteLine("Contains");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Deniz An"));

            Console.WriteLine("***** Remove *****");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Keys *****");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Values *****");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
