using System;

namespace StructKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.UzunKenar = 4;
            dikdörtgen.KisaKenar = 3;
            Console.WriteLine("Class dikdörtgen Alan hesabı: {0}", dikdörtgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct;
            dikdortgen_Struct.KisaKenar = 3;
            dikdortgen_Struct.UzunKenar = 4;
            Console.WriteLine("Struct dikdörtgen Alan hesabı: {0}", dikdortgen_Struct.AlanHesapla());
        }
    }

    class Dikdörtgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdörtgen()
        {
            KisaKenar = 4;
            UzunKenar = 5;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        //public Dikdortgen_Struct() // Parametresiz oluşturamazsınız
        //{
        //    KisaKenar = 4;
        //    UzunKenar = 5;
        //}

        //Değişkenlerine değer atamazsak AlanHesapla yı çağıramaz.

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
