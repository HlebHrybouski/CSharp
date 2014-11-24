using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Spam.Pages
{
    public class LoginPage : AbstractPage
    {
        private const string BASE_URL = "https://mail.google.com/";

        

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement inputLogin;

        [FindsBy(How = How.Id, Using = "Passwd")]
        private IWebElement inputPassword;

        [FindsBy(How = How.Id, Using = "signIn")]
        private IWebElement buttonSubmit;

        //[FindsBy(How = How.ClassName, Using = "T-I J-J5-Ji T-I-KE L3")]
        //private IWebElement createMail;

        [FindsBy(How = How.Id, Using = ":9n")]
        private IWebElement to;

        [FindsBy(How = How.Id, Using = ":98")]
        private IWebElement theme;

        [FindsBy(How = How.Id, Using = ":aa")]
        private IWebElement message;

        [FindsBy(How = How.Id, Using = ":8y")]
        private IWebElement sendMessage;

        private IWebDriver driver;
        
         
        
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        
        public override void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Console.WriteLine("Login Page opened");
        }

        public void Login(string username, string password)
        {
            inputLogin.SendKeys(username);
            inputPassword.SendKeys(password);
            buttonSubmit.Click();
        }
        
        public void CreateMail(string toSmth, string someTheme, string someMessage)
        {
            //createMail.Click();
            to.SendKeys(toSmth);
            theme.SendKeys(someTheme);
            message.SendKeys(someMessage);
        }
    }
}
