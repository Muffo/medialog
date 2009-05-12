using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class File : Nodo
    {
        private readonly long _dimensione;

        public long Dimensione
        {
            get { return _dimensione; }
        }
        public string Estensione
        {
            get { return Nome.Split('.').Last(); }
        }
        public File(string nome,long dimensione,Direttorio parent)
            : base (nome,parent)
        {
            _dimensione = dimensione;
        }

    }
}
