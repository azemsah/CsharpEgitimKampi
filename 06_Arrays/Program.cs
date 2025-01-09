using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region temel dizi örnekleri
            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[Eleman Sayıs]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Mavi";
            //colors[3] = "Beyaz";

            //Console.WriteLine(colors[3]);


            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];

            //numbers[0] = 40;
            //numbers[1] = 60;
            //numbers[2] = 20;
            //numbers[3] = 30;
            //numbers[7] = 40;
            //Console.WriteLine(numbers[7]);


            //string[] city = { "ankara", "istanbul", "bursa", "adana" };
            //Console.WriteLine(city[2]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Mavi", "Lacivert", "Beyaz", "Yeşil" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //for (int i = 0; i < numbers.Length; i++)
            //{ if (numbers[i] % 3 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }        
            //}



            //char[] symbols = { 'a', 'b', 'c' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 15, 30, 100, 45, 88, 150, 400, 290 };
            //int maxnumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxnumber)
            //    {
            //        maxnumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxnumber);


            //int[] numbers = { 45, 65, 15, 25, 5, 35 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion
            #region Dizi Metotları


            //int[] numbers = { 45, 65, 15, 25, 5, 35 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //string[] customers = { "ali", "buse", "ahmet", "veli", "ayşe" };
            //int index = Array.IndexOf(customers, "veli");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 65, 15, 25, 5, 35 };
            //Console.WriteLine("Dizinin En Büyük Elemanı : " +numbers.Max() + " Dizinin en küçük elemanı : " +numbers.Min() )   ;



            #endregion

            #region Klavyeden veri girişi ile dizi oluşturmak

            //string[] cities = new  string[6];
            //for (int i = 0; i < cities.Length; i++)

            //{
            //    Console.WriteLine($"Lütfen {i + 1}. Şehri Giriniz");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------");

            //for (int i = 0; i < cities.Length; i++)

            //{
            //    Console.WriteLine(cities[i]);

            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}


            //Console.WriteLine(sum); 



            //int[] numbers = { 21, 32, 43, 54, 65, 886, 17, 88, 49, 220 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine("-------------------");

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion



            Console.Read();

        }
    }
}
