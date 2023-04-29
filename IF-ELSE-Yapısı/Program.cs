using System;
namespace IF_ELSE_Yapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tek-Çift
            System.Console.WriteLine("Bir Sayı Giriniz....");
            int sayi =Convert.ToInt32(Console.ReadLine());
            if (sayi%2==0)
            {
                System.Console.WriteLine($"{sayi} çift bir sayıdır.");
            }
            else 
                System.Console.WriteLine($"{sayi} tek bir sayı girdiniz");
            
            //Mutlak Deger İçin
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<0)
            {
                Console.WriteLine($" |{n}| = {n*-1}");
            }
            else
            {
                Console.WriteLine($" |{n}| = {n}");
            }
            Console.ReadKey();
            //Örnek
            var k = (char)Console.Read();
            if (char.IsDigit(k))
            {
                System.Console.WriteLine("Rakamdır!");
            }
            else if (char.IsLower(k))
            {
                System.Console.WriteLine("Kucuk karakter");
            }
            else if (char.IsUpper(k))
            {
                System.Console.WriteLine("Buyuk karakter");
            }
            else
            {
                System.Console.WriteLine("Bilinmeyen Karakter");
            }
            System.Console.WriteLine();
            Console.ReadKey();
        }
    }
}