using System;
namespace Donguler_1_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anlaşılması en kolay olan while ile başlıyoruz while = iken demek
            int i =0;
            int sayac = 0; //Döngü kaç kere dönece bakalım
            while (i<10)
            {   
                sayac++;// ifade sonsuza doğru saymaya başlatır İpucu:durudurmak için ctrl+c
                System.Console.WriteLine(sayac);
                i++;//döngü ilerlesin diye. Arttırıma gitmezsek sonsuza gider yukardaki tanımlama bir işe yaramaz bu sayacın artmasıda lazım
            }
            System.Console.WriteLine("Döngü Sonu");
            Console.ReadKey();
        }
    }
}