using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            

                var Person = new Person("rob","jastrz");
                
                Person.GenerateEmail();
                Console.WriteLine(Person.Email);

                Console.ReadLine();

        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Email { get; set; }

            public Person(string firstName,string lastName,string email)
            {
                FirstName = firstName;
                LastName = lastName;
                Email = email;

            }


            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;

            }

            public Person()
            {
                
            }

            public void GenerateEmail()
            {
                Email = $"{FirstName}.{LastName}@gmail.com";
            }

            public void GenerateEmail(string domena)
            {
                Email = $"{FirstName}.{LastName}@{domena}.com";
            }
        }
    }
}
