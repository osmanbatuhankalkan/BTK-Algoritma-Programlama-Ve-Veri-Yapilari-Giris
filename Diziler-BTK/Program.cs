using System;
namespace Diziler_BTK
{
    class Program
    {
        static void Main(string[] args)
        {   
    //Tanımlama; Henüz görmedik fakat referans tipli ve değer tipli ifadelerimiz vardır.
    //Eğer bir ifade,biryapı ref.tip. ise onu başlatmak gerekmektedir.
    //bu yeni ifadeyi başlatmak yeni bir anahtardan geçer new anahtarı
    int[] numaralar;

    //başlatma
    numaralar = new int[3];// [] tanımlama dizi parmetreleri //numaralar değşkn adı

    numaralar[0]= 3;
    numaralar[1]= 5;
    numaralar[2]= 7;
    //şimdi bir döngüyle bunların üzerinden tek tek geçelim
    for(int i=0;i<numaralar.Length;i++)
    {
    //burada ince nokta numaralar.Length burası. Burası bize dinamık olmayı sağlıyor
    //length: dizinin uzunluğu için kullanılır yani yukarıda numalarımız kaç ise ona göre uza oku dedik
    //okuma işlemi tabıkı 0 dan başlacaktır[0]
    System.Console.WriteLine(numaralar[i]);
    System.Console.WriteLine($"numaralar[{i}]=" + $"{numaralar[i]}");
    
    }

    System.Console.WriteLine("********************************");

    static void tanımlamaBaslatma()
    {
        System.Console.WriteLine("TANIMLAMA & BAŞLATMA");
    //YUKARIDA AYRI AYRI YAZILAN KISIM 
    int[] numaralar = new int[3];
    for(int i=0;i<numaralar.Length;i++)
    {
    System.Console.WriteLine(numaralar[i]);
    } 
    //ŞEKLİNDE DE İFADE EDİLEBİLİR AYNI ÇIKTIYI ALIRIZ
    }
    //YADA

    System.Console.WriteLine("********************************");

    static void tanımlamaBaslatmaAtama()
    {
     System.Console.WriteLine("TANIMLAMA & BAŞLATMA & ATAMA");
    //YUKARIDA AYRI AYRI YAZILAN KISIM 
    int[] numaralar = new int[3] {3,5,7};
    //ŞEKLİNDE DE İFADE EDİLEBİLİR AYNI ÇIKTIYI ALIRIZ
    for(int i=0;i<numaralar.Length;i++)
    {
    System.Console.WriteLine(numaralar[i]);
    }

    }

    System.Console.WriteLine("********************************");
    System.Console.WriteLine("***************DAHA-DİNAMİK-YAPALIM*****************");
    static void tanımlamaBaslatmaAtamaDinamizim()
        {
     System.Console.WriteLine("TANIMLAMA & BAŞLATMA & ATAMA & DİNAMİZİM");
    //YUKARIDA AYRI AYRI YAZILAN KISIM 
    int[] numaralar = new int[] {3,5,7,8,10};//BU DİNAMİZİM Mİ SAĞLAYAN new int[] içinin sınırlandırılmamış olmasıdır bizim { } içine yazdığımız değerler hemen tanımlanacaktır
    //bir diğer nokta ise aşşağıda numaralar diye değilde numaralar.length olarak tanımlalmamız oda esneklik sağlar biz kaç değer yazarsak kendiside otomatik olarak değer tanımlayacaktır
    //ŞEKLİNDE DE İFADE EDİLEBİLİR AYNI ÇIKTIYI ALIRIZ
    for(int i=0;i<numaralar.Length;i++)
    {
    System.Console.WriteLine(numaralar[i]);
    }
        
        } 
    }
        }

}