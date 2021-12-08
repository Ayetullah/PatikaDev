using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             erisim_belirteci geri_donus_tipi metot_adi(parametrelistesi/arguman)
                 {
                     komutlar;
                     return;
                 }
             */
            int a = 5;
            int b = 4;
            int sonuc = Topla(a, b);
            Metotlar metotlar = new Metotlar();
            metotlar.EkranaYazdır(sonuc.ToString());
            int sonuc2 = metotlar.ArttirVeTopla(ref a, ref b);
            metotlar.EkranaYazdır("*****Arttır ve topla ******");
            metotlar.EkranaYazdır(sonuc2.ToString());
            metotlar.EkranaYazdır((a+b).ToString());
        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return (deger1 + deger2);
        }
    }
}
