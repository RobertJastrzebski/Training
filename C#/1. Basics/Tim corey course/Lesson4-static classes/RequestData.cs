using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_static_classes
{
    public static class RequestData
    {


        public static string  GetUserFirstName(string userFirstName)
        {
            Console.WriteLine(userFirstName);
            string firstName = Console.ReadLine();
            return firstName;
        }


        public static double GetDouble(string UserFavoriteNumber)
        {
            Console.WriteLine(UserFavoriteNumber);
            string numberText = Console.ReadLine();
            double userDouble;

            bool isDouble = double.TryParse(numberText, out userDouble);
            while (isDouble == false)
            {
                Console.WriteLine("To nie jest poprawna liczba. Prosze wpisz poprawna liczbe.");
                Console.WriteLine(UserFavoriteNumber);
                numberText = Console.ReadLine();
                isDouble = double.TryParse(numberText, out userDouble);

            }

            return userDouble;

        }



    }

    



}
