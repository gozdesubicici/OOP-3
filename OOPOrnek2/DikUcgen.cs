using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek2
{
    public class DikUcgen:GeometrikSekil
    {
        public DikUcgen(double taban, double yukseklik)
        {
            Genislik = taban;
            Yukseklik = yukseklik;
        }

        public override void AlanHesapla()
        {
            Console.WriteLine("Dik üçgenin alanı: " + (Genislik * Yukseklik)/2); 
            // bu metota geldiğinde dik üçgen oluşturup alan hesaplamk istediğinde bu komiut sayesinde ezerek yeni hesanı kulllandırtabiliyoruz hesaplar eğer yeni alan tanımlamazsak defaultu kullanır
        }

        public override void CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(Genislik, 2) + Math.Pow(Yukseklik, 2));
            Console.WriteLine("Dik üçgen çevresi: " + (Genislik+Yukseklik+hipotenus));
        }
    }
}
