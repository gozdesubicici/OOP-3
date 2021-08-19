using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {

            GeometrikSekil geometrikSekil = new GeometrikSekil()
            {
                Genislik = 5,
                Yukseklik = 10
            };

            geometrikSekil.AlanHesapla(); // Alanı:50
            geometrikSekil.CevreHesapla(); // cevresi: 30

            Console.WriteLine("*****************************");

            Dikdortgen dikdortgen = new Dikdortgen(10, 20);
            dikdortgen.AlanHesapla(); //200
            dikdortgen.CevreHesapla(); //60

            Console.WriteLine("******************************");

            Kare kare = new Kare(12);
            kare.AlanHesapla(); //Alanı:144
            kare.CevreHesapla(); //Çevre: 48

            Console.WriteLine("*******************************");

            DikUcgen dikUcgen = new DikUcgen(4, 3);
            dikUcgen.AlanHesapla(); // Dik ücgenin alanı : 6
            dikUcgen.CevreHesapla(); // Dik üçgenin çevresi : 12

            Console.WriteLine("*********************************");

            Daire daire = new Daire(10);
            daire.AlanHesapla();  // Dairenin alanı: 314,159265358979
            daire.CevreHesapla(); // Dairenin çevresi: 62,8318530717959

            Console.ReadLine();
            
        }
    }
}
