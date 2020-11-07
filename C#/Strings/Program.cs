using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings String to int --------------------------------------------------------------------
            string s = "1234";
            int n = int.Parse(s);
            int k = Convert.ToInt32(s);

            //Trim , Toupper, Tolower , Substring,  split ----------------------------------------------
            string myName = "Robert Jastrzebski ";
            Console.WriteLine("Trim: '{0}'", myName.Trim());
            Console.WriteLine("Toupper: '{0}'", myName.ToUpper());
            Console.WriteLine("Tolower: '{0}'", myName.ToLower());


            var index = myName.IndexOf(' ');
            var firstName = myName.Substring(0, index);
            var lastName = myName.Substring(index + 1);
            Console.WriteLine(lastName);


            var names = myName.Split(' ');
            Console.WriteLine(names[0] + ' ' + names[1]);

            //replace method ------------------------------------------------------------------------------------

            var newName = myName.Replace("Robert", "Robus");
            Console.WriteLine(newName);

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("nic nie wpisałes");

            //string to number Convert method. 
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            //numer to string - ToString()
            var ver2 = age.ToString();
            Console.WriteLine(ver2);

            float price = 19.99f;
            var priceString = price.ToString("C0");
            Console.WriteLine(priceString);

            // coding summarasing-------------------------------------------------------------------------------------------------------

            var sentence =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,";
            var result = narzedzieStringow.Sumarize(sentence, 20);
            Console.WriteLine(result);

            //StringBuilder ---------------------------------------

            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10);
            builder.AppendLine();
            builder.AppendLine();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Replace('-', '+');
            builder.Insert(15, new string('-', 10));
            Console.WriteLine(builder);






        }
    }
}
