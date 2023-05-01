using System;

    namespace Switch_case
    {
        public class Program
        {   
            enum Islemler
            {
                Toplama =1,
                Cikarma =2,
                Carpma =3,
                Bolme =4,
            }
            static void Main(string[] args)
            {
                int A=10;
                int B=20;
                Islemler secim =(Islemler)(new Random().Next(1,4));//bu kısımda new anahtarını yeni görmüş oldul NTP yeni nesne üretmeye yarayan anahtar random adından da anlaşılacağı gibi rastgele atama yapan next(1,4) dediğimiz kısım ise bu aralıktan rastgele atama yap. Yani her seferinde bize farklı bir sonuç verecek mekanizma kurulmuş olunuyor

                switch (secim)
                {
                    case Islemler.Toplama:
                        System.Console.WriteLine($"{A} + {B} = {A+B}");
                        break;

                    case Islemler.Cikarma:
                         System.Console.WriteLine($"{A} - {B} = {A+B}");
                         break;

                    case Islemler.Carpma:
                         System.Console.WriteLine($"{A} * {B} = {A+B}");
                         break;

                    case Islemler.Bolme:
                         System.Console.WriteLine($"{A} / {B} = {A+B}");
                         break;
                    default:
                        System.Console.WriteLine("\aGeçersiz İşlem !!!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }   
    
