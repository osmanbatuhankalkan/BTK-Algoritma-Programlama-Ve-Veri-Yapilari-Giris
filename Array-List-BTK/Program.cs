using System;
namespace Array_List_BTK
{
    class Program
    {
        static void Main(string[] args)
        {
           //Tanımlama
           var arrayList = new ArrayList(){
            10,"BTK Akademi",true, 'e'};
            /*
           //Ekleme
           arrayList.Add(10);//boxing
           arrayList.Add("BTK Akademi");
           arrayList.Add(true);
           arrayList.Add('e');
            */
           //Dolaşma
           foreach (var e in arrayList)
           {
            System.Console.WriteLine($"{e}");
           }
           
           int[] sayilar = new int[] {23,44,55};
           arrayList.AddRange(sayilar);

           //Dolaşma
           System.Console.WriteLine();
           foreach (var e in arrayList)
           {
            System.Console.WriteLine($"{e}");
           }
           System.Console.WriteLine();

           //Elemana Erişme
           System.Console.WriteLine(arrayList[4]);

           //Elemana erişme - atama
           int x = (int)arrayList[0];//kutudan çıkarma
           System.Console.WriteLine(x+10);

           //Eleman Sİlme
           //arrayList.Remove(10);
           //arrayList.RemoveAt(1);
           arrayList.RemoveRange(3,3);
           //Dolaşma
           System.Console.WriteLine();
           foreach(var e in arrayList)
           {
            System.Console.WriteLine($"{e}");
           }

           Console.ReadKey();

        }
    }
}