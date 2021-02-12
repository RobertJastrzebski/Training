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
            throw new NotImplementedException();
        }

        public static bool AktualnyGraczAktywny(GraczInfo przeciwnik)
        {
            throw new NotImplementedException();
        }

        public static int  LiczbaStrzałów(GraczInfo wygrany)
        {
            throw new NotImplementedException();
        }

        public static (string, int) RozdzielStrzalNaWierszIKolumny(string strzał)
        {
            throw new NotImplementedException();
        }

        public static bool ZweryfikujStrzał(GraczInfo aktywnyGracz, string wiersz, int kolumna)
        {
            throw new NotImplementedException();
        }

        public static bool WynikStrzału(GraczInfo przeciwnik, string wiersz, int kolumna)
        {
            throw new NotImplementedException();
        }

        public static void ZapiszWynikStrzalu(GraczInfo aktywnyGracz, string wiersz, int kolumna, bool jestTrafiony)
        {
            throw new NotImplementedException();
        }
    }
}
