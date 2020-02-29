using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Curs_5_C_Mentee
{
    class Exercitiu1
        /*Creati 2 subclase ce vor extinde clasa parinte Animal 
         * si apelati-le din Program.cs. 
         * Scrieti metode supraincarcate si de asemenea suprascrieti o metoda 
         * din clasele copil pentru a consolida cunostintele acumulate in acest curs.
         */ 
    {
        static void Main(string[] args) {
            Caine c1 = new Caine("Rex");
            c1.culoare = "maro";
            c1.varsta = 5;

            Console.WriteLine(c1.informatiiAnimal());
            c1.latra();

            Console.WriteLine();

            Pisica p1 = new Pisica("Garfield", "alba", 3);
            
            Console.WriteLine(p1.informatiiAnimal());
            p1.meow();

        
        }
    }
}
