using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            // for (x,y,z) 3 tane parametre alır
            // x: başlangıç değeri
            // y: Bitiş değeri
            // z: artış yada azalış bilgisi

            //int i;

            //for ( i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(" C# Eğitim Kampı");
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 50; i += 3) // 3 le toplayıp getiriyor
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz : ");

            //int FinishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= FinishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion

            #region For döngüsü ile karar yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}


            //int TotalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    TotalValue += i;

            //}

            //Console.WriteLine(TotalValue);

            //int TotalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        TotalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(TotalValue);

            //int bacterium = 1;

            //for (int i = 0; i <= 24; i++)
            //{

            //    bacterium *= 2;
            //    Console.WriteLine(i + "Saat Sonunda Toplam Bakteri Sayısı : " + bacterium);
            //}

            #endregion


            #region While Döngüsü  
            // şart sağlandığında
            // While(Şart)
            //{
            // işlemler
            //}
            //int i=1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;
            //}


            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;

            //}
            //Console.WriteLine(sum);

            Console.Write("Sayıyı Giriniz : ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10 ;
            hundreds = number / 100;

            Console.WriteLine(ones);

            Console.WriteLine(tens);
            Console.WriteLine(hundreds);


            sum = ones+tens+hundreds;
            Console.WriteLine("Basamakların Toplamı = " + sum);


            #endregion








            Console.Read();

        }
    }
}
