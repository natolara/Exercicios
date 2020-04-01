using System;
using System.Collections.Generic;

namespace ExConjuntoFix
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            
            Console.WriteLine("O curso A possui quantos alunos? ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o codigo dos alunos");
            for (int i = 0; i < quantidade; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }
            Console.WriteLine("O curso B possui quantos alunos? ");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o codigo dos alunos");
            for (int i = 0; i < quantidade; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }
            Console.WriteLine("O curso C possui quantos alunos? ");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o codigo dos alunos");
            for (int i = 0; i < quantidade; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            HashSet<int> D = new HashSet<int>();
            D.UnionWith(A);
            D.UnionWith(B);
            D.UnionWith(C);

            foreach (int s in D)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
