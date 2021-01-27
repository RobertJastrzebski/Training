using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_InstancjeKlasy
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonModel person = new PersonModel();

            //person.firstName = "Rob";
            //person.lastname = "Nowak";
            //person.emailAddress = "abc@gmail.com";

            List<PersonModel> people = new List<PersonModel>();

            PersonModel person = new PersonModel();

            person.FirstName = "rob";

            
            people.Add(person);




            person = new PersonModel();

            person.FirstName = "Bob";
            
            people.Add(person);

            foreach (PersonModel p  in people)
            {
                Czynnosci.GreetPerson(p);
                Console.WriteLine($"{p.FirstName} {p.jestPowitany}");
            }


        }
    }
}
