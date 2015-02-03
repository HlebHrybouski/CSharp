using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaghettiTests.Steps
{
    public class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = WebDriverInstance.GetInstance();
        }

        public void QuitBrowser()
        {
            WebDriverInstance.QuitBrowser();
        }

        public void CloseBrowser()
        {
            WebDriverInstance.CloseBrowser();
        }

        public void LogOut()
        {
            Utils.AlertsChecker ac = new Utils.AlertsChecker(driver);
            Pages.MainGmailPage logOut = new Pages.MainGmailPage(driver);           
            logOut.LogOut();
            ac.CheckAlerts();           
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
        }

        public void CleanCookie()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().Refresh();
        }

        public void LoginGmail(string username, string password)
        {
            Pages.LoginPage loginPage = new Pages.LoginPage(driver);
            loginPage.OpenPage();
            loginPage.Login(username, password);
        }

        public void SendMessage(string to, string theme, string message)
        {
            Pages.SendMessage sendMessage = new Pages.SendMessage(driver);
            sendMessage.CreateMail(to, theme, message);
        }

        public void SendMessage(string to, string theme, string message, string pathToAttach)
        {
            Pages.SendMessage sendMessage = new Pages.SendMessage(driver);
            sendMessage.CreateMail(to, theme, message, pathToAttach);
        }

        public void MarkLetterAsSpam()
        {
            Pages.MainGmailPage addToSpam = new Pages.MainGmailPage(driver);
            addToSpam.AddToSpam();
        }

        public void GoToSpamBox()
        {
            Pages.SpamPage sp = new Pages.SpamPage(driver);
            sp.GoToSpam();
        }

        public void GoToSettings()
        {
            Pages.Settings sett = new Pages.Settings(driver);
            sett.GoToSettings();
        }

        public void GoToPOPIMAP()
        {
            Pages.SettingsPOPIMAP popimap = new Pages.SettingsPOPIMAP(driver);
            popimap.GoToPopImap();
        }

        public void SetForward(string smth)
        {
            Pages.SettingsPOPIMAP sett = new Pages.SettingsPOPIMAP(driver);
            sett.SetForaward(smth);
        }

        public void ConfirmForward()
        {
            Pages.MainGmailPage confir = new Pages.MainGmailPage(driver);
            confir.ConfirmForward();
        }

        public void ChooseRadioButtonForwardTo()
        {
            Pages.SettingsPOPIMAP choose = new Pages.SettingsPOPIMAP(driver);
            choose.ChooseRadioButtonForwardTo();
        }

        public void CreateForwardFilter(string from)
        {
            Pages.Filter filter = new Pages.Filter(driver);
            filter.CreateForwardFilter(from);
        }

        public void OpenLastUnreadLetter()
        {
            Pages.MainGmailPage opLett = new Pages.MainGmailPage(driver);
            opLett.OpenLastUnreadLetter();
        }

        public string GetLetterText()
        {
            Pages.MainGmailPage txt = new Pages.MainGmailPage(driver);
            return txt.GetLetterText();
        }

        public void GoToImportant()
        {
            Pages.MainGmailPage gti = new Pages.MainGmailPage(driver);
            gti.GoToImportant();
        }

        public void GoToTrash()
        {
            Pages.MainGmailPage gtt = new Pages.MainGmailPage(driver);
            gtt.GoToTrash();
        }

        public string GetAttachName()
        {
            Pages.MainGmailPage att = new Pages.MainGmailPage(driver);
            return att.GetAttachName();
        }
    }
}
