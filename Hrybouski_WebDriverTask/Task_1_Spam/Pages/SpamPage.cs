using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaghettiTests.Pages
{
    class SpamPage
    {
        private IWebDriver driver;

        public SpamPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//input[@class='gbqfif']")]
        private IWebElement searchField;

        [FindsBy(How = How.XPath, Using = "//button[@class='gbqfb']/span")]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//div[@role='main']//tr[@class='zA zE']")]
        private IWebElement spamLetter;

        [FindsBy(How = How.XPath, Using = "//td[@class='anO anN']/span")]
        private IWebElement senderMail;

        [FindsBy(How = How.XPath, Using = "//div[@class='ar6 T-I-J3 J-J5-Ji']")]
        private IWebElement backToSpamButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='T-Jo-auh']")]
        private IWebElement checkboxLetter;

        [FindsBy(How = How.XPath, Using = "//div[@act='18']")]
        private IWebElement notSpamButton;

        public void GoToSpam()
        {
            searchField.SendKeys("in:spam");
            searchButton.Click();
        }

        public string GetSpamLetter()
        {
            SpaghettiTests.Utils.WaitingElement wl = new SpaghettiTests.Utils.WaitingElement(driver);
            wl.WaitElement(spamLetter);
            spamLetter.Click();
            return senderMail.Text;
        }

        public void RemoveFromSpam()
        {
            WebDriverWait ww = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            backToSpamButton.Click();
            checkboxLetter.Click();
            ww.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@act='18']")));
            notSpamButton.Click();
        }
    }
}
