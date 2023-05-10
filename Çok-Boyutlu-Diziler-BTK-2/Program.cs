using System;
using System.Collections.Generic;
namespace CokBoyutluDiziler_2_BTK
{
    class Program
    {
        static void Main(string[] args)
        {   
            double [,] matris = new double[,] 
            { 
                {1,2,3 }, 
                {2,3,4},
                {3,4,5}
            };//böyle bir matris için 2 tane dönüye ihtiyacımız olacaktır

            double toplam =0;//a)buradayı matris toplamı için yaptık
            
            for (int i = 0; i <matris.GetLength(0); i++)//bu yapı dinamiktir ne kadar değişirse değişsin çalışır çünkü SÜTUN bilgisine göre çalışıyor. Bunu da GetLengthle sağlıyor
            {
                for (int j = 0; j <matris.GetLength(1); j++)//bu yapı dinamiktir ne kadar değişirse değişsin çalışır çünkü SATIR bilgisine göre çalışıyor Bunu da GetLengthle sağlıyor
                {   
                    if(i==j)
                    {
                        matris[i,j] = -1; //(0,0),(1,1),(2,2) olanları bulup -1 oalrak işaretler
                            
                    }

                    if(matris[i,j]%2==0)
                    {
                         matris[i,j] = 0; //2 ye bölünen değerlerini 0 yap işaretle
                    }

                    toplam += matris[i,j];//a)buradayı matris toplamı için yaptık
                    System.Console.WriteLine($"{matris[i,j],5}");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine($"Toplam: {toplam}");//a)buradayı matris toplamı için yaptık
            Console.ReadKey();
        }
    }

}