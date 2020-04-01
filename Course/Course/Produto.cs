using System.Globalization;
namespace Estoque
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        //construtor padrao
        public Produto(){
            _quantidade = 2;
        }

        //construtor com os tres parametros 
        //this esta utilizando o outro construtor de 2 argumentos não necessario repetir o codigo 
        public Produto(string nome, double preco, int quantidade) : this(nome,preco)
        {
            
            _quantidade = quantidade;
        }

        //construtor sobrecarga chamando dos parameros
        // o this esta utilizando o construtor padrao com a quantidade
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
            
        }

        //encapsulamento


        public double ValorTotalEmEstoque()
        {
            return _quantidade * _preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }


        public override string ToString()
        {
            return _nome
                + " $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade no estoque: "
                + _quantidade + " Valor total: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
