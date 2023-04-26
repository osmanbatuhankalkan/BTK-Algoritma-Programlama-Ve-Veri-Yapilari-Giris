using System;
namespace Dize_degismezleri_ve_Sabit_Tanimlama
{
    class Program
    {
        static void Main(string[] args)
        {   
            var ifade = "Merhaba Programlama Dünyasi.";
            System.Console.WriteLine(ifade);
            System.Console.WriteLine(ifade.Length);//uzunluğunu alacak ifadenin
            System.Console.WriteLine(ifade.ToUpper());// büyüterek vesin
            System.Console.WriteLine(ifade.ToLower());//kücülterek versin
            System.Console.WriteLine(ifade.TrimStart());//baştaki boşlukları kessin
            System.Console.WriteLine(ifade.TrimEnd());//sondaki boşlukları kessin
            System.Console.WriteLine(ifade.Trim());//hem baş hem sonraki ifadeleri kessin
            System.Console.WriteLine(ifade[0]);//ilk karakteri alır
            System.Console.WriteLine(ifade[1]);//ikinci karakteri alır
            System.Console.WriteLine(ifade[ifade.Length-1]);//son karakteri alır
          OrtuluDegiskenTanimi();
          Console.ReadKey();
        }
        private static void OrtuluDegiskenTanimi()
        {
            //örtülü değişken tanımı
            var ifade = Console.ReadKey();//değişken türünü tahmin edemeyeceğimiz zamanlarda tercih edilir
           System.Console.WriteLine(ifade);
           System.Console.WriteLine(ifade.Key);
           System.Console.WriteLine(ifade.KeyChar);
            //string ifade = Console.ReadLine(); //klavyeden gelenleri okur bunu Console.ReadLine Yapar
            //Console.ReadKey();
        }
    } 
}