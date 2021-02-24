using Kalkulator;
using NUnit.Framework;

namespace Kalkulator.UnitTest
{
    public class CalcEngineTests
    {

        private CalcEngine _calcEngine;

            //opis metody w teœcie  -  metoda_scenariusz_Wynik

        [SetUp]
        public void SetUp()
        {
           _calcEngine = new CalcEngine();
        }
        


        [Test]
        [TestCase("+",2,2,4)]
        [TestCase("+",1,1,2)]
        [TestCase("+",2,6,8)]
        public void CalcEngine_WhenCalled_ReturnSumOfTwoArguments(string x ,int a, int b, int expectedResult)
        {
            //arrange
            


            //act
            var result = _calcEngine.calculate(x, a, b);
            
            
            //Assert
            Assert.AreEqual(expectedResult, result);

            // inna metoda na assert =   Assert.That(result,Is.EqualTo(3));

        }

        [Test]
        [Ignore("Not valid test")]

        public void CalcEngine_SubtractTwoNumbers_ReturnSubtractOfTwoArguments()
        {
            //arrange
            
            //act
            var result = _calcEngine.calculate("-", 2, 1);
            //Assert
            Assert.AreEqual(result,1);

        }

        [Test]
        public void CalcEngine_DevisionTwoNumbers_ReturnDevisionOfTwoArguments()
        {
            //arrange
            
            //act
            var result = _calcEngine.calculate("/", 2, 1);
            //Assert
            Assert.AreEqual(result, 2);

        }


        [Test]
        public void CalcEngine_MultiplyTwoNumbers_ReturnMultiplyOfTwoArguments()
        {
            //arrange
            
            //act
            var result = _calcEngine.calculate("multiply", 2, 2);
            //Assert
            Assert.AreEqual(result, 4);

        }


    }

}