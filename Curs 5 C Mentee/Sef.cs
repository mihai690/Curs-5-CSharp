using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_5_C_Mentee
{
    public class Sef : Persoana
    {
        public string numeSef { get; set; }

        //se apeleaza constructorul cu un parametru al clasei de baza

        public Sef(string numeSef) : base(numeSef)
        {
            nume = "Nume: " + numeSef;
        }
    }
}
