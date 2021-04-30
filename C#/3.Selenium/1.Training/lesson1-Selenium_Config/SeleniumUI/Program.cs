using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace SeleniumBasics
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
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            Thread.Sleep(1000);
            //Test
            
            

            driver.Navigate().GoToUrl(baseUrl);
             var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));            
            
            var login = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='navbar']//a[@href='/sign_in']")));
            login.Click();
            //driver.FindElement(By.XPath("//div[@id='navbar']//a[@href='/sign_in']")).Click();
            Console.WriteLine("click on login ");


            Thread.Sleep(2000);
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

            var textBox = driver.FindElement(By.Id("displayed-text"));
            Console.WriteLine($"text box is displayed ?: "+ textBox.Displayed);

            var hideButton = driver.FindElement(By.Id("hide-textbox"));
            hideButton.Click();
            Console.WriteLine("kliknieto w hide");
            Console.WriteLine("text box displayed " + textBox.Displayed);

            var showButton = driver.FindElement(By.XPath("//input[@id='show-textbox']"));
            showButton.Click();
            Console.WriteLine("Kliknięto w show button");
            Console.WriteLine("text box displayed " + textBox.Displayed);

            //Text on element 

            var textElement = driver.FindElement(By.CssSelector("#opentab"));
            Console.WriteLine($"text of opentab is: "+textElement.Text);

            //Get  element   tag, attribute 

            var field = driver.FindElement(By.Id("name"));
            Console.WriteLine($"tag name is : "+ field.TagName);
            Console.WriteLine($"value of class is : " + field.GetAttribute("class"));


            


            




        }
    }
}
