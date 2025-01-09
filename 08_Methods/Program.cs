using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //// Geriye değer döndürmeyen metotlar
            //// Örneğin Customer ---> Listele, ekle , sil , güncelle metotları olabilir
            //// Void anahtar kelimesi ile tanımlanır.


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Veli");
            //    Console.WriteLine("Ahmer Çelik");
            //    Console.WriteLine("Ayşe MErve");
            //    Console.WriteLine("Begüm Düz");
            //}

            //// CustomerList metodunu aşağıdaki gibi çağırıp çalıştırabiliriz.

            //CustomerList();


            // Metotlar sayısal işlemler içinde kullanılabilir.

            //void Summ()
            //{
            //    int x = 1;
            //    int y = 3;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Summ();





            #endregion


            #region Geriye Değer Döndürmeye String Parametreli Metotlar

            //void WriteMethod(string CustomerName)
            //{

            //    Console.WriteLine(CustomerName);
            //}

            //WriteMethod("Azem Arslan");

            //void CustomerCard(string name, string SurName)
            //{

            //    Console.WriteLine("Adı : " + name + " " + "Soyadı : " + SurName);
            //}

            //CustomerCard("Ali", "Veli");
            //CustomerCard("Ayşe", "Merve");


            #endregion

            #region Geriye Değer Döndürmeye İnt Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 2, 3);

            #endregion

            #region Geriye değer döndüren methotlar

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());



            #endregion

            #region Geriye değer döndüren string parametreli methotlar 

            //string CountryCard(string CountryName, string Capital, string FlagColor)
            //{

            //    string cardInfo = ("Ülke : " + CountryName + " Başkent : " + Capital + " Bayrak Rengi : " + FlagColor);

            //    return cardInfo;
            //}
            //    string x, y, z;
            //    Console.WriteLine("Ülke adı giriniz : ");
            //    x = Console.ReadLine();
            //    Console.WriteLine("Başkenti Giriniz : ");
            //    y = Console.ReadLine();
            //    Console.WriteLine("Bayrak Rengi Giriniz : ");
            //    z = Console.ReadLine();

            //    Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye değer döndüren int parametreli methotlar 

            //int sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //        return result;

            //}
            //Console.WriteLine(sum(11, 25));
            //Console.WriteLine(sum(45, 77));
            //Console.WriteLine(sum(44, 21));

            #endregion




            #region Örne Uygulama
            string ExamResult(string Name, int exam1, int exam2, int exam3)
            {

                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return Name + "Adlı Öğrenci Başarılı" + "Not Ortalaması = " + result;

                }
                else
                {
                    return Name + "Adlı Öğrenci Başarısız" + "Not Ortalaması = " + result;

                }
                
            }
            Console.WriteLine(ExamResult("Ali ", 50, 60, 40));
            Console.WriteLine(ExamResult("Veli ", 50, 30, 40));

#endregion  

            Console.Read();



        }
    }
}
