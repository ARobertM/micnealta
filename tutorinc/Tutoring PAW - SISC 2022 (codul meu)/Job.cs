using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring_PAW___SISC_2022__codul_meu_
{
    internal class Job
    {
        // METODA 1 - CU VECTOR DE INTERVIURI

        private Interviu[] vectorInterviuri; //vector de interviuri sau o colectie: LISTA, VECTOR, ArrayList
                                            // In ArrayList se pot pune obiecte de mai multe tipuri diferite
                                           // In List se pot pune doar obiecte de acelasi tip
        private string numeJob;

        public Job(Interviu[] vectorInterviuri, string numeJob)
        {
            // this.vectorInterviu = vectorInterviu; // - Aici se face SHALLOW COPY!!
            // Vrem sa facem DEEP COPY - alocam un nou vector pt interviuri in care copiem datele

            this.vectorInterviuri = new Interviu[vectorInterviuri.Length];
            for(int i = 0; i < vectorInterviuri.Length; i++)
            {
                this.vectorInterviuri[i] = vectorInterviuri[i];
            }
            this.numeJob = numeJob;
        }
     
        // Supraincarcarea operatorului +
        public static Job operator +(Job j, Interviu I)
        {
            j.vectorInterviuri.Append(I); // Metoda 1 - cu vector
          //  j.listaInterviuri.Add(I);    // Metoda 2 - cu List
            return j;
        }
        // cand se supraincarca op.+, se mai supraincarca si op. += (vin la pachet)



        // INDEXER - se face de mana GET si SET
        public Interviu this[int index]
        {
            
            get
            {
                // Metoda 1 - cu vector
                if (index >= 0 && index < vectorInterviuri.Length)
                    return vectorInterviuri[index];
            
                else throw new Exception();

                // Metoda 2 - cu List
               /* if (index >= 0 && index < listaInterviuri.Count)
                    return listaInterviuri[index];

                else throw new Exception(); */
            }

            set
            {
                // Metoda 1 - cu vector
                if (index >= 0 && index < vectorInterviuri.Length)
                    vectorInterviuri[index] = value;
                else throw new Exception();

                // Metoda 2 - cu List
                //if (index >= 0 && index < listaInterviuri.Count)
                //    listaInterviuri[index] = value;
                //else throw new Exception();

            }

        
        }

        // Metoda 2 - cu List in loc de vector de interviuri:
        private List<Interviu> listaInterviuri;

        public Job(string numeJob)
        {
            this.numeJob= numeJob;
            listaInterviuri = new List<Interviu>();
        }

        public int nrInterviuri()
        {
            return vectorInterviuri.Length;
        }

        public Interviu[] VectorInterviuri
        {
            get
            {
                return vectorInterviuri;
            }
            set
            {
                vectorInterviuri = value;
            }
        }
    }
}
