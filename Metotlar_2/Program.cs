using System;
using System.Collections.Generic;

namespace Metotlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Metod-1 de karsılastır ve kare alda sırasıyla 2 ve 1 adet parametre tanımlamıştık fakat bu parametreleri kendimiz manuel tanımlamamız bize esneklik sağlamamakta.Biz şimdi metod-2 de ana amacımız bu parametreleri dinamik hale getireceğiz
            int buyuk = Karsilastir(3,5);
            System.Console.WriteLine(buyuk);
            
            var x = KareAl(3);
            double y = KareAl(x);

            System.Console.WriteLine(x);
            System.Console.WriteLine(y);

            double toplam = SeriToplami(5.27,15.33,56.98);
            System.Console.WriteLine("{0,5:0.##}",toplam);
            //dönüştürü double olduğu için return döndürmemiz gerekecek 
            Console.ReadKey();
        }
        private static double SeriToplami(params double[] seri)
        { 
            //Yukarıda gördüğümüz "params" bize 20.kod satırında SeriToplami kısmına ekleme yaptığımız zaman buradaki 25.satırda açtığımız private static double seri toplamının içine tür ve değer adı tanımlama kısıtlamasından kurtarıyor.
            
            double toplam =0;
            foreach(double s in seri)
                toplam +=s;
            return toplam;
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