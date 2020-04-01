using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
               sum += vect[i]; 
            }
            double avg = sum / n;

            Console.WriteLine("Media é de : "+avg.ToString("F2",CultureInfo.InvariantCulture));
*/
            int QuantProduto = int.Parse(Console.ReadLine());
            Produto p;
            Produto[] vect = new Produto[QuantProduto];

            for (int i = 0; i < QuantProduto; i++)
            {
                string NomeProduto = Console.ReadLine();
                double ValorProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vect[i] = new Produto(NomeProduto,ValorProduto);
            }

            double sum = 0.00;
            for (int i = 0; i < QuantProduto; i++)
            {
                sum += vect[i].Price;
            }

            double avarage = sum / QuantProduto;
            
            Console.WriteLine(avarage.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
