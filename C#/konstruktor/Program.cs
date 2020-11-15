using System;

namespace konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            osoba osoba1 = new osoba();
            osoba osoba2 = new osoba("Jan", "Kowalski");
            osoba osoba3 = new osoba("Jan","Nowak","Gdynia");
            osoba osoba4 = new osoba("Jan", "Jablonski", "Gdynia", "korzenna", 87);

        }
    }
}
