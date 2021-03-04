using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var FizzBuzz = new FizzBuzz();
            var result = FizzBuzz.GetOutput(2);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
