using System;

namespace Testi
{
    class Program
    {
        static void Main(string[] args)
        {
            koira koira1 = new koira();
            koira1.nimi = "Rekku";
            koira1.ikä = 4;
            koira1.rotu = "Saksanpaimenkoira";

            koira1.Hauku();
            koira1.TulostaData();

            koira koira2 = new koira("Urho", 5, "Mopsi");
        }
    }
}
