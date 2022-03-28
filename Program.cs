using System;
using projetos.src.Entities;

namespace projetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Ares hero = new Ares("Ares", 23, "knight");
            Ares oponnent = new Ares("Maléfico", 99, "Devil");
 
            
            Console.Write(hero);
            Console.Write(oponnent);
            
            
            Console.Write(hero);
        }
    }
}