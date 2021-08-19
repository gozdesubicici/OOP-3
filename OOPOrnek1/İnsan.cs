using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek1
{
    class Insan:Hayvan
    {
        public string Adi { get; set; }
        public string Dusunce { get; set; }

        public Insan(string ad)
        {
            Adi = ad;
            Console.WriteLine("{0} yaratıldı...", Adi);
        }

        public void Dusun()
        {
            Console.WriteLine("{0}, {1} düşündü...", Adi, Dusunce);
        }

        public void AsikOl(string kime)
        {
            Console.WriteLine("{0}, {1} adlı kişiye aşık oldu...", Adi, kime);
        }
    }
}
