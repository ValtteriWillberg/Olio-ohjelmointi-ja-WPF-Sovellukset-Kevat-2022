using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_1
{
    class Ajoneuvo
    {
        public string Nimi;
        public int Nopeus;
        public int Renkaat;


        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvon nimi: " + Nimi);
            Console.WriteLine("Ajoneuvon nopeus: " + Nopeus);
            Console.WriteLine("Ajoneuvon renkaat: " + Renkaat);

        }
        public Ajoneuvo (string _nimi, int _nopeus, int _renkaat)
        {
            Nimi = _nimi;
            Nopeus = _nopeus;
            Renkaat = _renkaat;
        }
    }
}
