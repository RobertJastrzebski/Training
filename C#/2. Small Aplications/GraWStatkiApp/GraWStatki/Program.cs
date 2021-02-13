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
            GraczInfo aktualnyGracz = StworzGracza("Gracz 1");
            GraczInfo przeciwnik = StworzGracza("Gracz 2");
            GraczInfo wygrany = null;


            do
            {
                 
                WyswietlStrzały(aktualnyGracz);

                
                ZapiszStrzałGracza(aktualnyGracz, przeciwnik);

                bool CzyGramyDalej = LogikaGry.AktualnyGraczAktywny(aktualnyGracz);

                if (CzyGramyDalej == true)
                {
                    //Jezeli tak zmień aktualnego gracza na przeciwnika. 
                    (aktualnyGracz, przeciwnik) = (przeciwnik, aktualnyGracz);

                }
                else
                {
                    //Jeżeli nie gramy dalej ustaw gracza aktualnego jako wygranego
                    wygrany = aktualnyGracz;
                }


            } while (wygrany == null);

            UstalWygranego(wygrany);


        }

        private static void UstalWygranego(GraczInfo wygrany)
        {
            Console.WriteLine($"Gratulacja dla {wygrany.ImieGracza} Wygrales!!!");
            Console.WriteLine($"{wygrany.ImieGracza} wygral oddajac {LogikaGry.LiczbaStrzałów(wygrany)}  strzalów");
        }

        private static void ZapiszStrzałGracza(GraczInfo aktywnyGracz, GraczInfo przeciwnik)
        {

            //Zapytaj gracza gdzie chce strzelic?
            //Okreslic jaki rzad i kolumna
            //Okreslic czy to jest prawidłowy strzał 
            //Wrocic do poczatku jezeli nieprawidłowy strzał. 


            bool celnyStrzał = false;
            string wiersz = "";
            int kolumna = 0;

            do
            {
                string strzał = GraczStrzela();
                ( wiersz,  kolumna) = LogikaGry.RozdzielStrzalNaWierszIKolumny(strzał);
                celnyStrzał = LogikaGry.ZweryfikujStrzał(aktywnyGracz, wiersz, kolumna);

                if (celnyStrzał == false)
                {
                    Console.WriteLine("Nieprawidłowy strzał spróbój jeszcze raz");
                    
                }
            } while (celnyStrzał==false);
            
            
            //Okresl wynik strzałów. 
           

            bool jestTrafiony = LogikaGry.WynikStrzału(przeciwnik, wiersz, kolumna);

            //Zapisz Strzały
            LogikaGry.ZapiszWynikStrzalu(aktywnyGracz, wiersz, kolumna, jestTrafiony);
            
        }

        private static string GraczStrzela()
        {
            Console.Write("Prosze podaj strzał : ");
            string output = Console.ReadLine();
            return output;
        }

        private static void WyswietlStrzały(GraczInfo aktywnyGracz)
        {

            string aktualnyRzad = aktywnyGracz.LokalizacjaStrzałów[0].MiejsceLitera;

            foreach (var strzał in aktywnyGracz.LokalizacjaStrzałów)
            {
                

                if (strzał.MiejsceLitera != aktualnyRzad)
                {
                    Console.WriteLine();
                    aktualnyRzad = strzał.MiejsceLitera;
                }

                if (strzał.Status == StatusPola.puste)
                {
                    Console.Write($"{strzał.MiejsceLitera}{strzał.MiejsceCyfra}");
                }
                else if (strzał.Status== StatusPola.Trafiony)
                {
                    Console.Write(" X ");
                }
                else if (strzał.Status==StatusPola.Pudło )
                {
                    Console.Write(" O ");
                }
                else
                {
                    Console.Write(" ? ");
                }

            }

            
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

            //Pokazanie Plansze
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
                    Console.WriteLine("To nie jest prawidłowa lokalizacja. Spróbuj jeszcze raz");
                }

            } while (model.LokalizacjaStatków.Count < 5);
        }


    }
}
