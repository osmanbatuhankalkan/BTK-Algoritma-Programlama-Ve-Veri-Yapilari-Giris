using System;
namespace Program
{   
    public class Program
    {
        static void Main(string[] args)
    {   
        //TİP
        int sayi1;
        double pi = 3.14;
        char secim = 'e';
        string isim = "zafer";
        bool dogruMu = false;

        string isim2 = "Ahmet";
        System.Console.WriteLine("Merhaba " + isim2 + ". ");//cw+tab ile kısa yoldan console.writeline yazdırırsın
        System.Console.WriteLine("Merhaba Sayın..." + isim2 + ". ");
        Console.ReadKey();
        // fark ettiysek isim adlı değişken tanımladık 2 kere kullandık

        int sayiDeneme = 5;
        System.Console.WriteLine(sayiDeneme);
        System.Console.WriteLine(sayiDeneme + 2);
        System.Console.WriteLine(sayiDeneme * sayiDeneme);
        System.Console.WriteLine(sayiDeneme - 5);
    }

    }
    
}