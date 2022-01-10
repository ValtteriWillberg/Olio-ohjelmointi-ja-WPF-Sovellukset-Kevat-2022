using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_2
{
    class Opiskelija
    {
        public string Nimi;
        public string OpiskelijaID;
        public int Opintopisteet;

        public void TulostaData()
        {
            Console.WriteLine("Opiskeljan nimi: " + Nimi);
            Console.WriteLine("Opiskelijan ID: " + OpiskelijaID);
            Console.WriteLine("Oppilaan opintopiseet: " + Opintopisteet);

        }
        public Opiskelija (string _nimi, string _opiskelijaid, int _opintopisteet)
        {
            Nimi = _nimi;
            OpiskelijaID = _opiskelijaid;
            Opintopisteet = _opintopisteet;
        }

        public void MuokaaOpintopisteitä(int määrä)
        {
            Opintopisteet += määrä;
        }
    }

}
