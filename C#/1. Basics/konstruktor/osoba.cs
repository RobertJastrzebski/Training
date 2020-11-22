using System;
using System.Collections.Generic;
using System.Text;

namespace konstruktor
{
    class osoba
    {
        private string imie;
        private string nazwisko;
        private string miasto;
        private string ulica;
        private int wiek;

        public osoba()
        {
            imie = "default";
            nazwisko = "default";
            miasto = "default";
            ulica = "default";
            wiek = 10;

            Console.WriteLine("zadziałał kontrutkor domyślny");
        }

        public osoba(string imie, string nazwisko, string miasto, string ulica, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.miasto = miasto;
            this.ulica = ulica;
            this.wiek = wiek;
            Console.WriteLine("zadziałał kontrutkor 5 parametrowy");


        }


        public osoba(string imie, string nazwisko, string miasto)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.miasto = miasto;

            Console.WriteLine("zadziałał kontrutkor 3 parametrowy");

        } 

        public osoba(string imie, string nazwisko) : this(imie, nazwisko, "katowice", "miła 16", 18)
        {
            Console.WriteLine("zadziałał kontrutkor 2 parametrowy");
        }


}
}
