using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Section2

{
    class Program
    {
        
        private static Dictionary<string, int> guestList = new Dictionary<string, int>();
        private static int guestsAll = 0;
        

        static void Main(string[] args)
        {
            //Arrays-----------------------------------------------------------------------------
            //string[] firstNames = new string[5];

            //firstNames[0] = "Rob";
            //firstNames[1] = "Seba";
            //firstNames[2] = "Asia";
            //firstNames[4] = "Hubert";

            //Console.WriteLine($"1 name has : {firstNames[0]}");
            //Console.WriteLine($"2 name has : {firstNames[1]}");
            //Console.WriteLine($"3 name has : {firstNames[2]}");
            //Console.WriteLine($"4 name has : {firstNames[3]}");
            //Console.WriteLine($"5 name has : {firstNames[4]}");

            //string imiona = "Rob,Franek,Tomek,Maria";
            //string[] imionaArray = imiona.Split(',');


            //Console.WriteLine(imionaArray[1]);

            //int[] liczby = new int[3];
            //liczby[0] = 1;
            //liczby[1] = 123;
            //liczby[2] = 121;

            //int result;
            //string[] nazwiska = new string[3] { "tomi", "bobi", "tobi" };

            //Console.WriteLine("które imie wybierasz poda od 1-3");
            //string choice = Console.ReadLine();

            //bool isValid = int.TryParse(choice, out result);

            //if (result == 1)
            //{
            //    Console.WriteLine($"{nazwiska[0]}");
            //}
            //else if (result == 2)
            //{
            //    Console.WriteLine(nazwiska[1]);

            //}
            //else
            //{
            //    Console.WriteLine(nazwiska[2]);
            //}

            //LISTS--------------------------------------------------------------------------------------------------


            //List<string> firstNames = new List<string>();

            //firstNames.Add("rob");
            //firstNames.Add("robson");
            //Console.WriteLine($"first element is {firstNames[0]}");
            //firstNames[0] = firstNames[0].ToUpper();
            //firstNames.Remove("rob");
            //Console.WriteLine($"first element is {firstNames[0]}");

            //var liczbaImion =  firstNames.Count();
            //Console.WriteLine(liczbaImion);
            //foreach (var VARIABLE in firstNames)
            //{
            //    Console.WriteLine(VARIABLE);
            //}

            //Dictionary---------------------------------------------------------------


            //Dictionary<int, string> importantYears = new Dictionary<int, string>();

            //importantYears[1983] = "moja data urodzenia";
            //importantYears[2017] = "new house";
            //importantYears[2020] = "covid starts";
            //importantYears.Add(2021, "Joe Biden new president of USA");

            //int result;
            //Console.WriteLine("what is your important year   1983 or 2017 or 2020  ? ");
            //string response = Console.ReadLine();
            //bool isValid = int.TryParse(response, out result);
            //Console.WriteLine($"Your important Year is {response} where : {importantYears[result]}");


            //for loop exercise
            //Console.WriteLine("Podaj 3 imiona po przecinku");
            //string listOfNames =Console.ReadLine();
            //string[] imionaArray= listOfNames.Split(',');
            //for (int i = 0; i < imionaArray.Length; i++)
            //{
            //    Console.WriteLine($"hello {imionaArray[i]}");
            //}

            //foreach loop 

            //Dictionary<int, string> importantYears = new Dictionary<int, string>();

            //importantYears[1983] = "moja data urodzenia";
            //importantYears[2017] = "new house";
            //importantYears[2020] = "covid starts";
            //importantYears.Add(2021, "Joe Biden new president of USA");


            //foreach (var year in importantYears)
            //{
            //    Console.WriteLine($"{year.Key} , {year.Value}" );
            //}
            //Guest book ---------------------------------------------------------------------------------------------
        
        
        
        Welcome();
        CalculateGuests();
        ListGuestList();



        }

        
        
        
        
        private static void Welcome()
        {
            string wantQuit;
            do
            {
                
                Console.WriteLine("Hello welcome to guest book. ");
                string guestName = GetGuestInfo("What is Your name");
                string guestNumbersString = GetGuestInfo("How many guest you have in your party ??");
                bool isValid = int.TryParse(guestNumbersString, out int guestNumber);
                guestList.Add(guestName, guestNumber);

                CalculateGuests();
                Console.WriteLine("Do you want to continue ?? Y/N");
                
                wantQuit = Console.ReadLine().ToUpper();
            } while (wantQuit=="Y");
        }

        

        private static string GetGuestInfo(string message)
        {
            Console.WriteLine(message);
            var output = Console.ReadLine();
            return output;
        }

        private static  void CalculateGuests()
        {
            foreach (var guest in guestList)
            {
                guestsAll += guest.Value;
                
            }
            Console.WriteLine($"all guests: {guestsAll}");
            
        }


        private static void ListGuestList()
        {
            foreach (var guest in guestList)
            {
                Console.WriteLine($"gość: {guest.Key} liczba gości: {guest.Value}");
            }
        }

    }
    
}
