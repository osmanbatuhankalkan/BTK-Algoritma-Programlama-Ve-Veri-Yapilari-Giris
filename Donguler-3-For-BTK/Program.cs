using System;
namespace Donguler_3_For
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*for (int i = 0; i <=100; i+=5)
            {
            System.Console.WriteLine(i);
            }
            Console.ReadKey();
            System.Console.WriteLine("******************************************");
            System.Console.WriteLine("Bu İşlemi Tersine Yapalım");
            for (int i =100; i>=0; i-=5)
            {
                System.Console.WriteLine(i);
            }
            Console.ReadKey();*/
            /*
            int i=0;
            for(;i<=10;i++)
            {
                if(i%2 ==0)
                {
                    continue;//aslında değerlerimiz çift fakat continue hep bir üstte atlatıyor
                }
                Console.WriteLine(i);
                if(i==5)
                {
                    break;//Döngünün sonuna geldik demek diyip döngüyü kırıyor
                }
            }*/
            //iç içe Döngülerde dıştakı döngü içteki döngüye çarpan olarak gelir. Yani dış 5 kere dönerse içte 5 kere döner
            int n =5;

            for(int i = 0; i<n; i++)
            {
                for(int j=0;j<n;j++)
                {   
                    System.Console.WriteLine("{0,0} {1,0} ",i,j);
                    System.Console.WriteLine(" * ");//5sutun 5 blok
                }
                System.Console.WriteLine();
            }
            Console.ReadKey();
            int k= int.Parse(Console.ReadLine());
            for(int i =0; i<k;i++)
            {
                for (int j =0;j<=i;j++)
                {
                    System.Console.WriteLine("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}
