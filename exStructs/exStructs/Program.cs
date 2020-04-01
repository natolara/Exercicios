using System;

namespace exStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);

            //a forma structs pode ser iniciada da forma acima ou com new
            p = new Point();
            Console.WriteLine(p);


            /*valores padrao
             * numero = 0;
            bool = false;
            char = caracter codigo 0;
            objeto null*/

            // Nullable<double> x = null; forma completa
            double? x = null; // forma simplificada
            double? y = 50.00;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            Console.WriteLine(x.Value);
            else
            {
                Console.WriteLine("x é nulo");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y é nulo");
            }

            //operador de coalescencia nula
            double? s = null;
            double z = s ?? 0.00;
            Console.WriteLine(z);


        }
    }
}
