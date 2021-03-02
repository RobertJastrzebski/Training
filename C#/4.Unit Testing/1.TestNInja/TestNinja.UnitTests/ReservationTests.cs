using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var Reservation = new Reservation();

            var user = new User();
            user.IsAdmin = true;
            //Act
            var result = Reservation.CanBeCancelledBy(user);

            //Assert
            Assert.That(result,Is.True);
        }
        [Test]
        public void CanBeCancelledBy_TheSameUserCancellingReservation_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var Reservation = new Reservation{MadeBy = user};
            
            
            //Act
            var result = Reservation.CanBeCancelledBy(user);
            //Assert
            Assert.That(result, Is.True);

        }

        [Test]
        public void CanBeCancelledBy_OtherUser_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation{MadeBy = new User()};
            
            //Act
            var result = reservation.CanBeCancelledBy(new User());
            //Assert
            Assert.That(result,Is.False);

        }
    }
}
