using System;

namespace Harjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija Opiskelija1 = new Opiskelija("Väinämöinen", "jjkhdd", 10);
            Opiskelija1.TulostaData();
            Opiskelija1.MuokaaOpintopisteitä(10);
            Opiskelija1.MuokaaOpintopisteitä(20);
            Opiskelija1.TulostaData();
            
        }
        
    }
}
