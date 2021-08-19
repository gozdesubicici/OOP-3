using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek2
{
    public class Kare:GeometrikSekil
    {
        public Kare(double kenar)
        {
            Genislik = Yukseklik = kenar;
            //Genislik = kenar;
            //Yukseklik = kenar; böyle de yazılabilir tek satırı tercih ettik
        }



    }
}
