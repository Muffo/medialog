using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class Direttorio : Nodo
    {
        private readonly List<Nodo> _nodi;

        public List<Nodo> Nodi
        {
            get { return _nodi; }
        } 

        public Direttorio()
        { }
        public Direttorio(List<Nodo> nodi,string nome,Direttorio parent)
            :base(nome,parent)
        {
            _nodi = nodi;
        }
        

    }
}
