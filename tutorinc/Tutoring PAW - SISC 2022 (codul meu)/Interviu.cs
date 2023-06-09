using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring_PAW___SISC_2022__codul_meu_
{
    internal class Interviu : ICalculPunctaj
    {
        private DateTime data_interviu;
        private string specializare;
        private string numeCandidat;
        private float punctajTeorie;
        private float punctajPractic;

        public Interviu(DateTime data_interviu, string specializare, string numeCandidat, float punctajTeorie, float punctajPractic)
        {
            this.data_interviu = data_interviu;
            this.specializare = specializare;
            this.numeCandidat = numeCandidat;
            this.punctajTeorie = punctajTeorie;
            this.punctajPractic = punctajPractic;
        }

        public DateTime Data_interviu { get => data_interviu; set => data_interviu = value; }
        public string Specializare { get => specializare; set => specializare = value; }
        public string NumeCandidat { get => numeCandidat; set => numeCandidat = value; }
        public float PunctajTeorie { get => punctajTeorie; set => punctajTeorie = value; }
        public float PunctajPractic { get => punctajPractic; set => punctajPractic = value; }

        public float calculeazaPunctaj()
        {
            return (punctajPractic + punctajTeorie) / 2;
        }

        public override string ToString()
        {
            return $"Data interviu: {data_interviu} - nume candidat: {numeCandidat} - specializarea {specializare} a " +
                $"obtinut la teorie {punctajTeorie} puncte si la practic {punctajPractic} puncte. ";
        }
    }
}
