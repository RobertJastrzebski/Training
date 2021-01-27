using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Breakpoints
{
    class Program
    {
        static void Main(string[] args)
        {

            RunALot();
            Console.ReadLine();


        }


        private static void RunALot()
        {
            long total = 0;
            int test = 0;

            for (int i = -1000; i <= 1000; i++)
            {
                total += i;
                try
                {
                    test = 5 / i;
                }
                catch 
                {
                    Console.WriteLine("wyskoczył wyjatek.");
                    
                }
            }

            Console.WriteLine($"The total is {total}");
        }
    }
}
