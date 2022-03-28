using System;
using projetos.src.Entities;

namespace projetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero ares = new Hero("Ares", 23, "knight");
            Hero oponnent = new Hero("Maléfico", 99, "Devil");
            Wizard wizard = new Wizard("Jéssica", 24, "white Wizard");


 
            
            //Não é possível Criar a Jéssica com a mesma classe/forma
            Console.Write(ares.Attack());
            Console.Write(wizard.Attack());
            
            
        }
    }
}