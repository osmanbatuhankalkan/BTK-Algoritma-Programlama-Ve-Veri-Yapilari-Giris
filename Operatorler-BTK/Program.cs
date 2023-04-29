using System;
namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
    {
        int A=20, B=10;

        //Aritmetik Operatörler
        Console.WriteLine(A+B);
        Console.WriteLine(A-B);
        Console.WriteLine(A*B);
        Console.WriteLine(A/B);
        Console.WriteLine(A%B);
        Console.ReadKey();

        //İlişkisel Operatörler
        System.Console.WriteLine(A>B);
        System.Console.WriteLine(A<B);
        System.Console.WriteLine(A>=B);
        System.Console.WriteLine(A<=B);
        System.Console.WriteLine(A==B);
        System.Console.WriteLine(A!=B);
        Console.ReadKey();

        System.Console.WriteLine(A>B && A>5); //VE
        System.Console.WriteLine(A>B && A<5);  //VE
        System.Console.WriteLine(!(A>B && A<5)); //VE
        System.Console.WriteLine(A<B || B>5); //VEYA
        Console.ReadKey();
            }

    }
    
}