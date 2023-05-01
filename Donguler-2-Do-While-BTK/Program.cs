using System;
namespace Donguler_2_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac=1;
            while(sayac<=10)
            {   
                System.Console.WriteLine("{0,-3} {1,-3}",sayac,sayac*sayac); //karesinin alındığını gösteren program
                //System.Console.WriteLine("{0,5}", sayac*sayac);//5 brimlik boşluk bırakarak yazı yazar
                //System.Console.WriteLine(sayac +" ");
                //sayac= sayac +1;
                //sayac++;  sayac= sayac +1
                sayac +=1;  //sayac= sayac +1
                //HEPSİ AYNI ANLAMA GELİR
            }
            Console.ReadKey(); 
            //Bu işlemi tersertende yaptırabiliriz
            System.Console.WriteLine("**************************************************************");
            int sayac2=15;
            while(sayac2>0)
            {
                System.Console.WriteLine("{0,0} {1,0} {2,0} {3,0} {4,0}",sayac2,"x",sayac2,"=",sayac2*sayac2);
                sayac2 -=1; // sayac=sayac-1
            }
            //do-while = do ile while arasında parantezde koşul ne olursa olsun 1 kez kesin çalıştırır doğru yada yanlış fark etmeksizin. YANİ:Başlangıçta bi kez kesin çalışması gerek bir iş yapıyorsak tercih edilir
            System.Console.WriteLine("Klavyeden bir değer okuyalım ve o değere kadar olan çift sayıları yazdıralım!!!!....");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            do
            {   System.Console.WriteLine(i);
                i +=2; // i=i+2
            }while(i<=n);

            Console.ReadKey();
        }
        
    }
}