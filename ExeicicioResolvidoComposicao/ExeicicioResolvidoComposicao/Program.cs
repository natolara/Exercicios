using System;
using ExeicicioResolvidoComposicao.Entities.enums;
using ExeicicioResolvidoComposicao.Entities;
using System.Globalization;

namespace ExeicicioResolvidoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departmet's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter Work data: ");
            
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior, MidLevel, Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());  
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // instancias
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);
            
            Console.Write("How many contract to this worker: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //interpolação ${}
                Console.Write($"Enter #{i} contract data: ");
                Console.Write("Date(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Durations(hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, value, hours);
                worker.AddContract(contract);

            }
            Console.WriteLine();

            Console.Write("Enter month and year to calculate income(MM/YYYY): ");
            string monthAndYears = Console.ReadLine();
            int month = int.Parse(monthAndYears.Substring(0, 2));
            int year = int.Parse(monthAndYears.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for: " + monthAndYears +" : " + worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
