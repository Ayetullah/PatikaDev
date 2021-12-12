using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayse";
            ogrenci.Soyad = "Yılmaz";
            ogrenci.OgrenicNo = 148;
            ogrenci.Sinif = 1;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();
            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 158, 1);
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string _isim;
        private string _soyad;
        private int _ogrenicNo;
        private int _sinif;

        public string Isim { get => _isim; set => _isim = value; }

        public Ogrenci(string isim, string soyad, int ogrenicNo, int sinif)
        {
            Isim = isim;
            Soyad = soyad;
            OgrenicNo = ogrenicNo;
            Sinif = sinif;
        }

        public string Soyad { get => _soyad; set => _soyad = value; }
        public int OgrenicNo { get => _ogrenicNo; set => _ogrenicNo = value; }
        public int Sinif { 
            get => _sinif;
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 Olabilir!");
                    value = 1;
                }

                _sinif = value;
            }
        }

        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("********** Öğrenci Bilgileri ********");
            Console.WriteLine("Öğrenci Adı : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı : {0}", this.Soyad);
            Console.WriteLine("Öğrenci OgrenicNo : {0}", this.OgrenicNo);
            Console.WriteLine("Öğrenci Sınıfı : {0}", this.Sinif);
        }

        public void SinifAtlat() {
            this.Sinif += 1;
        }

        public void SinifDusur() {
            this.Sinif -= 1;
        }
    }
}
