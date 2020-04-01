using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 1500.00, 5);

            //SetNome altera o nome atraves do metodo
            p.SetNome("Tv 4K");
            Console.WriteLine(p.GetNome());


        }
    }
}
