using System;

namespace Kalkulator
{
    public class InputConverter
    {
       
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput,out convertedNumber))
            {
             throw   new ArgumentException("This is not a number!");
             
            }
            return convertedNumber;

        }
    }
}