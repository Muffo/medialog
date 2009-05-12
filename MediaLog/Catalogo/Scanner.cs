using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Composite;
using System.IO;

namespace Catalogo
{
    public class Scanner
    {
        private static Scanner _instance=null;
        protected Scanner()
        {
        }
        public static Scanner GetInstance()
        {
            if (_instance == null) _instance = new Scanner();
            return _instance;

        }
        public Supporto ScanSupporto(string percorso)
        {
            DirectoryInfo root = new DirectoryInfo(percorso);
            List<Nodo> ListRoot = new List<Nodo>();
            Direttorio DirRoot = new Direttorio(ListRoot, "root", null);
            Supporto res = new Supporto("primo", "DVD", DirRoot);
            addFile(root, ListRoot, DirRoot);
            addDir(root, ListRoot, DirRoot);
            return res;
        }

        private static void addFile(DirectoryInfo root, List<Nodo> ListRoot, Direttorio DirRoot)
        {
            foreach (FileInfo file in root.GetFiles())
            {
                ListRoot.Add(new Composite.File(file.Name, file.Length, DirRoot));
            }
        }
        private static void addDir(DirectoryInfo root, List<Nodo> ListRoot, Direttorio DirRoot)
        {
            
            foreach (DirectoryInfo dir in root.GetDirectories())
            {
                List<Nodo> nuovaList= new List<Nodo>();
                Direttorio cur= new Direttorio(nuovaList, dir.Name, DirRoot);
                ListRoot.Add(cur);
                addFile(dir, nuovaList, cur);
                addDir(dir, nuovaList, cur);
            }
        } 
        //
        //private List<Nodo> ListFiles(DirectoryInfo percorso,Direttorio parent)
        //{
        //    List<Composite.File> res = new List<Composite.File>();
        //    foreach (FileInfo file in percorso.GetFiles())
        //    {
              
        //    res.Add(new Composite.File(file.ToString(),file.Length,parent));
        //    }
        //    return (List<Composite.Nodo>)res;
        //}
        //private List<Nodo> ListDirectory(DirectoryInfo percorso, Direttorio parent)
        //{
        //    List<Nodo> res = new List<Nodo>();
        //    foreach (DirectoryInfo dir in percorso.GetDirectories())
        //    {

        //        res.Add(new Composite.File(dir.ToString(), parent));
        //    }
        //    return res;
        //}
    }
}
