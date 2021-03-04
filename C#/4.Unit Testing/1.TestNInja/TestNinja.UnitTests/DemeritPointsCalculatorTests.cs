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
    public class DemeritPointsCalculatorTests
    {


        [Test]
        [TestCase(-1)]
        [TestCase(301)]

        public void CalculateDemeritPoints_SpeedIsNegativeOrSpeedAbove300_ReturnArgumentOutOfRangeException(int speed)
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();
            
            
            //Assert
            Assert.That(()=> calculator.CalculateDemeritPoints(speed),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(0, 0)]
        public void CalculateDemeritPoints_SpeedIsWithinSpeedLimit_Return0Points(int speed, int expected)
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();
            //Act
            var result = calculator.CalculateDemeritPoints(speed);
            //Assert
            Assert.That(result,Is.EqualTo(expected));
        }

        [Test]
        [TestCase(71, 1)]
        [TestCase(76, 2)]
        [TestCase(83, 3)]
        public void CalculateDemeritPoints_SpeedIsAboveSpeedLimit_Return1PointPer5Km(int speed, int demeritPoints)
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();
            //Act
            var result = calculator.CalculateDemeritPoints(speed);
            //Assert
            Assert.That(result, Is.EqualTo(demeritPoints));
        }

       

        


    }
}
