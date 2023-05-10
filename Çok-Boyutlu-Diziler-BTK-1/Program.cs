using System;
using System.Collections.Generic;

namespace BTKCokboyutluDiziler
{   
    //Boyut bilgisini dışarıdan alacağız ve random oluşturacağımız bir sistem yapıcaz aynı zamanda bu random değerlerinde karesini alıcaz
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Dizi boyutunu giriniz:  ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[boyut];
            var r = new Random();

            for(int i=0;i <sayilar.Length ;i++)
            {
                sayilar[i] = r.Next(1,10);//kavramı rastgele ifade üretir
            }

            foreach (var s in sayilar)//foreach koleksiyonlar üzerinde gezinmek için kullanılır (koleksiyonlar sadece diziler değildir)
            {
                System.Console.WriteLine($"{s,5} {s*s,5}");
            }
            Console.ReadKey();
        }
    }
}