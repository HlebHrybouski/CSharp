using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Spam.Pages
{
    public class MainGmailPage
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='gb_C gb_da gb_h gb_9']")]
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
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        }

        public void AddToSpam()
        {
            Utils.WaitingElement wl = new Utils.WaitingElement(driver);
            wl.WaitElement(newLetter);
            newLetter.Click();
            letterMenu.Click();
            reportSpamButton.Click();
        }

        /*

        public void ConfirmGoogleMail()
        {
            letterFromGoogle.Click();
            confirmLink.Click();
        }
         * */

    }
}
