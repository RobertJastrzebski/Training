using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_static_classes
{
    public static class CalculateData
    {
        public static double Dodawanie(double numberX ,double numberY)
        {
            double result = numberX + numberY;
            return result;
        }


        public static double Odejmowanie(double numberX, double numberY)
        {
            double result = numberX - numberY;
            return result;
        }


        public static double Mnozenie(double numberX, double numberY)
        {
            double result = numberX * numberY;
            return result;
        }

        public static double Dzielenie(double numberX, double numberY)
        {
            double result = numberX / numberY;
            return result;
        }




    }
}
