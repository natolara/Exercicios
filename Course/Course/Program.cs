using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre coom os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            //Console.Write("Quantidade de estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

            //instanciando atraves do construtor padrão
            Produto p2 = new Produto();

            //forma de instanciar desde que tenha construtor padrão ou sem nenhum construtor
            Produto p3 = new Produto {Nome = "Tv", Preco = 400.00, Quantidade = 20 };


            Console.WriteLine("Dados do estoque: " + p);

            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
