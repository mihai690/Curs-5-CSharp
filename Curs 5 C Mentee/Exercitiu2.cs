using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_5_C_Mentee
{
    class Exercitiu2
    /*Creati 2 subclase ce vor extinde clasa parinte Imobil 
     * si apelati-le din Program.cs. Scrieti metode supraincarcate 
     * si de asemenea suprascrieti o metoda din clasele copil 
     * pentru a consolida cunostintele acumulate in acest curs.
     */
    {
        static void Main(string[] args) {
            Casa c1 = new Casa("gri");
            c1.nrEtaje = 1;
            c1.pret = 100_000;

            Console.WriteLine(c1.informatiiImobil());

            Console.WriteLine();

            Apartament a1 = new Apartament(3);
            a1.pret = 50_000;

            Console.WriteLine(a1.informatiiImobil());

        }
    }
}
