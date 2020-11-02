using System;
using System.Threading;

namespace ConsoleApp1
{
    

    public class Person
    {
        public string FirstName;
        public string LastName;


        public void introduce()
        {
            Console.WriteLine("My name is "+ FirstName + " " + LastName);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.introduce();
        }
    }

}



