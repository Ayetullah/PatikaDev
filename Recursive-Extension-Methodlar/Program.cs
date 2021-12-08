using System;

namespace Recursive_Extension_Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif methodlar
            Islemler islemler = new Islemler();
            Console.WriteLine(islemler.Expo(3, 4));
            string value = "Ayetullah Ünlü";
            bool isContainSpace = value.CheckSpaces();
            Console.WriteLine(isContainSpace);
            if(isContainSpace)
            {
                Console.WriteLine(value.RemoveWhiteSpaces());
            }

            Console.WriteLine(value.MakeToLowerCase());
            Console.WriteLine(value.MakeToUpperCase());

            int[] dizi = { 9, 5, 3, 2, 0, 1 };
            dizi.SortArray();
            dizi.EkranaYazdır();
            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());
            Console.WriteLine(value.GetFirstCharachter());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
                return sayi;
            return Expo(sayi, üs - 1) * sayi;
        }
    }

    public static class Extensions
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeToUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeToLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdır(this int[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharachter(this string param)
        {
            return param.Substring(0, 1);
        }
     }
}
