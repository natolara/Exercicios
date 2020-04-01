using ExrComposicaoEnumeracao.Entities;
using System;

namespace ExrComposicaoEnumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client date: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Bith date (DD/MM/YYYY): ");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order date: ");
            Console.WriteLine("Status :");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            foreach (OrderItem item in itens)
            {

            }
        }
    }
}
