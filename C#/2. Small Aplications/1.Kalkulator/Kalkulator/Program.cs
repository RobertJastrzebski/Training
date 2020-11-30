using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalcEngine calcEngine = new CalcEngine();

                Console.Write("Provide one number:");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Provide second number:");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Provide operation symbol:");
                string operation = Console.ReadLine();

                double result = calcEngine.calculate(operation, firstNumber, secondNumber);
                Console.WriteLine("The final result is : {0} {1} {2} = {3}",firstNumber,operation,secondNumber,result );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
        }
    } 
}
