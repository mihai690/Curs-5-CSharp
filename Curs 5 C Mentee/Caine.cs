using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_5_C_Mentee
{
    public class Caine : Animal
    {
        public string numeCaine { get; set; }

        public Caine(string numeCaine) : base(numeCaine) {
            this.numeCaine = numeCaine;
        }

        public void latra() {
            Console.WriteLine("Ham!");
        }

        public string informatiiAnimal()
        {
            return "Nume caine: " + numeCaine + "\nCuloare: " + base.culoare + "\nVarsta: " + base.varsta ;
        }
    }
}
