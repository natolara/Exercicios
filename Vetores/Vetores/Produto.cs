using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores
{
    class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Produto(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "Preço medio = "+Price;
        }
    }
}
