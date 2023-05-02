using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class Grafo
    {
        List<Nodo> nodi;
        public Grafo(Nodo n)
        {
            nodi = new List<Nodo>();
            nodi.Add(n);
            for (int i = 0; i < nodi.Count; i++)
            {
                foreach (Arco a in nodi[i].Archi)
                {
                    if (nodi.Find(x => x.Nome.Equals(a.Destinazione.Nome)) is null) //controllo che non ci siano nodi omonimi 
                        nodi.Add(a.Destinazione);
                }
                    
            }
                
        }
        public List<Riga> CamminoMinimo()
        {
            List<Riga> finale = new List<Riga>();
            List<Riga> indagine = new List<Riga>();
            foreach (Nodo nodo in nodi)
                indagine.Add(new Riga(nodo.Nome, "", int.MaxValue));
            indagine[0].Costo = 0;
            return new List<Riga>();
        }
    }
}
