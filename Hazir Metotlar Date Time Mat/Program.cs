using System;

namespace Hazir_Metotlar_Date_Time_Mat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(5));
            Console.WriteLine(DateTime.Now.AddHours(10));
            Console.WriteLine(DateTime.Now.AddMinutes(25));
            Console.WriteLine(DateTime.Now.AddMonths(20));
            Console.WriteLine(DateTime.Now.AddYears(2));
            Console.WriteLine(DateTime.Now.AddMilliseconds(20));

            Console.WriteLine("****** Datetime Format *******");
            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//09
            Console.WriteLine(DateTime.Now.ToString("ddd"));//per
            Console.WriteLine(DateTime.Now.ToString("dddd"));//perşembe

            Console.WriteLine(DateTime.Now.ToString("MM"));//12
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Ara
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Aralık

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2121

            Console.WriteLine("****** Math Kütüphanesi *******");
            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//Sayıyı pozitif yapar
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            
            Console.WriteLine(Math.Ceiling(10.4));//yukarı yuvarlar
            Console.WriteLine(Math.Round(10.4));
            Console.WriteLine(Math.Floor(10.7));//Aşağı yuvarlar

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));
            
            Console.WriteLine(Math.Pow(2, 3));// 2^3 üstünü alır
            Console.WriteLine(Math.Sqrt(9));// karekök alır
            Console.WriteLine(Math.Log(9));// 9 un e tabanındaki logoritmik karşılığını getirir
            Console.WriteLine(Math.Exp(9));// e üzeri 9 u verir
            Console.WriteLine(Math.Log10(10));// 10 un log10 tabanında karşılığını verir
        }
    }
}
