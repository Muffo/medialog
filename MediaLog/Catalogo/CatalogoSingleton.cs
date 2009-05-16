using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalogo
{
    public class CatalogoSingleton
    {
        private static CatalogoSingleton _instance = null;
        private List<Supporto> _supporti;

        public List<Supporto> Supporti
        {
            get { return _supporti; }
           
        }
        protected CatalogoSingleton()
        {
            _supporti = new List<Supporto>();
        }
        public static CatalogoSingleton getInstance()
        {
            if (_instance == null) _instance = new CatalogoSingleton();
            return _instance;
        }

    }
}
