using System;
using System.Collections.Generic;

namespace Metotlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            int buyuk = Karsilastir(3,5);
            System.Console.WriteLine(buyuk);
            
            var x = KareAl(3);
            double y = KareAl(x);

            System.Console.WriteLine(x);
            System.Console.WriteLine(y);

            Console.ReadKey();


        }
        public static int Karsilastir(int A, int B)
        {
            if(A>B)
            {
                return A;
            }
            else
            {
                return B;
            }
        }
        static double KareAl(double sayi)
        {
            double kare = sayi*sayi;
            return kare;
        }
    }
}