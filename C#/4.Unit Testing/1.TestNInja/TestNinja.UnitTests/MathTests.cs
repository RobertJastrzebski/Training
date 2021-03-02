using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;


namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {

        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            //Arrange
            //Act
            var result = _math.Add(2, 1);
            //Assert
            Assert.That(result,Is.EqualTo(3));

        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        
        public void Max_WhenCalled_ReturnMaxOfTwoArguments(int a , int b , int expectedResult)
        {
            //Arrange
            //Act
            var result = _math.Max(a, b);
            //Assert
            Assert.That(result,Is.EqualTo(expectedResult));

        }

        [Test]
        [TestCase(3, new[]{1,3})]
        
        public void GetOddNumbers_WhenCalled_ReturnOddNumbers(int limit,int [] rezultat)
        {
            //Arrange
            
            //Act
            var result = _math.GetOddNumbers(3);
            //Assert
            
            Assert.That(result.Count(),Is.EqualTo(2));
            Assert.That(result,Is.Not.Empty);
            Assert.That(result, Is.EquivalentTo(rezultat));

        }

    }
}
