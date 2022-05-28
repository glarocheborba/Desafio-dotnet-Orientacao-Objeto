using System;
using Desafio_2.Entities;

namespace Desafio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 28, "Knight", "Poison", "strengh");
            Wizard Jeneka = new Wizard("Jeneka", 23, "White wizard", "strengh", "Magic");
            Witch Asvia = new Witch("Asvia", 23, "Supreme Witch", "dogs", "Poison Spell");

            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Jeneka.Attack(1));
            Console.WriteLine(Asvia.Attack());
            Console.WriteLine(Asvia.Defense("Arus"));
            Console.WriteLine(Arus.Defense("Jeneka"));
        }
    }
}
