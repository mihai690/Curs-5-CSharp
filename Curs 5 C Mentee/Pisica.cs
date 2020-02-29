using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_5_C_Mentee
{
    public class Pisica : Animal
    {
         string numePisica { get; set; }

        public Pisica(string numePisica, string culoare, int varsta) : base(numePisica)
        {
            this.numePisica = numePisica;
            this.culoare = culoare;
            this.varsta = varsta;
        }

        public void meow()
        {
            Console.WriteLine("Meow!");
        }

        public string informatiiAnimal()
        {
            return "Nume pisica: " + numePisica + "\nCuloare: " + base.culoare + "\nVarsta: " + base.varsta;
        }
    }
}
