using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SeleniumUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            string baseUrl;
            
            //before
            driver = new ChromeDriver();
            baseUrl = "https://letskodeit.teachable.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();


            //Test
            driver.Navigate().GoToUrl(baseUrl);
            driver.FindElement(By.XPath("//div[@id='navbar']//a[@href='/sign_in']")).Click();
            Console.WriteLine("click on login ");
            
            IWebElement mail = driver.FindElement(By.CssSelector("#user_email"));
            mail.Clear();
            Console.WriteLine("Clear the user name field");
            
            mail.SendKeys("test@email.com");
            Console.WriteLine("send keys to username field");
            
            var password = driver.FindElement(By.XPath("//input[@id='user_password']"));
            password.Clear();
            Console.WriteLine("Clear the password field");
            password.SendKeys("moje hasło");
            Console.WriteLine("Sending keys to password field");

            var LogIn = driver.FindElement(By.CssSelector("input[class$='login-button']"));
            LogIn.Click();
            Console.WriteLine("click on login button ");
            driver.Navigate().Back();
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);
            driver.Navigate().GoToUrl("https://letskodeit.teachable.com/p/practice");
            
            //Checkboxy

            var checkboxBmw = driver.FindElement(By.Id("bmwradio"));
            checkboxBmw.Click();
            Console.WriteLine(checkboxBmw.Selected);

            //Dropdown

            var cars = driver.FindElement(By.Id("carselect"));
            SelectElement dropDown = new SelectElement(cars);
            dropDown.SelectByIndex(0);
            dropDown.SelectByValue("honda");
            

            //Multiple Select

            var multipleSelect = driver.FindElement(By.CssSelector("select[name^='multiple']"));
            SelectElement multipleElement = new SelectElement(multipleSelect);

            

            multipleElement.SelectByIndex(0);
            multipleElement.SelectByValue("orange");
            multipleElement.SelectByText("Peach");
            multipleElement.DeselectAll();

            //Hidden fields





        }
    }
}
