using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF Else

            //Console.Write(" Lütfen Şifre giriniz : ");
            //String Password;
            //Password = Console.ReadLine();

            //if (Password == "abcd")

            //{
            //    Console.WriteLine("Şifre doğru");

            //}

            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;

            //capital = "ankara";
            //country = "türkiye";
            //Console.Write("lütfen başkenti giriniz : ");
            //capital = Console.ReadLine();
            //Console.Write("lütfen Ülkeyi giriniz : ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write(" girilen bilgiler doğru");
            //}
            //else
            //{
            //    Console.Write("Girilen bilgiler hatalı");

            //}


            //int number;

            //Console.WriteLine("Sayıyı Giriniz : ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}

            //int exam1, exam2, exam3, avarage;
            //string result = "Hata";

            //Console.WriteLine("Sınav1 : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav2 : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların ortalaması : " + avarage);

            //if (avarage > 0 & avarage < 50 )
            //{
            //    result = (" Sonuç kötü");
            //}
            //if (avarage > 50 & avarage < 75)
            //{
            //    result = (" Sonuç orta");
            //}
            //if (avarage > 75 )
            //{
            //    result = (" Sonuç iyi");
            //}

            //Console.WriteLine(result);

            //string city;

            //Console.WriteLine("Şehir girişini yapınız : ");
            //city = Console.ReadLine();

            //if (city == "ankara" | city == "bursa" | city == "adana" )
            //{
            //    Console.WriteLine("şehir mevcut");

            //}
            //else 
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.WriteLine("kullanıcı adını giriniz : ");
            //string username = Console.ReadLine();

            //if (username!="admin")
            //{
            //    Console.WriteLine("kullanıcı hatalı");
            //}
            //else
            //{
            //    Console.WriteLine("Holgeldiniz");
            //}



            #endregion



            #region Mod işlemleri

            //int number;
            //Console.WriteLine("Lütfen 1. Sayıyı Giriniz : ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. Sayıyı Giriniz : ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1 ci sayının 2 ci sayıya bölümünden kalan sayı : " + result);



            //Console.WriteLine("lütfen sayıyı giriniz : ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}
            #endregion

            #region Char değişkeni ile karar yapıları
            //           char team;
            //           Console.WriteLine("lütfen takımınızın ilk harfini giriniz : ");
            //           team = char.Parse(Console.ReadLine());

            //           if (team == 'b' | team == 'B')
            //           {
            //               Console.WriteLine("Girilen Takım : Beşiktaş");
            //           }

            //           else

            //if (team == 'f' | team == 'F')
            //           {
            //               Console.WriteLine("Girilen Takım : Fenerbahçe");
            //           }


            //           else

            //if (team == 'g' | team == 'G')
            //           {
            //               Console.WriteLine("Girilen Takım : Galatasaray");
            //           }

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- İçecekler");
            //Console.WriteLine("4- Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(" Detayını Görmek İstediğiniz Menüyü Seçiniz : ");
            //string menuitem = Console.ReadLine();

            //if (menuitem == "1")
            //{
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine("1- Tavuk Sote");
            //    Console.WriteLine("2- Fasulye");
            //    Console.WriteLine("3- Et Sote");
            //    Console.WriteLine("4- Pilav");
            //}
            //if (menuitem == "2")
            //{
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine("1- EzoGelin");
            //    Console.WriteLine("2- Mercimek");
            //    Console.WriteLine("3- İşkembe");

            //}
            //if (menuitem == "3")
            //{
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //}
            //if (menuitem == "4")
            //{
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine("1- Baklava");
            //    Console.WriteLine("2-Sütlaç");
            //}


            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi Yapınız : ");
            //int MounthNumber = int.Parse( Console.ReadLine());

            //switch (MounthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;

            //    default: Console.WriteLine("Hatalı giriş yaptınız"); break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2,result;
            //char symbol;

            //Console.Write("1. Sayıyı Giriniz : ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz : ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz = " );
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+' :
            //        result = number1 + number2;
            //    Console.WriteLine("Girdiğiniz Sayıların Toplamı = "+ result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Girdiğiniz Sayıların Farkı = " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Girdiğiniz Sayıların Çarpımı = " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Girdiğiniz Sayıların Bölümü = " + result);
            //        break;
            //}
               

                
           
            #endregion


            Console.Read();


        }
    }
}
