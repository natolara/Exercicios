using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: "+ func );
            Console.Write("Digite a porcentagem para aumentar   o salario: ");
            double porcent = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcent);
            Console.WriteLine("Dados atualizados: "+ func);


        }
    }
}
