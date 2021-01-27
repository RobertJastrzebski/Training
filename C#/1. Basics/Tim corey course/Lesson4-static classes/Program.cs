using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_static_classes
{
    class Program
    {
        static void Main(string[] args)
        {

            string userFirstName = RequestData.GetUserFirstName("What is your first Name ?");
            UserMessages.ApplicationStartMessage(userFirstName);
            double userNumberX =  RequestData.GetDouble("what is Your first number ");
            double userNumberY = RequestData.GetDouble("what is Your second number ");
            double resultDodawanie = CalculateData.Dodawanie(userNumberX, userNumberY);
            double resultOdejmowanie = CalculateData.Odejmowanie(userNumberX, userNumberY);
            UserMessages.PrintResultMessage($"The sum of {userNumberX} and {userNumberY} is {resultDodawanie}");
            UserMessages.PrintResultMessage($"The substraction of {userNumberX} and {userNumberY} is {resultOdejmowanie}");
        }

        
        


    }
}
