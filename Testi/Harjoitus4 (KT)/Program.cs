using System;

namespace Harjoitus4__KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi();

            albumi.LisääKappale(new Kappale("Kappale 1", "06:45"));
            albumi.LisääKappale(new Kappale("Kappale 2", "03:21"));
            albumi.LisääKappale(new Kappale("Kappale 3", "02:54"));

            albumi.TulostaKappaleet();
        }
    }
}
