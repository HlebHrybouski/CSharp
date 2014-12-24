using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Spam.Steps
{
    public class Steps
    {
        IWebDriver driver;
        //private static readonly ILog logger = LogManager.GetLogger(typeof(Steps));

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

       

        /*
        public bool IsLoggedIn(string username)
        {
            Pages.LoginPage loginPage = new Pages.LoginPage(driver);
            return (loginPage.GetLoggedInUserName().Trim().ToLower().Equals(username));
        }
        */
        /*
        public bool CreateNewRepository(string repositoryName, string repositoryDescription)
        {
            logger.Info("Creating new repo with name: " + repositoryName);
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.ClickOnCreateNewRepositoryButton();
            Pages.CreateNewRepositoryPage createNewRepositoryPage = new Pages.CreateNewRepositoryPage(driver);
            string expectedRepoName = createNewRepositoryPage.CreateNewRepository(repositoryName, repositoryDescription);

            return expectedRepoName.Equals(createNewRepositoryPage.GetCurrentRepositoryName());
        }
         * */
        /*
        public bool CurrentRepositoryIsEmpty()
        {
            Pages.CreateNewRepositoryPage createNewRepositoryPage = new Pages.CreateNewRepositoryPage(driver);
            return createNewRepositoryPage.IsCurrentRepositoryEmpty();
        }
         * */
    }
}
