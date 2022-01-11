﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Perintä
{
    class Opiskelija : Henkilö
    {
        public int opiskelijaID;
        public string koulu;

        public Opiskelija(string nimi, int ikä, int henkilötunnus, int _opiskelijaID, string _koulu) : base(nimi, ikä, henkilötunnus)
        {
            opiskelijaID = _opiskelijaID;
            koulu = _koulu;
        }
        public override void TulostaTiedot()
        {
            Console.WriteLine("Opiskelija " + Nimi + ". Ikä: " + Ikä + ". Koulu: " + koulu + ". OpiskeiljaID: " + opiskelijaID);
        }

        public void Opiskele()
        {
            Console.WriteLine(Nimi + " opiskelee.");
        }
    }
}
