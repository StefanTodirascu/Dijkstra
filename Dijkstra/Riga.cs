using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class Riga
    {
        string da, a;
        int costo;
        internal int Costo { get => costo; set => costo = value; }

        public Riga(string da, string a, int costo)
        {
            this.da = da;
            this.a = a;
            this.costo = costo;
        }
    }
}
