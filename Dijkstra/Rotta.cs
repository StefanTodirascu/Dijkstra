using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class Rotta
    {
        int costo;
        public int Costo { get => costo; set => costo = value; }

        string nodoSorgente;
        public string Sorgente { get => nodoSorgente; set => nodoSorgente = value; }

        string nodoDestinazione;
        public string Destinazione { get => nodoDestinazione; set => nodoDestinazione = value; }
        public Rotta()
        {

        }
        public Rotta(string nodoSorgente, string nodoDestinazione, int costo)
        {
            this.nodoSorgente = nodoSorgente;
            this.nodoDestinazione = nodoDestinazione;
            this.costo = costo;
        }

    }
}
