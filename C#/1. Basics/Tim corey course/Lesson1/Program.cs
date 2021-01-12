using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1.lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("What is you Second name?");
            //string secondName = Console.ReadLine();
            //Console.WriteLine("what is your age ?");
            //string ageText = Console.ReadLine();
            
            //bool isValidAge = int.TryParse(ageText,out int age);
            //if (isValidAge)
            //{
            //    Console.WriteLine("your age is " + age);
            //}
            //else
            //{
            //    Console.WriteLine("This is not a numeric value");
            //    return;
            //}


            //string formatedName = String.Empty;
            //if (firstName.ToLower() == "rob" || firstName.ToLower() == "bob")
            //{
            //    formatedName = $"Profesor {firstName}";
                
            //}
            //else
            //{
            //    formatedName = firstName;
                
            //}



            //if (age>18)
            //{
            //    Console.WriteLine($"hello you age is {age} you can enter{formatedName}");
            //}
            //else
            //{
            //    Console.WriteLine($"hello {formatedName} your age is {age} .You need to wait {18-age} years to enter");
            //}

            string response;
            do
            {
                Console.WriteLine("What is you name?");
                string name = Console.ReadLine();
                if (name.ToLower() =="tim")
                {
                    Console.WriteLine("Hello Proffesor");
                }
                else
                {
                    Console.WriteLine($"hi {name}");
                }

                Console.WriteLine("If you want to quit type exit");
                 response = Console.ReadLine();

            } while (response.ToLower()!="exit");

            



        }
    }
}
