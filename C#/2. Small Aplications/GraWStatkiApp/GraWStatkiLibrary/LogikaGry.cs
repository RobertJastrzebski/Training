using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraWStatkiLibrary.Modele;

namespace GraWStatkiLibrary
{
    public static class LogikaGry
    {
        public static void ZainicjujSiatke(GraczInfo model)
        {
            List<string> letters = new List<string>
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            List<int> numbers = new List<int>()
            {
                1,
                2,
                3,
                4,
                5
            };

            foreach (string letter in letters)
            {
                foreach (var number in numbers)
                {
                    DodajMiejsce(model,letter,number);
                }
            }


        }

        private static void DodajMiejsce(GraczInfo model, string litera, int liczba)
        {

            MiejsceNaSiatce miejsce = new MiejsceNaSiatce();
            {
                miejsce.MiejsceLitera = litera;
                miejsce.MiejsceCyfra = liczba;
                miejsce.Status = StatusPola.puste;

            }

            model.LokalizacjaStrzałów.Add(miejsce);
        }

        public static bool PrzechowajMiejsceStatku(GraczInfo model, string lokalizacja)
        {

            bool output = false;
            (string wiersz, int kolumna) = RozdzielStrzalNaWierszIKolumny(lokalizacja);

            bool prawidlowaPozycja = SprawdzPozycjeNaSiatce(model, wiersz, kolumna);
            bool czyPoleWolne = SprawdzPozycjeStatku(model, wiersz, kolumna);

            if (prawidlowaPozycja && czyPoleWolne)
            {
                model.LokalizacjaStatków.Add(new MiejsceNaSiatce
                {
                    MiejsceLitera = wiersz.ToUpper(),
                    MiejsceCyfra = kolumna,
                    Status = StatusPola.Statek
                });
                output = true;
            }

            return output;
        }

        private static bool SprawdzPozycjeNaSiatce(GraczInfo model, string wiersz, int kolumna)
        {
            bool prawidłowaPozycja = false;
            foreach (var strzal in model.LokalizacjaStrzałów)
            {
                if (strzal.MiejsceLitera == wiersz.ToUpper() && strzal.MiejsceCyfra == kolumna)
                {
                    prawidłowaPozycja = true;
                }
            }

            return prawidłowaPozycja;
        }

        private static bool SprawdzPozycjeStatku(GraczInfo model, string wiersz, int kolumna)
        {
            bool prawidłowaPozycja = true;
            foreach (var statek in model.LokalizacjaStatków)
            {
                if (statek.MiejsceLitera==wiersz.ToUpper() && statek.MiejsceCyfra == kolumna)
                {
                    prawidłowaPozycja = false;
                }
            }

            return prawidłowaPozycja;
        }

        public static bool AktualnyGraczAktywny(GraczInfo gracz)
        {
            bool jestAktywny = false;
            foreach (var statek in gracz.LokalizacjaStatków)
            {
                if (statek.Status !=StatusPola.Zatopiony)
                {
                    jestAktywny = true;
                }
            }

            return jestAktywny;
        }

        public static int  LiczbaStrzałów(GraczInfo gracz)
        {
            int liczbaStrzałów = 0;
            foreach (var strzal in gracz.LokalizacjaStrzałów)
            {
                if (strzal.Status != StatusPola.puste)
                {
                    liczbaStrzałów += 1;
                }
            }

            return liczbaStrzałów;
        }

        public static (string wiersz, int kolumna) RozdzielStrzalNaWierszIKolumny(string strzał)
        {
            string wiersz = "";
            int kolumna = 0;

            if (strzał.Length != 2)
            {
                throw new ArgumentException("to jest nieprawidłowy strzał","shot");
            }
            
            char[] strzałArray = strzał.ToArray();
            wiersz = strzałArray[0].ToString();
            kolumna = int.Parse(strzałArray[1].ToString());

            return (wiersz, kolumna);


        }


        public static bool ZweryfikujStrzał(GraczInfo gracz, string wiersz, int kolumna)
        {
            bool prawidłowyStrzał = false;
            foreach (var strzał in gracz.LokalizacjaStrzałów)
            {
                if (strzał.MiejsceLitera == wiersz.ToUpper() && strzał.MiejsceCyfra == kolumna)
                {
                    if (strzał.Status== StatusPola.puste)
                    {
                        prawidłowyStrzał = true;
                        
                    } 
                }
            }

            return prawidłowyStrzał;
        }


        public static bool WynikStrzału(GraczInfo przeciwnik, string wiersz, int kolumna)
        {
            bool czyCelnyStrzał = false;
            foreach (var statek in przeciwnik.LokalizacjaStatków)
            {
                if (statek.MiejsceLitera == wiersz.ToUpper() && statek.MiejsceCyfra == kolumna)
                {
                    czyCelnyStrzał = true;
                }
            }

            return czyCelnyStrzał;
        }

        public static void ZapiszWynikStrzalu(GraczInfo gracz, string wiersz, int kolumna, bool jestTrafiony)
        {
            
            foreach (var strzał in gracz.LokalizacjaStrzałów)
            {
                if (strzał.MiejsceLitera == wiersz.ToUpper() && strzał.MiejsceCyfra == kolumna)
                {
                    if (jestTrafiony)
                    {
                        strzał.Status = StatusPola.Trafiony;
                    }
                    else
                    {
                        strzał.Status = StatusPola.Pudło;
                    }
                }
            }

            
        }
    }
}
