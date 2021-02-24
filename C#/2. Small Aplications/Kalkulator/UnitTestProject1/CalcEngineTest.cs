using Kalkulator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kalkulator.UnitTests
{
    [TestClass]
    public class CalcEngineTest
    {


        private readonly CalcEngine _calcEngine = new CalcEngine();

        [TestMethod]
        public void Add_ReturnValidResult_3()
        {
            int number1 = 1;
            int number2 = 2;

            double result = _calcEngine.calculate("+", number1, number2);


            Assert.AreEqual(3,result);
        }
    }
}
