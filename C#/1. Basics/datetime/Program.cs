using System;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2020, 11, 3);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine("day" + now.Day + "hour" + now.Hour + "minute" + now.Minute );
            Console.WriteLine(today);
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString("yy-MM-dd"));

            var timeSpan = new TimeSpan(1, 2, 3);

            


        }
    }
}
