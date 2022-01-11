using System;

namespace Harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 15;
            float b = 30;

            Console.WriteLine(Laskin.Summa(a, b));
            Console.WriteLine(Laskin.Erotus(a, b));
            Console.WriteLine(Laskin.Kerto(a, b));
            Console.WriteLine(Laskin.Jako(a, b));
        }
    }
}
