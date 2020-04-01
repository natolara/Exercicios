using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre coom os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade de estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do estoque: "+ p);

            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+ p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
