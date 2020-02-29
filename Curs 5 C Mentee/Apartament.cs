using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_5_C_Mentee
{
    public class Apartament : Imobil
    {
        public int numarCamere { get; set; }

        public Apartament(int numarCamere) : base()
        {
            this.numarCamere = numarCamere;
        }
        public string informatiiImobil()
        {
            return "Apartament: " + "\nNumar Camere: " + this.numarCamere + "\nnrEtaje: " + base.nrEtaje + "\nPret: " + base.pret;
        }
    }
}
