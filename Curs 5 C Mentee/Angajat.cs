using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_5_C_Mentee
{
    public class Angajat : Persoana
    {
        public Sef Angajator { get; set; }
        public Angajat(Sef angajator) : base()
        {
            Angajator = angajator;
        }
        public string afiseazaDetalii()
        {
            return "Nume:" + base.nume + "; Prenume: " + base.prenume + "; Varsta: " + base.varsta + "\n Angajator: " + Angajator.afiseazaDetalii();
        }
    }
}
