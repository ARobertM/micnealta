using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_referinte_bibliografice
{
    internal class Autor
    {
        private string nume;
        private string grad_didactic;
        private const int marca = 100;

        public Autor(string nume, string grad_didactic)
        {
            this.nume = nume;
            this.grad_didactic = grad_didactic;
        }

        public string Nume { get => nume; set => nume = value; }
        public string Grad_didactic { get => grad_didactic; set => grad_didactic = value; }
    }
}
