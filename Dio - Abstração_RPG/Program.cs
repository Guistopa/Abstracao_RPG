using System;
using Projeto1GFT.src.Models;


namespace projeto1gft
{
    class Program
    {

        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Carvão", 76, "Wizard");
            Archer archer = new Archer("Thor", 78, "Archer");
            Beserker beserker = new Beserker("Brutos", 81, "Beserker");
            Knight knight = new Knight("Hulk", 81, "Knight");
            Priest priest = new Priest("Jhonas", 80, "Priest");

        
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(archer.Attack(8));
            Console.WriteLine(beserker.Attack(8));
            Console.WriteLine(knight.Attack());
            Console.WriteLine(priest.Attack(6));
        
        }

    }
}




