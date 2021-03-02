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
    class HTMLFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("Robert");

            //bardzo precyzyjny test
            Assert.That(result,Is.EqualTo("<strong>Robert</strong>").IgnoreCase);
            //bardziej ogólny
            Assert.That(result,Does.StartWith("<strong>"));
            Assert.That(result,Does.EndWith("</strong>"));
            Assert.That(result,Does.Contain("Robert"));

        }
    }
}
