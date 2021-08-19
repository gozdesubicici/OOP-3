using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek2
{
    class Daire:GeometrikSekil
    {
        public Daire(double yaricap)
        {
            Genislik = Yukseklik = yaricap;
        }

        public override void AlanHesapla()
        {
            Console.WriteLine("Dairenin alanı: " + (Math.PI*Math.Pow(Genislik,2)));
        }

        public override void CevreHesapla()
        {
            Console.WriteLine("Dairenin çevresi: " + (2 * Math.PI * Yukseklik));
        }

    }
}
