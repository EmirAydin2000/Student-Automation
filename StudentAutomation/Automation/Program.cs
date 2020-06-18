using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList OgrenciList = new ArrayList();
            ArrayList OgretmenList = new ArrayList();
            ArrayList SinifList = new ArrayList();

            School okul = new School();

            bool stop = true;

            while (stop)
            {
                Console.WriteLine("Anamenü: ");
                Console.WriteLine("1-Öğrenci işlemleri");
                Console.WriteLine("2-Öğretmen işlemleri");
                Console.WriteLine("3-Sınıf işlemleri");
                Console.WriteLine("4-Çıkış");

                string input = Console.ReadLine();


                if (input == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("Öğrenci işlemleri menüsü: ");
                        Console.WriteLine("1-Öğrenci ara");
                        Console.WriteLine("2-Öğrenci ekle");
                        Console.WriteLine("3-Öğrenci güncelle");
                        Console.WriteLine("4-Öğrenci sil");
                        Console.WriteLine("5-Öğrenci listesini ekrana yazdır");
                        Console.WriteLine("6-Üst menüye dön");

                        string inputStudent = Console.ReadLine();

                        if(inputStudent == "1")
                        {
                            Console.Write("Aramak istediğiniz Öğrenci ad ve soyad: ");
                            string arananOgrenci = Console.ReadLine();

                            bool isExist = okul.Ara(OgrenciList, arananOgrenci);

                            Console.WriteLine("Aradığınız öğrenci {0}", isExist ? "var" : "yok");
                            Console.WriteLine();
                        }
                        else if(inputStudent == "2")
                        {
                            Console.Write("Eklemek istediğiniz öğrenci ad ve soyadı: ");
                            string eklenenOgrenci = Console.ReadLine();

                            okul.Ekle(OgrenciList, eklenenOgrenci);

                            Console.WriteLine("Öğrenci Eklenmiştir");
                            Console.WriteLine();
                        }
                        else if(inputStudent == "3")
                        {
                            Console.Write("Güncellemek istediğiniz öğrenci ad ve soyadı: ");
                            string guncellenenOgrenci = Console.ReadLine();

                            Console.Write("Yeni öğrenci ad ve soyadı: ");
                            string yeniOgrenci = Console.ReadLine();

                            okul.Guncelle(OgrenciList, guncellenenOgrenci, yeniOgrenci);

                            Console.WriteLine("Öğrenci güncellenmiştir");
                            Console.WriteLine();
                        }
                        else if(inputStudent == "4")
                        {
                            Console.Write("Silmek istediğiniz öğrenci ad ve soyad: ");
                            string silincekOgrenci = Console.ReadLine();

                            okul.Sil(OgrenciList, silincekOgrenci);

                            Console.WriteLine("Öğrenci silinmiştir");
                            Console.WriteLine();
                        }
                        else if(inputStudent == "5")
                        {
                            okul.EkranaYazdir(OgrenciList);
                        }
                        else if(inputStudent == "6")
                        {
                            break;
                        }
                    }
                }
                else if(input == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("Öğretmen işlemleri menüsü");
                        Console.WriteLine("1-Öğretmen ara");
                        Console.WriteLine("2-Öğretmen ekle");
                        Console.WriteLine("3-Öğretmen güncelle");
                        Console.WriteLine("4-Öğretmen sil");
                        Console.WriteLine("5-Öğretmen listesini ekrana yazdır");
                        Console.WriteLine("6-Üst menüye dön");

                        string inputTeacher = Console.ReadLine();

                        if (inputTeacher == "1")
                        {
                            Console.Write("Aramak istediğiniz öğretmen ad ve soyad: ");
                            string arananOgretmen = Console.ReadLine();

                            bool isExist = okul.Ara(OgretmenList, arananOgretmen);

                            Console.WriteLine("Aradığınız öğretmen {0}", isExist ? "var" : "yok");
                            Console.WriteLine();
                        }
                        else if (inputTeacher == "2")
                        {
                            Console.Write("Eklemek istediğiniz öğretmen ad ve soyadı: ");
                            string eklenenOgretmen = Console.ReadLine();

                            okul.Ekle(OgretmenList, eklenenOgretmen);

                            Console.WriteLine("öğretmen Eklenmiştir");
                            Console.WriteLine();
                        }
                        else if (inputTeacher == "3")
                        {
                            Console.Write("Güncellemek istediğiniz öğretmen ad ve soyadı: ");
                            string guncellenenOgretmen = Console.ReadLine();

                            Console.Write("Yeni öğretmen ad ve soyadı: ");
                            string yeniOgretmen = Console.ReadLine();

                            okul.Guncelle(OgretmenList, guncellenenOgretmen, yeniOgretmen);

                            Console.WriteLine("öğretmen güncellenmiştir");
                            Console.WriteLine();
                        }
                        else if (inputTeacher == "4")
                        {
                            Console.Write("Silmek istediğiniz öğretmen ad ve soyad: ");
                            string silinecekOgretmen = Console.ReadLine();

                            okul.Sil(OgretmenList, silinecekOgretmen);

                            Console.WriteLine("öğretmen silinmiştir");
                            Console.WriteLine();
                        }
                        else if (inputTeacher == "5")
                        {
                            okul.EkranaYazdir(OgretmenList);
                        }
                        else if (inputTeacher == "6")
                        {
                            break;
                        }
                    }
                }
                else if(input == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("Sınıf işlemleri menüsü");
                        Console.WriteLine("1-Sınıf ara");
                        Console.WriteLine("2-Sınıf ekle");
                        Console.WriteLine("3-Sınıf güncelle");
                        Console.WriteLine("4-Sınıf sil");
                        Console.WriteLine("5-Sınıf listesini ekrana yazdır");
                        Console.WriteLine("6-Üst menüye dön");

                        string inputSinif = Console.ReadLine();

                        if (inputSinif == "1")
                        {
                            Console.Write("Aramak istediğiniz sınıf kodu: ");
                            string arananSinif = Console.ReadLine();

                            bool isExist = okul.Ara(SinifList, arananSinif);

                            Console.WriteLine("Aradığınız sınıf {0}", isExist ? "var" : "yok");
                            Console.WriteLine();
                        }
                        else if (inputSinif == "2")
                        {
                            Console.Write("Eklemek istediğiniz sınıf kodu: ");
                            string eklenenSinif = Console.ReadLine();

                            okul.Ekle(SinifList, eklenenSinif);

                            Console.WriteLine("sınıf Eklenmiştir");
                            Console.WriteLine();
                        }
                        else if (inputSinif == "3")
                        {
                            Console.Write("Güncellemek istediğiniz sınıf kodu: ");
                            string guncellenenSinif = Console.ReadLine();

                            Console.Write("Yeni sınıf kodu: ");
                            string yeniSinif = Console.ReadLine();

                            okul.Guncelle(SinifList, guncellenenSinif, yeniSinif);

                            Console.WriteLine("sınıf güncellenmiştir");
                            Console.WriteLine();
                        }
                        else if (inputSinif == "4")
                        {
                            Console.Write("Silmek istediğiniz sınıf kodu: ");
                            string silinecekSinif = Console.ReadLine();

                            okul.Sil(SinifList, silinecekSinif);

                            Console.WriteLine("sınıf silinmiştir");
                            Console.WriteLine();
                        }
                        else if (inputSinif == "5")
                        {
                            okul.EkranaYazdir(SinifList);
                        }
                        else if (inputSinif == "6")
                        {
                            break;
                        }
                    }
                }
                else if(input == "4")
                {
                    break;
                }
            }
        }
    }
}
