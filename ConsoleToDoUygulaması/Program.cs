using ConsoleToDoUygulaması.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToDoUygulaması
{
    class Program
    {
        public static List<User> users = new List<User>();
        public static List<Kartlar> kartlar = new List<Kartlar>();
        static void Main(string[] args)
        {
            users = new List<User>()
            {
                new User() { Id = 1, Username = "Ayetullah"},
                new User() { Id = 2, Username = "Merve"},
                new User() { Id = 3, Username = "İbrahim"},
                new User() { Id = 4, Username = "Tarık"},
            };

            kartlar = new List<Kartlar>()
            {
                new Kartlar()
                {
                    BoardLine = BoardLine.Todo,
                    Baslik = "Ayetullah ın taskı" ,
                    Icerik = "bu bir icerik mesajıdır",
                    AtananKisi = 1,
                    Buyukluk = Buyukluk.XS
                },
                new Kartlar()
                {
                    BoardLine = BoardLine.InProgress,
                    Baslik = "Merve nın taskı" ,
                    Icerik = "bu bir icerik mesajıdır",
                    AtananKisi = 2,
                    Buyukluk = Buyukluk.XL
                },
                new Kartlar()
                {
                    BoardLine = BoardLine.Todo,
                    Baslik = "İbrahim ın taskı" ,
                    Icerik = "bu bir icerik mesajıdır",
                    AtananKisi = 3,
                    Buyukluk = Buyukluk.S
                },
            };

            MainMethod();
        }

        private static void MainMethod()
        {
            Console.WriteLine("\n");
            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("  ******************************************* ");
            Console.WriteLine(" (1) Board Listelemek");
            Console.WriteLine(" (2) Board'a Kart Eklemek");
            Console.WriteLine(" (3) Board'dan Kart Silmek");
            Console.WriteLine(" (4) Kart Taşımak");
            int.TryParse(Console.ReadLine(), out int selection);
            switch (selection)
            {
                case (int)Islemler.Listelemek:
                    Listele();
                    break;
                case (int)Islemler.Eklemek:
                    KartEkle();
                    break;
                case (int)Islemler.Silmek:
                    KartSil();
                    break;
                case (int)Islemler.Tasimak:
                    KartTasima();
                    break;
            }

            MainMethod();
        }

        private static void KartTasima()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();
            List<Kartlar> kartList = kartlar.Where(x => x.Baslik.Equals(baslik)).ToList();
            if (!kartList.Any())
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * İşlemi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için : (2)");
                int.TryParse(Console.ReadLine(), out int value);
                if (value == 1)
                {
                    MainMethod();
                    return;

                }
                else if (value == 2)
                {
                    KartSil();
                    return;
                }
            }

            Console.WriteLine(" Bulunan Kart Bilgileri:");
            kartList.ForEach(x => IcerikOlustur(x, "", true));
            Console.WriteLine(" Lütfen taşımak istediğiniz Line'ı seçiniz:");
            Console.WriteLine(" (1) TODO");
            Console.WriteLine(" (2) IN PROGRESS");
            Console.WriteLine(" (3) DONE");
            int.TryParse(Console.ReadLine(), out int line);
            foreach (var item in kartList)
            {
                item.BoardLine = (BoardLine)line;
            }

            Console.Clear();
        }

        private static void KartSil()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();
            List<Kartlar> kartList = kartlar.Where(x => x.Baslik.Equals(baslik)).ToList();
            if(!kartList.Any()) {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Silmeyi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için : (2)");
                int.TryParse(Console.ReadLine(), out int value);
                if(value == 1)
                {
                    MainMethod();
                    return;

                } else if(value == 2)
                {
                    KartSil();
                    return;
                }
            }

            kartlar = kartlar.Except(kartList).ToList();
        }

        private static void KartEkle()
        {
            Kartlar kart = new Kartlar();
            kart.BoardLine = BoardLine.Todo;
            Console.WriteLine("Baslik Giriniz                                   :");
            kart.Baslik = Console.ReadLine();
            Console.WriteLine("Icerik Giriniz                                   :");
            kart.Icerik = Console.ReadLine();
            Console.WriteLine(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int.TryParse(Console.ReadLine(), out int buyukluk);
            kart.Buyukluk = (Buyukluk)buyukluk;
            Console.WriteLine("Kisi Seçiniz                                     :");
            int.TryParse(Console.ReadLine(), out int kisi);
            if(users.FirstOrDefault(x => x.Id == kisi) == null)
            {
                Console.Clear();
                Console.WriteLine("Hatalı girişler yaptınız!");
                MainMethod();
                return;
            }

            kart.AtananKisi = kisi;
            kartlar.Add(kart);
            Console.Clear();
        }

        private static void Listele()
        {
            List<Kartlar> todoList = kartlar.Where(x => x.BoardLine == BoardLine.Todo).ToList();
            List<Kartlar> inProgressList = kartlar.Where(x => x.BoardLine == BoardLine.InProgress).ToList();
            List<Kartlar> doneList = kartlar.Where(x => x.BoardLine == BoardLine.Done).ToList();
            Console.WriteLine("\n");
            todoList.ForEach(x => IcerikOlustur(x, "TODO Line"));
            Console.WriteLine("\n");
            inProgressList.ForEach(x => IcerikOlustur(x, "IN PROGRESS Line"));
            Console.WriteLine("\n");
            doneList.ForEach(x => IcerikOlustur(x, "DONE Line"));
            Console.WriteLine("\n");

            if(!todoList.Any())
            {
                Console.WriteLine(" TODO Line");
                Console.WriteLine("  ******************************************* ");
                Console.WriteLine(" ~ BOŞ ~");
            }

            if (!inProgressList.Any())
            {
                Console.WriteLine(" IN PROGRESS Line");
                Console.WriteLine("  ******************************************* ");
                Console.WriteLine(" ~ BOŞ ~");
            }

            if (!doneList.Any())
            {
                Console.WriteLine(" DONE Line");
                Console.WriteLine("  ******************************************* ");
                Console.WriteLine(" ~ BOŞ ~");
            }
        }

        private static void IcerikOlustur(Kartlar item, string baslik, bool isMove = false)
        {
            string userName = users.FirstOrDefault(x => x.Id == item.AtananKisi)?.Username;
            Console.WriteLine(baslik);
            Console.WriteLine("  ******************************************* ");
            Console.WriteLine("Baslik        : {0}", item.Baslik);
            Console.WriteLine("İçerik        : {0}", item.Icerik);
            Console.WriteLine("Atanan Kisi   : {0}", userName);
            Console.WriteLine("Büyüklük      : {0}", item.Buyukluk);
            if(isMove)
            {
                Console.WriteLine("Line         : {0}", item.BoardLine);
            }

            Console.WriteLine("-");
        }
    }
}
