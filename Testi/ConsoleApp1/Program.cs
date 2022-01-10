using System;

namespace Harjoitus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo auto = new Ajoneuvo("Toytota", 400, 4);

            auto.TulostaData();

            Ajoneuvo vene = new Ajoneuvo("Buster", 999, 0);

            vene.TulostaData();
        }
    }
}
