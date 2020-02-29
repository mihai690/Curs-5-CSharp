using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_5_C_Mentee
{
    public class Casa : Imobil
    {
        public string culoare { get; set; }

        public Casa(string culoare) : base() {
            this.culoare = culoare;
        }
                public string informatiiImobil()
        {
            return "Casa: " + "\nCuloare: " + this.culoare + "\nnrEtaje: " + base.nrEtaje + "\nPret: " + base.pret;
        }
    }
}
