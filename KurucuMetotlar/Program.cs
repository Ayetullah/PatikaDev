using System;

namespace KurucuMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Calisan********");
            Calisan calisan = new Calisan(
                "Ayetullah",
                "Ünlü",
                12345678,
                "Yazılım"
            );
            calisan.CalisanBilgiler();
            Console.WriteLine("*******Calisan1*******");
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Deniz";
            calisan1.Soyad = "Arda";
            calisan1.No = 32689301;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgiler();
            Console.WriteLine("******Calisan2********");
            Calisan calisan2 = new Calisan("Ali","Veli");
            calisan2.CalisanBilgiler();
        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;
            
            public Calisan(string Ad, string Soyad, int No, string Departman)
            {
                this.Ad = Ad;
                this.Soyad = Soyad;
                this.No = No;
                this.Departman = Departman;
            }
            
            public Calisan(string Ad, string Soyad)
            {
                this.Ad = Ad;
                this.Soyad = Soyad;
            }

            public Calisan() { }

            public void CalisanBilgiler()
            {
                Console.WriteLine("Calisan Adi: {0}", Ad);
                Console.WriteLine("Calisan Soyadi: {0}", Soyad);
                Console.WriteLine("Calisan No: {0}", No);
                Console.WriteLine("Calisan Departmanı: {0}", Departman);
            }
        }
    }
}