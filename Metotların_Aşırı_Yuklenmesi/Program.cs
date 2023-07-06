using System;
using System.Collections.Generic;

namespace Metotların_Aşiri_Yuklenmesi
{
   public class Program
   {
        static void Main(string[] args)
        {
            var odenecekMiktar = SatisYap(100);
            System.Console.WriteLine("{0,5:0.##}",odenecekMiktar);

            var odenecekMiktar2 = SatisYap(100, .1);
            System.Console.WriteLine("{0,5:0.##}",odenecekMiktar2);
        }
        //Aşırı yüklenme mantığı nasıl çalışıyor diye bakarsak, yukarıda 2 adet satışyap diye imzamız bulunmakta fakat dikkat edicek olursak birisinin 1 adet double parametresi diğerinin ise 2 adet double parametresi var.
        //ikiside satıs yap peki bunlar birbirlerini nasıl tanıyor; parametre bazlı tanıyorlar, yani bile isteye değil 

        /// <summary> Satıs yapan fonksiyon.
         private static double SatisYap(double miktar=0)
        {//bu yukarıdaki private şu anlama geliyor sadece program classı içinde çalışır
        //decimal dediğimiz için aynı double olduğu gibi return döneceğiz.

            return miktar * 1.18;//KDV yanımış hali
        }
         /// <summary> Satıs yapan fonksiyon.
        private static double SatisYap(double miktar, double indirim)
        {
            return ( miktar * (1.0 - indirim)) * 1.18;//burada KDV + İNDİRİM halini görüyoruz
       } 
} }