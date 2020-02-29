using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_5_C_Mentee
{
    public class Persoana
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public int varsta { get; set; }

        public string afiseazaDetalii()
        {
            return "Nume:" + nume;
        }

        //constructor implicit

        public Persoana()
        {
            nume = "";
            prenume = "";
            varsta = 0;
        }

        //constructor cu 1 parametru

        public Persoana(string nume)
        {
            this.nume = nume;
            this.prenume = "";
            this.varsta = 0;
        }

        //constructor cu 3 parametri

        public Persoana(string n, string prenume, int varsta)
        {
            nume = n;
            this.prenume = prenume;
            this.varsta = varsta;
        }
    }
}
