using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Get_Set
{
    class Program
    {

        
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1983, 12, 25));
            
            Console.WriteLine(person.Age);
            
        }
    }
}
