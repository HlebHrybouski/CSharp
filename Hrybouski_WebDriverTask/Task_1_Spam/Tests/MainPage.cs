using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using Task_1_Spam.Steps;

namespace Task_1_Spam.Tests
{
    /*
    class MainPage : BaseTest
    {
        [Test]
        public void oneCanOpenGoogle()
        {
            
            driver.Navigate().GoToUrl("https://mail.google.com/");
            IWebElement queryBox = driver.FindElement(By.Id("Email"));
            queryBox.SendKeys("hleb.webdriver.1");
            queryBox = driver.FindElement(By.Id("Passwd"));
            queryBox.SendKeys("4815162342!");
            driver.FindElement(By.Id("signIn")).Click();
            
            WebDriverWait wdw = new WebDriverWait(driver, TimeSpan.FromSeconds(7));
            wdw.Until(ExpectedConditions.ElementExists(By.LinkText("НАПИСАТЬ")));
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.FindElement(By.XPath("id(':4r')/x:div/x:div")).Click();
            queryBox = driver.FindElement(By.Id(":9n"));
            queryBox.SendKeys("hleb.webdriver.2@gmail.com");
             
        }

        
    }
    */

   
    class MainPage2
    {
        private Steps.Steps steps = new Steps.Steps();

        [Test]
        public void Login()
        {
            steps.InitBrowser();
            steps.LoginGmail("hleb.webdriver.1", "4815162342!");
            steps.CloseBrowser();
        }

        /*
        [TearDown]
        public void Message()
        {
            
            steps.SendMessage("hleb.webdriver.1", "lal", "asdkj asdk k");
        }
         * */
    }
}
