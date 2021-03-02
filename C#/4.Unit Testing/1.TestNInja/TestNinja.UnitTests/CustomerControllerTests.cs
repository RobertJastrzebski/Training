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
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFoundObject()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            Assert.That(result,Is.TypeOf<NotFound>());
            //Assert.That(result, Is.InstanceOf<ActionResult>());

        }
        [Test]
        public void GetCustomer_DifferentThen0_ReturnOkObject()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);
            Assert.That(result, Is.TypeOf<Ok>());

        }
    }
}
