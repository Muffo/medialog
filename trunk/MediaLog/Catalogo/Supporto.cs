using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Composite;

namespace Catalogo
{
    public class Supporto
    {
        private readonly string _id;
        private readonly string _tipo;
        private readonly Direttorio _root;

        public Supporto(string id, string tipo ,Direttorio root)
        {
            _id = id;
            _tipo = tipo;
            _root = root;
        }
        public string Tipo
        {
            get { return _tipo; }
        } 
        public string Id
        {
            get { return _id; }
        } 
    }
}
