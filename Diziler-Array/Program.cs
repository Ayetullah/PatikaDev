using System;

namespace Diziler_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("*********Sırasız dizi*******");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******Sıralı dizi*******");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("******Array Clear*******");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Reverse
            Console.WriteLine("******Array Reverse*******");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //indexOf
            Console.WriteLine("******Array indexOf*******");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //resize
            Console.WriteLine("******Array resize*******");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
