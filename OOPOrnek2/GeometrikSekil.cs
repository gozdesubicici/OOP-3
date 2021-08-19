using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek2
{
    public class GeometrikSekil 
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

      
        public virtual void AlanHesapla() //virtual anahtar kelimesi ile ezicem
        {
            Console.WriteLine("Alanı: " + (Genislik*Yukseklik));
        }
        public virtual void CevreHesapla()
        {
            Console.WriteLine("Çevre = " + (2 * (Genislik + Yukseklik)));
        }

    }

  
}
