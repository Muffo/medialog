using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public abstract class Nodo
    {
        private readonly string _nome;
        private readonly Direttorio _parent;
        protected Nodo() { }
        protected Nodo(string nome,Direttorio parent)
        {
            _nome = nome;
            _parent = parent;
        }

        public string Nome
        {
            get { return _nome; }
        }
        public override string ToString()
        {
            return _nome;

        }

    }
}
