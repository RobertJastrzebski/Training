using System;
using System.Runtime.InteropServices;
using GraWStatkiLibrary;
using GraWStatkiLibrary.Modele;

namespace GraWStatki
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            GraczInfo gracz1 = StworzGracza("Gracz 1");
            GraczInfo gracz2 = StworzGracza("Gracz 2");

        }





        private static void WelcomeMessage()
        {
            Console.WriteLine("Witaj  w Grze w statki");
            Console.WriteLine("Gra zrobiona przez Robert J.");
            Console.WriteLine();
        }

        private static GraczInfo StworzGracza(string tytulGracza)
        {
            Console.WriteLine($"Informacja dla gracza {tytulGracza}");
            GraczInfo output = new GraczInfo();

            //Zapytaj gracza  1 jak ma na imię.
            output.ImieGracza = ZapytanieOImionaGraczy();

            //Pokazanie Planszy
            LogikaGry.ZainicjujSiatke(output);

            //Poproś gracza o rozlokowanie 5 statków na planszy
            RozlokujStaki(output);

            //wyczysc console
            Console.Clear();
            return output;
        }



        private static string ZapytanieOImionaGraczy()
        {
            
            Console.WriteLine("Jak masz na Imie ?");
            string output  = Console.ReadLine();
            return output;
        }

        private static void RozlokujStaki(GraczInfo model)
        {
            do
            {
                Console.WriteLine($"Gdzie chcesz umiescic statek numer {model.LokalizacjaStatków.Count+1}: ?");
                string lokalizacja = Console.ReadLine();

                bool isValidLocation = LogikaGry.PrzechowajMiejsceStatku(model, lokalizacja);
                if (isValidLocation==false)
                {
                    Console.WriteLine("To nie jest prawidłowa lokalizacja.Spróbuj jeszcze raz");
                }

            } while (model.LokalizacjaStatków.Count < 5);
        }


    }
}
