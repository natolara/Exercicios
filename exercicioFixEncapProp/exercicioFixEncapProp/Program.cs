using System;
using System.Globalization;

namespace exercicioFixEncapProp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCliente conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial(s/n): ");

            char depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial=='s')
            {
                Console.Write("Entre com valor para deposito: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaCliente(numero, titular, saldo);
                
            }
            else
            {
                conta = new ContaCliente(numero, titular);
                
            }

            Console.WriteLine("Dados da conta :");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com valor para saque: ");
            quantia= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.Write(conta);

        }
    }
}
