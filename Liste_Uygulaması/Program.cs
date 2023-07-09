using System;
using System.Collections;
using System.Collections.Generic;

namespace Liste_Uygulamaları
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Van",
                "Samsun",
                "Ordu",

            };

            foreach (string s in sehirler)
            {
                System.Console.WriteLine(s);
            }
            //Yukarıdaki foreach döngüsünü şöylede yazabiliriz.
            //Lambda Expression
            System.Console.WriteLine("**********************");
            sehirler.ForEach(s=>System.Console.WriteLine(s));
            //Şimdi ikili liste tanımı yapalım, elimizdeki listeden yeni bir liste oluşturalım.
            System.Console.WriteLine("**********************");
            var iller = sehirler;//Örtülü Liste şeklinde oluşturduk yeni listemizi
            iller.ForEach(i=>System.Console.WriteLine(i));//sehirler ile aynı çıktıyı alırız.
            System.Console.WriteLine("**********************");
            //Şimdi ise bir listemize ekleme yapalım ve bakalım diğer listemizde de herhangi bir değişiklik olacak mı ?
            sehirler.Add("Antalya");
            sehirler.ForEach(s =>System.Console.WriteLine(s));
            System.Console.WriteLine("**********************");
            System.Console.WriteLine("Sehirler kısmına ekleme oldu bide iller listemizi kontrol edelim");
            iller.ForEach(i =>System.Console.WriteLine(i));
            System.Console.WriteLine("Görüyoruzki iller listemizede ekleme yapılmış. Peki illere herhangi bir ekleme yapmadan sadece sehirler üzerinden yaptığımız ekleme illerde de nasıl tanımlandı ?");
            System.Console.WriteLine("#######################################################");
            System.Console.WriteLine("Bunu şöyle düşünebiliriz: Oluşturduğumuz sehirler ve iller adlı listeler STACK te referans türlü olarak tutuluyor.Şehirlerde oluşturduğumuz string türlü değelerimiz ise HEAP yapısında tutuluyor. Biz Yukarıda 'var iller = sehirler;' diyerek sehirlerin referans olarak işaret ettiği veri kümesine yaratmış olduğumuz iller listesinin de orayı yani sehirlerin HEAP indeki verileri referans olarak işaretlemesini sağlıyoruz. Buna 'REFERANS TİP' denmekte. ");
            System.Console.WriteLine("********************************************************");
            System.Console.WriteLine("Bu Listeler tek bir veri kümesini işaret ettiği için, veri kümesindeki herhangi bir değişiklik ekleme, çıkarma gibi o veri kümesini işaretlediği ,referans aldığı için oradaki değişiklik işaret eden listeleride etkilemekte. Şimdi son olarak ÇIKARMA işleminide gözlemleyelim");
            iller.Remove("Ankara");
            System.Console.WriteLine("SİLME İŞLEMİ SONRASI");
            iller.ForEach(i =>System.Console.WriteLine(i));
            System.Console.WriteLine("İKİNCİ LİSTEMİZDEKİ GÖZLEM");
            sehirler.ForEach(s=>System.Console.WriteLine(s));
            System.Console.WriteLine("##############################################");
            System.Console.WriteLine("Gözlemlediğimi gibi sırası farketmezsizin herhangi bir liste gurubunun referans gösterdiği kümeden bir değere işlem yapıldığında diğer isaret eden listeleride etkiliyor");


        }
    }
}

