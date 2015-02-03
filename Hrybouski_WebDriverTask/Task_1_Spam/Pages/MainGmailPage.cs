using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaghettiTests.Pages
{
    public class MainGmailPage
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='gb_D gb_ea gb_i gb_aa']")]
        private IWebElement linkLogOutUser;

        [FindsBy(How = How.Id, Using = "gb_71")]
        private IWebElement buttonLogOut;

        [FindsBy(How = How.XPath, Using = "//tr[@class='zA zE']")]
        private IWebElement newLetter;

        [FindsBy(How = How.XPath, Using = "//img[@class='hA T-I-J3']")]
        private IWebElement letterMenu;

        [FindsBy(How = How.XPath, Using = "//div[@class='cj'][@act='9']")]
        private IWebElement reportSpamButton;

        [FindsBy(How = How.XPath, Using = "//span[@email='forwarding-noreply@google.com']")]
        private IWebElement letterFromGoogle;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'https://isolated.mail.google.')]")]
        private IWebElement confirmLink;

        [FindsBy(How = How.XPath, Using = "//div[@class='a3s']//div[@dir='ltr']")]
        private IWebElement textOfLetter;

        [FindsBy(How = How.XPath, Using = "//input[@class='gbqfif']")]
        private IWebElement searchField;

        [FindsBy(How = How.XPath, Using = "//button[@id='gbqfb']")]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//span[@class='aV3 a6U']")]
        private IWebElement attachName;
        

        private IWebDriver driver;

        public MainGmailPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void LogOut()
        {
            linkLogOutUser.Click();
            buttonLogOut.Click();
        }

        public void AddToSpam()
        {
            Utils.WaitingElement wl = new Utils.WaitingElement(driver);
            wl.WaitElement(newLetter);
            newLetter.Click();
            letterMenu.Click();
            reportSpamButton.Click();
        }

        public void ConfirmForward()
        {
            Utils.WaitingElement wl = new Utils.WaitingElement(driver);
            wl.WaitElement(newLetter);
            newLetter.Click();
            confirmLink.Click();
        }

        public void OpenLastUnreadLetter()
        {
            Utils.WaitingElement wl = new Utils.WaitingElement(driver);
            wl.WaitElement(newLetter);
            newLetter.Click();
        }
        
        public string GetLetterText()
        {
            Utils.WaitingElement wl = new Utils.WaitingElement(driver);
            wl.WaitElement(textOfLetter);
            return textOfLetter.Text;
        }

        public void GoToImportant()
        {
            searchField.SendKeys("in:important");
            searchButton.Click();
        }

        public void GoToTrash()
        {
            searchField.SendKeys("in:trash");
            searchButton.Click();
        }

        public string GetAttachName()
        {
            Utils.WaitingElement wl = new Utils.WaitingElement(driver);
            wl.WaitElement(attachName);
            return attachName.Text;
        }
        

    }
}
