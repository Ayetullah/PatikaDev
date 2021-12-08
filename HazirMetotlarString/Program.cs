using System;

namespace HazirMetotlarString
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hosgeldiniz!";
            string degisken2 = "CSharp, Hosgeldiniz!";
            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(string.Concat("Merhaba ",degisken));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1
            Console.WriteLine(string.Compare(degisken, degisken2, true));
            Console.WriteLine(string.Compare(degisken, degisken2, false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Hosgeldiniz!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CSharp"));
            Console.WriteLine(degisken.IndexOf("CSharp1"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba "));

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken2 + degisken.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,4));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", ""));

            //Split
            Console.WriteLine(degisken.Split(' ')[0]);

            //Substring
            Console.WriteLine(degisken.Substring(5));
            Console.WriteLine(degisken.Substring(5, 16));

        }
    }
}
