using System;

namespace KartaOcenFilmow
{
    class Program
    {
        static void Main(string[] args)
        {
            karta karta= new karta();
            karta.DodajOcene(3);
            karta.DodajOcene(6);
            karta.DodajOcene(9);

            KartaStatystyki statystyki = karta.ObliczStatystyki();

            Console.WriteLine("strednia ocena" + " " + statystyki.sredniaOcena);
             
            for (;;)
            {
                Console.WriteLine("Podaj ocene z zakresu 1-10");
                float ocena;
                bool wynik = float.TryParse(Console.ReadLine(), out ocena);

                if (wynik)
                {
                    if (ocena == 11)
                    {
                        break;
                    }

                    if (ocena > 0 && ocena <= 10)
                    {
                        karta.DodajOcene(ocena);
                    }
                    else
                    {
                        Console.WriteLine("liczba z poza zakresu");
                    }
                }
                else
                {
                    Console.WriteLine("to nie jest liczba!");
                }
                


                

            }
            Console.WriteLine("srednia ocena to " + karta.ObliczSrednia());
            Console.WriteLine("najwyzsza ocena to " + karta.NajwyzszaOcena());
            Console.WriteLine("najnisza ocena to " + karta.NajnizszaOcena());

            Console.ReadKey();



        }

    }
}
