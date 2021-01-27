using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;




//Zbierz info o gościach.(przynajmniej jeden gość, max liczba gosci nie jest znana) 
//Informacje takie jak :Imie ,Nazwisko, wiadomośc dla gości , wiek.
//Wylistuj wszystkich gości oraz ich informacje o gościach. 

namespace ConsoleUI
{
    
    class Program
    {

        

        
        private static List<GuestModel> guests = new List<GuestModel>();
        
        static void Main(string[] args)
        {
        
        GetGuestInfomation();
            
        PrintGuestInformation();
        

        }


       



        private static void GetGuestInfomation()
        {

            string moreGuestsComing = "";
            do
            {
                GuestModel guest = new GuestModel();

                
                guest.FirstName = GetInfoFromConsole("What is Your first name?");

                
                guest.LastName = GetInfoFromConsole("What is your last name ?");

                
                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");

                string wiekString = GetInfoFromConsole("What is your age ?");

                bool isValid = int.TryParse(wiekString, out int wiek);
                guest.Wiek = wiek;
                
                moreGuestsComing = GetInfoFromConsole("Are more guest Comming? (yes/no): ");

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");

            
        }



        private static void PrintGuestInformation()
        {

            foreach (var guest in guests)
            {
                Console.WriteLine($"{guest.GuestInfo} Wiek : {guest.Wiek}");
            }

        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";
            Console.WriteLine(message);
            output = Console.ReadLine();
            return output;
        }


        
      


    }
}
