using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzUnitTests
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        public void GetOutput_InputIsDevisibleBy3And5_ReturnFizzBuzz(int number,string wordFizzBuzz)
        {


            //Act
            var result = FizzBuzz.GetOutput(number);
            //Assert
            Assert.That(result,Is.EqualTo(wordFizzBuzz));
        }

        [Test]
        [TestCase(9, "Fizz")]
        public void GetOutput_InputIsDevisibleBy3only_ReturnFizz(int number, string wordFizzBuzz)
        {


            //Act
            var result = FizzBuzz.GetOutput(number);
            //Assert
            Assert.That(result, Is.EqualTo(wordFizzBuzz));
        }


        [Test]
        [TestCase(50, "Buzz")]
        public void GetOutput_DevisibleBy5only_Buzz(int number, string wordFizzBuzz)
        {


            //Act
            var result = FizzBuzz.GetOutput(number);
            //Assert
            Assert.That(result, Is.EqualTo(wordFizzBuzz));
        }

        [Test]
        [TestCase(1, "1")]
        public void GetOutput_InputIsNotDevisibleBy3and5Or3and5_RetrunInputNumber(int number, string wordFizzBuzz)
        {


            //Act
            var result = FizzBuzz.GetOutput(number);
            //Assert
            Assert.That(result, Is.EqualTo(wordFizzBuzz));
        }

    }
}
