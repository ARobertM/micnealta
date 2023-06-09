using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    internal class ContracteCredite
    {
        private int idContract;
        private DateTime dataIncheiere;
        private double sumaImprumutata;
        private int durata;

        public int IdContract
        {
            get { return idContract; }
            set { idContract = value; }
        }

        public DateTime DataIncheiere
        {
            get { return dataIncheiere; }
            set { dataIncheiere = value; }
        }

        public double SumaImprumutata
        {
            get { return sumaImprumutata; }
            set { sumaImprumutata = value; }
        }

        public int Durata
        {
            get { return durata; }
            set { durata = value; }
        }

        public ContracteCredite(int idContract, DateTime dataIncheiere, double sumaImprumutata, int durata)
        {
            this.idContract = idContract;
            this.dataIncheiere = dataIncheiere;
            this.sumaImprumutata = sumaImprumutata;
            this.durata = durata;
        }
    }
}
