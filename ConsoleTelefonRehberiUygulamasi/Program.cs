using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTelefonRehberiUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User(){Ad="Ayetullah", Soyad="Ünlü", No=1234567894},
                new User(){Ad="Merve Aslan", Soyad="Ünlü", No=1234567895},
                new User(){Ad="Ali", Soyad="Veli", No=1234567890},
                new User(){Ad="Rafi", Soyad="Bayrak", No=1234567891},
                new User(){Ad="Tarik", Soyad="Yüzgül", No=1234567892},
            };

            MainMethod(users);
        }

        private static void MainMethod(List<User> users)
        {
           
            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine(" ******************************************* ");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            int islemler = (int)RehberIslemleri.Undefined;
            int.TryParse(Console.ReadLine(), out islemler);
            switch (islemler)
            {
                case (int)RehberIslemleri.NewUser:
                    users.Add(CreateNewUser());
                    break;
                case (int)RehberIslemleri.DeleteUser:
                    users = DeleteUser(users);
                    break;
                case (int)RehberIslemleri.UpdateUser:
                    users = UpdateUser(users);
                    break;
                case (int)RehberIslemleri.List:
                    ListUser(users);
                    break;
                case (int)RehberIslemleri.Search:
                    SearchUser(users);
                    break;
                default:
                    break;
            }

            ReturnMainMethod(users, islemler);
        }

        private static void ListUser(List<User> users)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("******************************");
            foreach (var item in users)
            {
                Console.WriteLine("İsim: {0}", item.Ad);
                Console.WriteLine("Soyisim: {0}", item.Soyad);
                Console.WriteLine("Telefon Numarası:  {0}", item.No);
                Console.WriteLine("-");
            }
        }

        private static void SearchUser(List<User> users)
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine (" ********************************************** ");
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int.TryParse(Console.ReadLine(), out int value);
            if(value == 1)
            {
                Console.WriteLine("Lütfen aramak istediğiniz isim veya soyisimi giriniz: ");
                string nameOrSurname = Console.ReadLine();
                users = users.Where(x => x.Ad.Equals(nameOrSurname) || x.Soyad.Equals(nameOrSurname)).ToList();
                ListUser(users);
            } else if(value == 2)
            {
                Console.WriteLine("Lütfen aramak istediğiniz numarayı giriniz: ");
                int.TryParse(Console.ReadLine(), out int number);
                users = users.Where(x => x.No == number).ToList();
                ListUser(users);
            }
        }

        private static List<User> UpdateUser(List<User> users)
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string value = Console.ReadLine();
            var foundUser = users.FirstOrDefault(x => x.Ad.Equals(value) || x.Soyad.Equals(value));
            if (foundUser != null)
            {
                Console.WriteLine("Yeni numarayı yazınız: ");
                int.TryParse(Console.ReadLine(), out int no);
                foundUser.No = no;
                return users;
            }

            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Güncellemeyi sonlandırmak için   : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            int.TryParse(Console.ReadLine(), out int newValue);
            if (newValue == 2)
            {
                UpdateUser(users);
            }
            else if (newValue == 1)
            {
                ReturnMainMethod(users);
            }

            return users;
        }

        private static List<User> DeleteUser(List<User> users)
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string value = Console.ReadLine();
            var foundUser = users.FirstOrDefault(x => x.Ad.Equals(value) || x.Soyad.Equals(value));
            if(foundUser != null)
            {
                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", foundUser.Ad);
                var answer = Console.ReadLine();
                if(answer.Equals("y"))
                {
                    users.Remove(foundUser);
                } else
                {
                    ReturnMainMethod(users);
                }
                
                return users;
            }

            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            int.TryParse(Console.ReadLine(), out int newValue);
            if(newValue == 2)
            {
                DeleteUser(users);
            }else if(newValue == 1)
            {
                ReturnMainMethod(users);
            }

            return users;
        }

        private static User CreateNewUser()
        {
            User user = new User();
            Console.WriteLine("Lütfen isim giriniz:   ");
            user.Ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:   ");
            user.Soyad = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarasını giriniz:   ");
            int.TryParse(Console.ReadLine(), out int numara);
            user.No = numara;
            return user;
        }

        private static void ReturnMainMethod(List<User> users, int islemler = 0)
        {
            if((islemler != (int)RehberIslemleri.List) && (islemler != (int)RehberIslemleri.Search))
                Console.Clear();
            MainMethod(users);
        }
    }

    class User
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int? No { get; set; }
    }

    enum RehberIslemleri
    {
        Undefined = 0,
        NewUser,
        DeleteUser,
        UpdateUser,
        List,
        Search
    }
}
