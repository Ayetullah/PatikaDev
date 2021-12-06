using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama
            Console.WriteLine("Atama ve işlemli atama");
            int x = 3;
            int y = 3;
            y = y + 2;
            y += 2;

            y /= 1;
            x *= 2;

            Console.WriteLine(y + " : " + x);
            Console.WriteLine("Mantıksal Operatörler");
            //Mantıksal Operatörler
            // ||, && , !
            bool isSuccess = true;
            bool isComplete = false;
            if (isSuccess && isComplete)
            {
                Console.WriteLine("Perfect!");
            }

            if (isSuccess || isComplete)
            {
                Console.WriteLine("Great!");
            }

            if (isSuccess && !isComplete)
            {
                Console.WriteLine("Fine!");
            }

            //ilişkisel Operatorler
            // <, >,<=, >=, ==, !=
            Console.WriteLine("ilişkisel Operatorler");
            int a = 3;
            int b = 4;
            bool result = a < b;
            Console.WriteLine(result);
            result = a>b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);

            // /,*,+,-
            Console.WriteLine("Aritmetik Operatörler");
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);

            // % mod operatörü
            Console.WriteLine("Mod Operatörü");
            sonuc1 = 20%3;
            Console.WriteLine(sonuc1);
        }
    }
}
