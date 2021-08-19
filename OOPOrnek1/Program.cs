using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ayi ayi = new Ayi()
            {
                Barinak = "mağara",
                Besin = "bal",
                UykuSuresi = "6 ay"
            };
            ayi.BilgileriGetir();

            Maymun maymun = new Maymun()
            {
                Barinak = "ağaç", //maymun.Barinak = "ağaç"; gibi tek tek tanımlayabiliriz hepsini scopesuz
                Besin = "muz",
                UykuSuresi="6 ay"
            };
            maymun.BilgileriGetir();

            Insan insan = new Insan("Tarzan")
            {
                Barinak = "kulübe",
                Besin = "et",
                Dusunce = "dünya barışı",
                UykuSuresi = "7 saat"

            };

            insan.BilgileriGetir();
            insan.Dusun();
            insan.AsikOl("Jane");
            insan.AsikOl("Doğa");

            Console.ReadLine();
        }
    }
}
