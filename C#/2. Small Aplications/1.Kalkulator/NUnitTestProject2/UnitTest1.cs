using Kalkulator;
using NUnit.Framework;

namespace Nunit.Kalkulator.UnitTest
{
    public class Tests
    {

        
        

        [Test]
        public void CalcEngine_addingTwoNumbers_correctResult()
        {
            //arrange
            var _calcEngine = new CalcEngine();
            int number1 = 1;
            int number2 = 2;
            //act
            double result = _calcEngine.calculate("+", number1, number2);
            //Assert
            Assert.AreEqual(3, result);


        }
    }
}