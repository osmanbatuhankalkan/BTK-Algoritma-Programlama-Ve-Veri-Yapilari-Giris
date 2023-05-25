using System;
namespace Array_List_BTK
{
    class Program
    {
        static void Main(string[] args)
        {
           //Tanımlama - Atama
           List<int> sayilar = new List<int>();
            int x = 55;
            int[] Seri = new int[] {70,80,90};
           // EKleme
           sayilar.Add(10);
           sayilar.Add(15);
           sayilar.Add(20);
           sayilar.Add(x);
           sayilar.AddRange(Seri);
           sayilar.AddRange(new int[] {40,50,60});//bu tarz eklemede yapılabilir 

           // Araya ekleme
           sayilar.Insert(4,99);
           sayilar.InsertRange(5, new int[] {80,90});//5. elemandan itibaren eklem yapar

           //Elemean atma islemi
           sayilar.RemoveAt(2);
            sayilar.RemoveAt(sayilar.IndexOf(55));//dinamik olarak silme işlemidir
              foreach (var item in Seri)
           {
            sayilar.Add(item); //var olanlara ekleme yaptık
           }
           //Dolasma
           foreach (int s in sayilar)
           {
                System.Console.WriteLine($"{s,-5}");
           }
            Console.ReadKey();
        }
    }
}