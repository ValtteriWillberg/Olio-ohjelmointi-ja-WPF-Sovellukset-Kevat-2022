using System;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas Kiuas = new Kiuas("Sampo", 100, 20);

            Kiuas.NäytäTiedot();
            Kiuas.Tila = true;
            Kiuas.NäytäTiedot();
            Kiuas.SäädäLämpötila(300);
            Kiuas.SäädäKosteus(0);
            Kiuas.NäytäTiedot();

            
        }
    }
}
