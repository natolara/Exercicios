using System;

namespace dateTimeandSpan_time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine(d.Ticks);

            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.UtcNow;
            DateTime d3 = DateTime.Today;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime d11 = DateTime.Parse("2000-08-15");
            DateTime d22 = DateTime.Parse("2000-08-15 13:05:58"); 
            DateTime d33 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d11);
            Console.WriteLine(d22);
            Console.WriteLine(d33);
            Console.WriteLine(d44);

        }
    }
}
