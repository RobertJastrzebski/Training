using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {

         //var nowa = new LoopsExercise();
         //nowa.Loops();



         bool kontynuowacRozszyfrowanie = true;
         do
         {
             Console.WriteLine("Prosze wpisz opcje F dla pliku oraz M dla wprowadzenia manualnego");
             var odpowiedzUzytkownika = Console.ReadLine() ?? string.Empty;

             switch (odpowiedzUzytkownika.ToUpper())
             {
                    case "F":
                        Console.Write("Wpisz nazwe pliku zaszyfrowanych słów.");
                        WykonajZaszyfrowaneSlowaZpliku();
                        break;
                    case "M":
                        Console.Write("Wpisz zaszyfrowane słowa ręcznie.");
                        WykonajZaszyfrowaneSłowaWypisaneRecznie();
                        break;
                    default:
                        Console.Write("Nie rozpoznano takiej opcji.");
                        break;
             }
                var kontynuacjaZapytania = string.Empty;
                do
                {
                    Console.WriteLine(" Czy chcesz kontynuować ? Y/N");
                    kontynuacjaZapytania = (Console.ReadLine() ?? string.Empty);

                } while (!kontynuacjaZapytania.Equals("Y",StringComparison.OrdinalIgnoreCase)&& 
                         !kontynuacjaZapytania.Equals("N",StringComparison.OrdinalIgnoreCase));

                kontynuowacRozszyfrowanie = kontynuacjaZapytania.Equals("Y",StringComparison.OrdinalIgnoreCase);

             


         } while (kontynuowacRozszyfrowanie);



        }

        private static void WykonajZaszyfrowaneSłowaWypisaneRecznie()
        {
            
        }

        private static void WykonajZaszyfrowaneSlowaZpliku()
        {
            
        }
    }
}
