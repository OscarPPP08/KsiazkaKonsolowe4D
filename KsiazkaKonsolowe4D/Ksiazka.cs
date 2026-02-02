using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkaKonsolowe4D
{
    public class Ksiazka
    {
        public List<Strona> strony = new List<Strona>();
        
        public Ksiazka(string tytul)
        {
            Strona strona = new Strona(tytul, 1);
            strony.Add(strona);
        }

        public void DodajStrone(string trescStrony)
        {
            var Strona = new Strona(trescStrony);
            strony.Add(Strona);
        }
    }
}
