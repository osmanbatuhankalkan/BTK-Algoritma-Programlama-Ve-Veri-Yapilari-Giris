using System;
namespace Deger_ve_Referans_Tipler
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = 10;
           int y = 20;
           System.Console.WriteLine("{0},{1}",x,y);
           Degistir(x,y);//bu kısımda uygulandı
           System.Console.WriteLine("{0},{1}",x,y);
           Console.ReadKey();

           int k = 100;
           int l = 200;
           System.Console.WriteLine("{0},{1}",k,l);
           Degistir2(ref k,ref l);//bu kısım refernsa göre çalıştı çıktıya göre değil bı yüzden yukardaki örnekten farklı oldu
           System.Console.WriteLine("{0},{1}",k,l);
           Console.ReadKey();

        }

        private static void Degistir(int a, int b)
        {
            int gecici = a;
            a= b;
            b = gecici;
            System.Console.WriteLine("{0},{1}",a,b);
        }
         private static void Degistir2(ref int k, ref int l)
        {
            int gecici2 = k;
            k= l;
            l = gecici2;
            System.Console.WriteLine("{0},{1}",k,l);
        }
    }
}