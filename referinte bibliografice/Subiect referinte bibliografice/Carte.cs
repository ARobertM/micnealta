using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_referinte_bibliografice
{
    internal class Carte : Publicitate
    {
        private const string ISBN = "978-0-123456-78-9";
        private string categorie;
        private List<Autor> listaAutori;

        public Carte(string categorie, List<Autor> listaAutori)
        {
            this.categorie = categorie;
            this.listaAutori = listaAutori;
        }

        public string Categorie { get => categorie; set => categorie = value; }
        internal List<Autor> ListaAutori { get => listaAutori; set => listaAutori = value; }

        public override string GenereazaReferinta()
        {
            string referinta = $"Cartea: \n";
            referinta += $"ISBN: {ISBN}\n";
            referinta += $"Categorie: {Categorie}\n";
            referinta += "Autori:\n";

            foreach (Autor autor in listaAutori)
            {
                referinta += $"- {autor.Nume} ({autor.Grad_didactic})\n";
            }

            return referinta;
        }

  
    }
}
