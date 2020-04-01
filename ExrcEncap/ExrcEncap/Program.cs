using System;
using System.Globalization;

namespace ExrcEncap
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("digitar numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digitar nome do Titular: ");
            string titular = Console.ReadLine();

            Console.Write("Deposito inicial S/N: " );
            char depInicial = char.Parse(Console.ReadLine());
            if (depInicial == 'S' ){
                Console.WriteLine("digite o valor do deposito inicial: ");
                double saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, saldo);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("Entre com valor para deposito: ");
            double quantia  = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("Entre com valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

        }
    }
}
