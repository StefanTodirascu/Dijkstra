using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo grafo = new Grafo();
            grafo.AggiungiNodo("A");
            grafo.AggiungiNodo("B");
            grafo.AggiungiNodo("C");
            grafo.AggiungiNodo("D");
            grafo.AggiungiNodo("E");
            grafo.AggiungiCammino("A", "B", 6);
            grafo.AggiungiCammino("A", "E", 2);
            grafo.AggiungiCammino("B", "C", 2);
            grafo.AggiungiCammino("C", "E", 7);
            grafo.AggiungiCammino("C", "D", 3);

            grafo.Calcolo("A");
            grafo.ScriviTabella();
            Console.ReadLine();
        }
    }
}
