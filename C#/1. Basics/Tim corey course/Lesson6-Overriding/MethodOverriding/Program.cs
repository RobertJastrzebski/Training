using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MethodOverriding
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            person.FirstName = "Rob";
            person.LastName = "Jas";
            person.Email = "rob@gmail.com";


            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}
