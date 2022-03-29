using System;
using projetos.src.Entities;

namespace projetos
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Knight ares = new Knight("Ares", 23, "knight");
            Wizard wizard = new Wizard("Jéssica", 24, "white Wizard");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            
              
        }
    }
}