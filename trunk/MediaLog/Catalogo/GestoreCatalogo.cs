using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Catalogo;
using Composite;

namespace Catalogo
{
    public static class GestoreCatalogo
    {
        static CatalogoSingleton _cat=null;
        
        public static void aggiungiSupporto(string percorso)
        {
            Scanner _scan = Scanner.GetInstance();
            _cat = CatalogoSingleton.getInstance();
            _cat.Supporti.Add(_scan.ScanSupporto(percorso));
        }
        public static Supporto visualizzaSupporto(string id)
        {
            _cat = CatalogoSingleton.getInstance();
            foreach (Supporto sup in _cat.Supporti)
            {
                if (sup.Id.Equals(id))
                    return sup;
            }
            return null;
        }
        public static int eliminaSupporto(string id)
        {
            int i=0;
            _cat = CatalogoSingleton.getInstance();
            foreach (Supporto sup in _cat.Supporti)
            {

                if (sup.Id.Equals(id))
                {
                    _cat.Supporti.RemoveAt(i);
                    return 0;
                }
                i++;
            }
            return -1;
        }
    }
   
}
