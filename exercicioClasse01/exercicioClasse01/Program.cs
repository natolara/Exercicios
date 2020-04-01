using System;

namespace exercicioClasse01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite seu nome");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade < p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha é  o " + p2.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é " + p1.Nome);
            }



        }
    }
}
