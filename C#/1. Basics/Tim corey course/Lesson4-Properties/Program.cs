﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Properties
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonModel person = new PersonModel("tom ", "nowak", 23);
            person.FirstName = "rob";
            //person.LastName = "nowak";
            person.Age = 40;
            person.SSN = "123-45-6789";
            person.Password = "tajne";

            Console.WriteLine(person.SSN);

            Console.WriteLine(person.FullName);


        }
    }
}
