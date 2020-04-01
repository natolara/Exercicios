using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";


            double preco = 21000.0;
            double preco1 = 650.50;
            double medida = 53.5465789;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo o preço é de {1:F2}", produto1, preco);
            Console.WriteLine(produto2 + ", cujo o preço é de " + preco1);
            Console.WriteLine("Medida com oito casa decimais: " + medida.ToString("F5"));
            Console.WriteLine("separador decimal invariant culture " + medida.ToString("F2", CultureInfo.InvariantCulture));


            double a;
            float b;
            a = 1.5;
            b = (float)a;
            Console.WriteLine(b.ToString("F20"));
            Console.WriteLine(a.ToString("F18"));

            int c;
            float d;
            Console.WriteLine("Digite um numero");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero");
            d = float.Parse(Console.ReadLine());

            double resultado = (double)c / (double)d;
            Console.WriteLine(resultado);



            Console.WriteLine("Digite tres palavras");
            //funçao split separa palavras eem cada variavel em vetor 
            //string s = Console.ReadLine();
            //string[] vet = s.Split(' ');
            string[] vet = Console.ReadLine().Split(' ');
            string q = vet[0];
            string w = vet[1];
            string e = vet[2];*/

            //Console.WriteLine(q);
            //Console.WriteLine(w);
            //Console.WriteLine(e);



            //Console.WriteLine("Digite nome, sexo M ou F, idade e altura:");
            //string[] vet1 = Console.ReadLine().Split(' ');
            //string nome = vet1[0];
            //char sexo = char.Parse(vet1[1]);
            //int idade = int.Parse(vet1[2]);
            //float altura = float.Parse(vet1[3]);

            //Console.WriteLine("Seu nome é {0}, do sexo {1}, a sua idade {2} e sua altura é " + altura.ToString("F2", CultureInfo.InvariantCulture), nome, sexo, idade);

            Console.WriteLine("Digite um numero inteiro");
            int x = int.Parse(Console.ReadLine());
            
            if (x % 2 ==0)
            {
                Console.WriteLine("{0} é par!!!", x);
            }
            else
            {
                Console.WriteLine(x+" é impar!!!!");
            }


            Console.WriteLine("Qual a a hora? ");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tardde");
            }
            else
            {
                Console.WriteLine("Baa noite");
            }

        }
    }
}