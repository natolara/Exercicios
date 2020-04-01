using System.Globalization;
namespace Encapsulamento
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // metodo para obter um nome e retorna-lo
        public string GetNome()
        {
            return _nome;
        }
        // metodo para altera nome quando os parametros sao do tipo private
        // forma de proteger o codigo de usuarios
        // o encapsulamento permite que vc faça algumas verificações conforme abaixo.
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}