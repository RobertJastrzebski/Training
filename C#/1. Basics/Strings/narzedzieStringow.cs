using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{


    public class narzedzieStringow
    {
        public static string Sumarize(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
                return (text);
            }


            var words = text.Split(' ');
            var totalCharacers = 0;
            var wszystkieSlowa = new List<string>();


            foreach (var word in words)
            {
                wszystkieSlowa.Add(word);

                totalCharacers += word.Length + 1;
                if (totalCharacers > maxLength)
                    break;

            }



            return string.Join(' ', wszystkieSlowa);


        }
    }
}
