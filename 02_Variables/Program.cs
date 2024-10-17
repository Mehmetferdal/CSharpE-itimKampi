using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Lİstesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;


            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("------ Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("------ Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("------ Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("------ Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("------ Domates Birim Fiyatı: " + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("ALınan Ürün : Elma - " + " Birim Fiyat: " + applePrice + "- Gramaj: " + appleGram + "- Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("ALınan Ürün : Portakal - " + " Birim Fiyat: " + orangePrice + "- Gramaj: " + orangeGram + "- Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("ALınan Ürün : Çilek - " + " Birim Fiyat: " + strawberryPrice + "- Gramaj: " + strawGram + "- Toplam Tutar: " + strawTotalPrice);
            //Console.WriteLine("ALınan Ürün : Patates - " + " Birim Fiyat: " + potatoPrice + "- Gramaj: " + potatoGram + "- Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("ALınan Ürün : Domates - " + " Birim Fiyat: " + tomatoPrice + "- Gramaj: " + tomatoGram + "- Toplam Tutar: " + tomatoTotalPrice);

            //Console.WriteLine();
            //Console.WriteLine();


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "TL");


            #endregion

            #region Char Değişkenler

            //char symbol;

            //symbol = 'A';

            //Console.WriteLine(symbol);



            #endregion

            #region Klavyeden Veri Girişleri Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();


            //string passengerName, passengerSurName, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.WriteLine("Yolcu Adı: ");
            //passengerName = (Console.ReadLine());


            //Console.WriteLine("Yolcu SoyAdı: ");
            //passengerSurName = Console.ReadLine();

            //Console.WriteLine("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine("Yolcu TC Kimlik NO: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------");


            //Console.WriteLine("Yolcu TC Kimlik No:" + passengerIdentityNumber + "-Yolcu Ad Soyad:" + passengerName + " " + passengerSurName + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);





            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount,tvCount;

            //Console.WriteLine("Lütfen Aldığınız ayakkabı sayısını giriniz ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Bilgisayar sayısını giriniz ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Sandalye sayısını giriniz ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Tv sayısını giriniz ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice= shoesCount*shoesPrice+computerCount*computerPrice+ chairCount*chairPrice+tvCount*tvPrice;
            //Console.WriteLine("");


            //Console.WriteLine("Toplam:"+totalPrice);




            #endregion

            #region Ondalıklı Sayı İşlemleri


            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1.Sınav Notunuz Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.Sınav Notunuz Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3.Sınav Notunuz Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız:  "+result);


            #endregion

            #region Klavyeden Karakter Girişleri


            //char gender;
            //Console.WriteLine("Lütfen Cinsiyer seçiniz: ");
            //gender =char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyet Seciniz: "+gender);




            #endregion


            Console.Read();
        }
    }
}
