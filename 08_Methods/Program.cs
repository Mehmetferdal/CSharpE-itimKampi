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
            #region Metotlar

            //()
            //Geri Değer Döndürmeyen Metotlar
            // customer --> listele, ekle, sil , güncelle
            //void

            //void CustomerList()
            //{
            //    Console.WriteLine("Mehmet Tıldız");  
            //    Console.WriteLine("Şaban Can");  
            //    Console.WriteLine("Hakan Yıldız");  
            //    Console.WriteLine("Merve Aksoy");  
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 4;
            //    int z = x+y;

            //    Console.WriteLine(z);

            //}
            //Sum();




            #endregion

            #region Geri Değer Döndürmeyen Parametreli Metotlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Ahmet İlhan");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine(  "Müşteri:"+ name + " "+surName);
            //}

            //CustomerCard("ferdal", "ateş");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(1, 5, 2);



            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren  String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "-Başkent: " + capital + "- Bayrak" + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengi Giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geri Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result=number1+number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(5, 9));
            //Console.WriteLine(Sum(8, 10));
            //Console.WriteLine(Sum(15, 13));



            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli Öğrenci sınavı geçti" + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli Öğrenci sınavı gecemedi" + "Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ferdal", 25, 35, 21));
            #endregion



            Console.Read();
        }
    }
}
