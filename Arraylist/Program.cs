using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //list.Add(25);
            //list.Add("Ali");
            //list.Add(true);
            //list.Add('a');

            //içerisindeki verilere erişim
            //Console.WriteLine(list[2]);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("****** Add Range *******");
            //string[] renkler = new string[] { "sarı", "kırmızı", "mavi", "yeşil" };
            int[] sayilar = new int[] { 1,2,3,4,5,6 };
            //list.AddRange(renkler);
            list.AddRange(sayilar);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****** Sort *******");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****** Binary Search *******");
            Console.WriteLine(list.BinarySearch(5));

            Console.WriteLine("****** Reverse *******");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****** Clear *******");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
