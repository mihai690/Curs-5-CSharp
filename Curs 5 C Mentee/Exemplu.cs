using System;

namespace Curs_5_C_Mentee
{
    class Exemplu
    {
        static void Main(string[] args)
        {
            Sef angajator1 = new Sef("Andrei");
            angajator1.prenume = "Ion";
            angajator1.varsta = 40;

            Angajat a1 = new Angajat(angajator1);
            a1.nume = "Alina";
            a1.prenume = "Ana";
            a1.varsta = 30;

            Console.WriteLine(a1.afiseazaDetalii());
            Console.WriteLine(angajator1.afiseazaDetalii());
        }
    }
}
