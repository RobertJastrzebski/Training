using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DragAndDropUnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        private ChromeDriver _driver;
        private Actions _actions;
        private WebDriverWait _wait;



        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _actions = new Actions(_driver);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
        }
        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }

        [Test]
        public void DragAndDropUnitTest1()
        {
            _driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            _driver.Manage().Window.Maximize();
            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));
            IWebElement sourceElement = _driver.FindElement(By.Id("draggable"));
            IWebElement targetElement = _driver.FindElement(By.Id("droppable"));
            _actions.DragAndDrop(sourceElement, targetElement).Perform();
            Assert.AreEqual("Dropped!",targetElement.Text);
        }

        [Test]
        public void DragAndDropUnitTest2()
        {

            _driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            _driver.Manage().Window.Maximize();
            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));
            
            IWebElement sourceElement = _driver.FindElement(By.Id("draggable"));
            IWebElement targetElement = _driver.FindElement(By.Id("droppable"));
            var drag = _actions
                .ClickAndHold(sourceElement)
                .MoveToElement(targetElement)
                .Release(targetElement)
                .Build();

            drag.Perform();
            Assert.AreEqual("Dropped!", targetElement.Text);
        }

        [Test]
        public void Resizing()
        {
            
            _driver.Navigate().GoToUrl("https://jqueryui.com/resizable/");
            _driver.Manage().Window.Maximize();

            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));
            

            var frame = _driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));

            _driver.SwitchTo().Frame(frame);

            
            
            _actions.ClickAndHold(frame).MoveByOffset(300, 200).Perform();
            Assert.IsTrue(_driver.FindElement(By.XPath("//*[@id='resizable' and @style] ")).Displayed);

        }
        
        


    }
}
