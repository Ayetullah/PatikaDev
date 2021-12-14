using System;

namespace Enumlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Salı);
            Console.WriteLine((int)Gunler.Cumartesi);

            Console.WriteLine("Sicaklik Degerini Giriniz");
            int.TryParse(Console.ReadLine(), out int sicaklik);
            if (sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle");
            else if (sicaklik >= (int)HavaDurumu.Sicak)
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
                Console.WriteLine("Hadi dışarı çıkalım");
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
