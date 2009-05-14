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

        public Direttorio Root
        {
            get { return _root; }
        } 


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
        public void GetBulkInit(List<String> res)
        {
            GetBulk(res, Root.Nodi,Root.Nome);
        }
        private void GetBulk(List<String> res,List<Nodo> dir,string nameDir)
        {
       
        foreach (Nodo no in dir)
        {
            if (no is File)
            {
                
                res.Add(nameDir+"/" + no.ToString());
            }
            else if (no is Direttorio)
            {
                GetBulk(res,((Direttorio)no).Nodi,nameDir+"/"+((Direttorio)no).Nome);
            }
            
        }
        }
    }
}
