using System;

namespace Program
{
    class Karakter_Sabitleri
    {
        static void Main(string[] args)
        {
            //BasitDegiskenOrnegi();
            string ifade = "\nBTK \nAkademi \nProgramlama \nOgreniyorum."; //alt alta
            string ifade2 = "\tBTK \tAkademi \tProgramlama \tOgreniyorum."; //bosluk
            string ifade3 = "\aBTK \tAkademi \tProgramlama \tOgreniyorum."; //alrm
            System.Console.WriteLine(ifade);
            System.Console.WriteLine(ifade2);
            System.Console.WriteLine(ifade3);

            Console.ReadKey();
        }
        private static void BasitDegiskenOrnegi()
        {
            int sayi = 3;
            System.Console.WriteLine(sayi);
            System.Console.WriteLine(sayi + 2); //3+2 = 5
            System.Console.WriteLine(sayi * sayi); /*Karesi*/ 
            System.Console.WriteLine(sayi -5 );
        }
    }
}