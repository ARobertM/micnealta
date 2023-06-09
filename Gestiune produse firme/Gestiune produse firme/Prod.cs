using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_produse_firme
{
    [Serializable]
    internal class Prod
    {
        private int cod;
        private string denumire;
        private float pret;

        public Prod(int cod, string denumire, float pret)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.pret = pret;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public float Pret { get => pret; set => pret = value; }

        // Supraincarcarea operatorului < (bool)
        public static bool operator <(Prod p1,Prod p2)
        {
            return p1.pret < p2.pret;
        }
        public static bool operator >(Prod p1, Prod p2)
        {
            return p1.pret > p2.pret;
        }
    }
}
