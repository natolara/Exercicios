using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hora inicial");
            int horaInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Hora final");
            int horaFinal = int.Parse(Console.ReadLine());
            int duracao = 0;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }

            else
            {
                duracao = (24 - horaInicial ) + horaFinal;
                
            }
            
            Console.WriteLine("O jogo durou {0} horas", duracao);
*/
            Console.WriteLine("Digite tres numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);
            Console.WriteLine("o numero maior é :" +resultado);

        }
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }

}

