using System;

namespace Perintä
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö henkilö = new Henkilö("Matti", 20, 9843284);
            Opiskelija opiskelija = new Opiskelija("Pekka", 18, 7864387, 45543, "Careeria");

            henkilö.Juo();
            henkilö.Syö();

            opiskelija.Opiskele();
        }
    }
}
