using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Forecha(1;2;3;4) parametre alır
            // 1 : Değişken Türü
            // 2 : Değişken Adı
            // 3 : In
            // 4 : Liste , koloksiyon, dizi

            //string[] cities = { "ankara", "istanbul", "bursa", "adana", "bolu" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 10, 20, 35, 42, 68, 75, 14, 8 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }




            //int[] numbers = { 10, 20, 35, 42, 68, 75, 14, 8 };
            //int total=0;

            //foreach (int i in numbers)
            //{
            //    total += i;

            //}
            //Console.WriteLine(total);




            //List<int> numbers = new List<int>()
            //{ 1,2,2,4,5};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}






            #endregion



            #region Örnek Sınav sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            int studenCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //çrenci notlarını ve ortalamalarını saklıyacak diziler
            string[] StudentNames = new string[studenCount];
            double[] StudentExamAvg = new double[studenCount];

            for (int i = 0; i < studenCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin İsmini Giriniz : ");
                StudentNames[i] = Console.ReadLine();

                double TotalExamResult = 0;

                //Her Öğrenci İçin 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {StudentNames[i]} isimli öğrencin {j + 1} . sınav notunu giriniz  ");
                    double value = double.Parse(Console.ReadLine());
                    TotalExamResult += value;// notları topluyoruz
                    Console.WriteLine();

                    
                }
                StudentExamAvg[i] = TotalExamResult / 3;
            }

            // Sınav Ortalamaları

            for (int i = 0;     i < studenCount;i++)
            {

                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"{StudentNames[i]} isimli öğrencinin ortalaması {StudentExamAvg[i]}");

                //örencilerin ortalaması ve geçip kalma durumları
                if (StudentExamAvg[i] > 50)
                {
                    Console.WriteLine($"{StudentNames[i]} adlı öğrenci dersten geçti ");

                }
                else
                {

                    Console.WriteLine($"{StudentNames[i]} adlı öğrenci dersten kaldı ");
                }
                }

            Console.WriteLine("----------------------------------------------");


            #endregion

            Console.Read();
        }
    }
}
