using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkaKonsolowe4D
{
    internal class Strona
    {
        public string trescStrony;
        public uint numerStrony;
        public static uint licznikStrony = 0;

        public Strona(string trescStrony, uint numerStrony)
        {
            this.trescStrony = trescStrony;
            this.numerStrony = numerStrony;
            licznikStrony = numerStrony + 1;
        }

        public Strona(string trescStrony)
        {
            this.trescStrony = trescStrony;
            this.numerStrony = licznikStrony++;
        }
    }
}
