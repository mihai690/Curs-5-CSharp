using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_5_C_Mentee
{
    public class Imobil
    {
        public string tipCasa { get; set; }
        public int nrEtaje { get; set; }
        public double pret { get; set; }

        public Imobil()
        {
            tipCasa = "";
            nrEtaje = 0;
            pret = 0;
        }

        
        public string informatiiImobil()
        {
            return "tipCasa: " + tipCasa + "\nnrEtaje: " + nrEtaje + "\nPret: " + pret;
        }

        public string informatiiImobil(string tipCasa) {
            return tipCasa;
        }

        public int informatiiImobil(int pret)
        {
            return pret;
        }
        public int informatiiImobil(int nrEtaje, int pret)
        {
            return nrEtaje + pret;
        }

                
    }
}
