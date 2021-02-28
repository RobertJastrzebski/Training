using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace lesson1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = GetChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");

        }

        private IWebDriver GetChromeDriver()
        {
            var lokalizacjaDrivera = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(lokalizacjaDrivera);
        }
    }
}
