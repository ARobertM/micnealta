using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Clienti
    {
        private int id;
        private String nume;
        private String prenume;
        private double sold;
        private string sex;
        public Clienti(int id, string prenume, string nume, double sold, string sex)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.sold = sold;
            this.sex = sex;
        }

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public double Sold { get => sold; set => sold = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}
