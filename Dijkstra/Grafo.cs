using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class Grafo
    {
        List<string> nodi;
        List<Rotta> rotte;
        List<Rotta> tabella;

        public Grafo()
        {
            nodi = new List<string>();
            rotte = new List<Rotta>();

        }
        public void AggiungiNodo(string nodo) //aggiunge un nodo nella lista dei nodi se esso non è già presente nella lista       
        {
            if (nodi.Find(tmp => tmp == nodo) is null)
                nodi.Add(nodo);
        }

        public void AggiungiCammino(string nodo1, string nodo2, int costo) //aggiunge alla lista delle rotte una rotta e la sua inversa dati due nodi e il costo
        {
            rotte.Add(new Rotta(nodo1, nodo2, costo));
            rotte.Add(new Rotta(nodo2, nodo1, costo));
        }

        public void Calcolo(string nodoIniziale)
        {
            tabella = new List<Rotta>();
            string nodo;
            for (int i = 0; i < nodi.Count; i++) //inizializza la tabella con costo infinito
            {
                tabella.Add(new Rotta(nodoIniziale, nodi[i], int.MaxValue));
            }


            int posizione;
            posizione = tabella.FindIndex(tmp => tmp.Destinazione == nodoIniziale);
            tabella[posizione].Costo = 0; //assegna al nodo iniziale il costo per arrivare a se stesso quindi 0

            while (nodi.Count > 0)      //si va ad analizzare ogni nodo
            {
                nodo = GetCamminoMinimo(); 
                nodi.Remove(nodo);

                for (int i = 0; i < rotte.Count; i++)
                {
                    if (rotte[i].Sorgente == nodo)
                    {
                        int costo = tabella[tabella.FindIndex(tmp => tmp.Destinazione == nodo)].Costo + GetCosto(nodo, rotte[i].Destinazione); 
                        if (costo < tabella[tabella.FindIndex(tmp => tmp.Destinazione == rotte[i].Destinazione)].Costo)
                        {
                            tabella[tabella.FindIndex(tmp => tmp.Destinazione == rotte[i].Destinazione)].Costo = costo;
                        }
                    }
                }
            }
        }
        private string GetCamminoMinimo() //ritorna il nodo dell'arco con costo minore
        {
            string nodo = "";
            int min = int.MaxValue;

            for (int i = 0; i < nodi.Count; i++)
            {
                if (min > tabella[i].Costo)
                {
                    min = tabella[i].Costo;
                    nodo = nodi[i];
                }
            }
            return nodi.Find(tmp => tmp == nodo);
        }

        private int GetCosto(string sorgente, string destinazione) //dati due nodi collegati ritorna il costo 
        {
            int costo = 0;
            foreach (Rotta rotta in rotte)
            {
                if (rotta.Sorgente == sorgente && rotta.Destinazione == destinazione)
                {
                    costo = rotta.Costo;
                    break;
                }
            }
            return costo;
        }

        public void ScriviTabella()
        {
            Rotta tmp;
            for (int i = 0; i < tabella.Count-1; i++)
            {
                for (int j = i+1; j < tabella.Count; j++)
                {
                    if (tabella[i].Costo > tabella[j].Costo)
                    {
                        tmp = tabella[i];
                        tabella[i] = tabella[j];
                        tabella[j] = tmp;
                    }
                }
            }


            for (int i = 0; i < tabella.Count; i++)
                Console.WriteLine($"Dal nodo {tabella[i].Sorgente} al nodo {tabella[i].Destinazione}: {tabella[i].Costo}");
        }
    }
}
