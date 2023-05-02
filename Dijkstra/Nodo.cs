using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class Nodo
    {
        static int index;
        string nome;
        List<Arco> archi;
        List<Riga> camminominimo;
        public Nodo()
        {
            archi = new List<Arco>();
            index++;
            nome = index.ToString();
        }
        public Nodo(string nome) : this()
        {
            this.nome += nome;
        }

        public string Nome { get => nome; }
        internal List<Arco> Archi { get => archi; }

        internal List<Riga> CamminoMinimo()
        {
            Grafo g = new Grafo(this);

            return camminominimo;
        }
    }
}
