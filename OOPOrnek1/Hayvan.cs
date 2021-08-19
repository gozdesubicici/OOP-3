using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek1
{
    public class Hayvan
    {
        public string Besin { get; set; }
        public string Barinak { get; set; }
        public string UykuSuresi { get; set; }

        private void Uyu()
        {
            Console.WriteLine("{0}, {1} barınağında uyudu...", UykuSuresi, Barinak);
        }
        private void Beslen()
        {
            Console.WriteLine("{0} ile beslendi...", Besin);
        }

        public void BilgileriGetir()
        {
            Beslen();
            Uyu();
        }
    }
}
