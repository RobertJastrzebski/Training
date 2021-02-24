using System;
using NUnit.Framework;

namespace Kalkulator.UnitTest
{
    [TestFixture]
    public class InputConverterUnitTests
    {

        private InputConverter _InputConverter = new InputConverter();

        [Test]
        public void ConvertInputToNumeric_ConvertsStringIntoDouble_ReturnDouble() 
        {

            double result = _InputConverter.ConvertInputToNumeric("20");

            Assert.That(result, Is.EqualTo(20));


        }

        [Test]
        [TestCase("rrr")]
        public void ConvertInputToNumeric_FailsConvertsStringIntoDouble_ReturnExeption(string error)
        {

            double result = _InputConverter.ConvertInputToNumeric(error);
            //DO dokończenia !!!!!!!!!!!!!
        }
    }
}