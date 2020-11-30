using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator
{
    public class CalcEngine
    {
        public double calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;
            switch (argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "division":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;
                case "multipy":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized");
            }
            return result;
        }


    }
}
