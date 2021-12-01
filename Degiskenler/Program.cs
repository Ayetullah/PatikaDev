using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5; // 1 byte
            sbyte c = 5; // 1 byte

            short s = 5;  // 2 byte
            ushort us = 5;  // 2 byte


            int i16 = 2;  // 2 byte
            int i = 2;  // 4 byte
            int i32 = 2;  // 4 byte
            int i64 = 2;  // 8 byte

            uint ui = 2; // 4 byte
            long l = 2;  // 8 byte
            ulong ul = 2;  // 8 byte

            // reel sayılar
            float f = 2;    // 4 byte
            double d = 2;   // 8 byte
            decimal de = 2; // 16 byte

            char cc = '2'; // 2 byte
            string str = "sad"; // sınırsız

            bool b1 = false;
            bool b2 = true;

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler
            string str1 = string.Empty;
            str1 = "Ayetullah Ünlü";
            string ad = "Ayetullah";
            string soyad = "Ünlü";
            string tamAd = $"{ad} {soyad}";

            int int1 = 5;
            int int2 = 3;
            int int3 = int1 * int2;

            bool bool1 = 10 < 1;

            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            // date Time
            string dateTimeStr = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTimeStr);

            string dateTimeStr1 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTimeStr1);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
