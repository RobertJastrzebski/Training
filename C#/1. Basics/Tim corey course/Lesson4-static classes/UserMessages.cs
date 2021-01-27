using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_static_classes
{
    public static class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            Console.Clear();
            Console.WriteLine("Witam w statycznej klasie ");
            int hourOfDay = DateTime.Now.Hour;
            if (hourOfDay<12)
            {
                Console.WriteLine($"Good morning {firstName} ");  
                
            }
            else if (hourOfDay <19)
            {
                Console.WriteLine($"good afternoon {firstName}");
            }
            else
            {
                Console.WriteLine($"good evening {firstName}");
            }

            
        }

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank you for using this app.");
        }








    }
}
