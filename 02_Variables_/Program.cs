using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkinler
            //Console.WriteLine("***** Fiyat Listesi *****");

            //double ApplePrice, OrangePrice, StrawberryPrice, PotataPrice, TomataPrice;

            //ApplePrice = 14.85;
            //OrangePrice = 20.95;
            //StrawberryPrice = 45;
            //PotataPrice = 8.74;
            //TomataPrice = 6.88;

            ////Console.WriteLine("----- Elma Birim Fiyatı :" + ApplePrice + " TL");
            ////Console.WriteLine("----- Portakal Birim Fiyatı :" + OrangePrice + " TL");
            ////Console.WriteLine("----- Çilek Birim Fiyatı :" + StrawberryPrice + " TL");
            ////Console.WriteLine("----- Patates Birim Fiyatı :" + PotataPrice + " TL");
            ////Console.WriteLine("----- Domates Birim Fiyatı :" + TomataPrice + " TL");


            //Double AppleGram, OrangeGram, StrawberryGram, PotataGram, TomataGram;
            //AppleGram = 1.245;
            //OrangeGram = 2.650;
            //StrawberryGram = 0.750;
            //PotataGram = 4.450;
            //TomataGram = 1.75;

            //Double AppleTotalPrice = AppleGram * ApplePrice;
            //Double OrangeTotalPrice = OrangeGram * OrangePrice;
            //Double strawberyTotalPrice = StrawberryPrice * StrawberryPrice;
            //Double PotataTotalPrice = PotataPrice * TomataPrice;
            //Double TomataTotalPrice = TomataPrice * TomataPrice;

            //Double ShopingTotalPrice = AppleTotalPrice + OrangeTotalPrice + strawberyTotalPrice + PotataTotalPrice + TomataTotalPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat : " + ApplePrice + "- Gramaj" + AppleGram + "- Toplam Tutar" + AppleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat : " + OrangePrice + "- Gramaj" + OrangeGram + "- Toplam Tutar" + OrangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat : " + StrawberryPrice + "- Gramaj" + StrawberryGram + "- Toplam Tutar" + strawberyTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat : " + PotataPrice + "- Gramaj" + PotataGram + "- Toplam Tutar" + PotataTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat : " + TomataPrice + "- Gramaj" + TomataGram + "- Toplam Tutar" + TomataTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar = " + ShopingTotalPrice + " TL");



            //Console.ReadLine();


            #endregion

            #region Char Değişkenler

            //Char Symbol;
            //Symbol = 'a';
            //Console.WriteLine(Symbol);

            //Console.Read();


            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgileri");
            //String PassengerName, PassengerSurname, PassengerDistrinct, PassengerCity, PassengerAge, PassengerID;



            //Console.Write("Yolcu Adı : ");
            //PassengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı : ");
            //PassengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi : ");
            //PassengerDistrinct = Console.ReadLine();
            //Console.Write("İl bilgisi : ");
            //PassengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş bilgisi : ");
            //PassengerAge = Console.ReadLine();
            //Console.Write("Yolcu Tc No : ");
            //PassengerID = Console.ReadLine();


            //Console.WriteLine("--------------------------------");

            //Console.WriteLine("Yolcu Adı Soyadı : " + PassengerName + " " + PassengerSurname );
            //Console.WriteLine("");
            //Console.WriteLine("Yolcu İlçe Bilgisi : "+ PassengerDistrinct + " " + "/ Yolcu İl bilgisi : " + PassengerCity);
            //Console.WriteLine("");
            //Console.WriteLine("Yolcu Yaş Bilgisi : " + PassengerAge + " " + "/ Yolcu Tc Bilgisi :" + PassengerID);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int ShoesPrice, ComputerPrice, ChairPrice, TvPrice;
            //ShoesPrice = 1000;
            //ComputerPrice = 20000;
            //ChairPrice = 5000;
            //TvPrice = 12000;

            //int ShoesCount, ComputerCount, ChairCount, TvCount;

            //Console.WriteLine("Lütfen Aldığınız Ayakkabı Sayısını Giriniz : ");
            //ShoesCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Bilgisyar Sayısını Giriniz : ");
            //ComputerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Koltuk Sayısını Giriniz : ");
            //ChairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Tv Sayısını Giriniz : ");
            //TvCount = int.Parse(Console.ReadLine());

            //int TotalPrice;

            //TotalPrice = ShoesPrice* ShoesCount + ComputerPrice*ComputerCount + TvPrice*TvCount + ChairPrice*ChairCount ;

            //Console.WriteLine("Toplam tutar : " + TotalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı Girişi

            //Double Exam1, Exam2, Exam3;

            //Console.Write("!. Sınav Notunu Giriniz : ");
            //Exam1 = Double.Parse(Console.ReadLine());

            //Console.Write("!. Sınav Notunu Giriniz : ");
            //Exam2 = Double.Parse(Console.ReadLine());

            //Console.Write("!. Sınav Notunu Giriniz : ");
            //Exam3 = Double.Parse(Console.ReadLine());

            //Double Result;

            //Result = (Exam1 + Exam2 + Exam3) /3 ;
            //Console.WriteLine("");
            //Console.WriteLine("Ortalama Notunuz : " +Result);


            #endregion


            #region Klavyeden Karakter Girişleri

            Char Gender;

            Console.Write("Lütfen Cinsiyet Seçiniz : ");

            Gender = Char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet : " + Gender);


            #endregion


            Console.Read();
        }
    }
}
