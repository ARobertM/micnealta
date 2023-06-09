using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_referinte_bibliografice
{
    public abstract class Publicitate
    {
        private string titlu;
        private float pret;

        // Metoda abstracta ce intoarce un sir de caractere si nu are argumente
        public abstract string GenereazaReferinta();
    }
}
