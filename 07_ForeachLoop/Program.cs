using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //foreach(1;2;34)

            //1:Değişken Türü
            //2:Değişken adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 5, 54, 457, 65, 546546, 45, 54, 2, 27, 752, 7, 782, 7527 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 2, 5, 54, 457, 65, 546546, 45, 54, 2, 27, 752, 7, 782, 7527 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 1, 2, 5, 54, 457, 65, 546546, 45, 54, 2, 27, 752, 7, 782, 7527 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);



            //List<int> list = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //} 



            #endregion

            #region Örnek Sınav Sistemi

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();

            ////sınıfdaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("-----------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentCount= int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------------");

            ////öğrenci isilerinin ortalamları saklıyacak diziler
            //string [] studentNames= new string[studentCount];
            //double[] studentExamAvg= new double[studentCount];


            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her öğrenci için 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınavı notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;//notları topluyoruz
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            ////Sınav ortalamaları 

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("-----------------------------------");

            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]} ");

            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }
            //    Console.WriteLine("-----------------------------------");
            //}



            #endregion

            Console.Read();
        }
    }
}
