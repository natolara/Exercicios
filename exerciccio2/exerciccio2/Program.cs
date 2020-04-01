using System;
using System.Globalization;

namespace exerciccio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //usando while
            /* Console.Write("Digite um numero: ");
             double x = double.Parse(Console.ReadLine());

             while (x>=0)
             {
                 x = Math.Sqrt(x);
                 Console.WriteLine(x.ToString("F3",CultureInfo.InvariantCulture));//ToString esta para formatar a variavel
                 Console.Write("Digite outro numero: ");
                 x = double.Parse(Console.ReadLine());
             }
             Console.WriteLine("Numero negativo");
             --------------------------------------------------------------------*/

            //usando for
            Console.WriteLine("Quantos numeros inteiros vc vai digitar?");
            int num = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= num ; i++)
            {
                Console.WriteLine("Digite o'" +i+"º");
                int num1 = int.Parse(Console.ReadLine());
                soma = num1 + soma;
            }
            Console.WriteLine("As soma toral é de "+soma ); 
        }
    }
}
