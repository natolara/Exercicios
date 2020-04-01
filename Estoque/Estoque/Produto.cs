using System.Globalization;
namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos (int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return Nome
                + " $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade no estoque: "
                + Quantidade + " Valor total: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
