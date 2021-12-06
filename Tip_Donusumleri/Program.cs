using System;

namespace Tip_Donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("******Implicit conversion*******");
            byte a = 5;
            sbyte b = 38;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine("d:"+ d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "ayo";
            char f = 'a';
            object g = e + f + d;
            Console.WriteLine("g:" + g);

            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("\n******explicit conversion*******");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);
            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);
            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // ToString Methodu
            Console.WriteLine("\n******ToString Methodu*******");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:"+zz);

            // System Convert
            Console.WriteLine("\n******System Convert*******");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam:" + toplam);
            
            // Parse Method
            Console.WriteLine("\n******Parse Method*******");
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string m1 = "10";
            string m2 = "10.25";
            int r;
            double d;

            r = Int32.Parse(m1);
            d = Double.Parse(m2);

            Console.WriteLine("r:"+r);
            Console.WriteLine("d:"+d);
        }
    }
}
