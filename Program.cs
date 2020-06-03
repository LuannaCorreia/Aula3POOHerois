using System;

namespace Aula3POOHerois
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Personagem Tony = new Personagem();
            Tony.armadura = "Bleeding edge";

            Console.WriteLine(Tony.nome);
            Console.WriteLine(Tony.armadura);
            Console.WriteLine(Tony.Atacar() );
        }
    }
}
