using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SpaghettiTests.Steps;
using System.Threading;

namespace SpaghettiTests.Tests
{
      
    class Spaghetti
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void Spam()
        {
            steps.LoginGmail("hleb.webdriver.1", "4815162342!");
            steps.SendMessage("hleb.webdriver.2@gmail.com", "lal", "asdkjasdkk");
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail("hleb.webdriver.2", "4815162342!");
            steps.MarkLetterAsSpam();
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail("hleb.webdriver.1", "4815162342!");
            steps.SendMessage("hleb.webdriver.2@gmail.com", "lsdfdsal", "asdkjsdfsdafsdfasdkk");
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail("hleb.webdriver.2", "4815162342!");
            steps.GoToSpamBox();
            steps.LogOut();
            steps.CleanCookie();
        }

        [Test]
        public void Forward()
        {
            steps.LoginGmail("hleb.webdriver.2", "4815162342!");
            steps.GoToSettings();
            steps.GoToPOPIMAP();
            steps.SetForward("hleb.webdriver.3@gmail.com");
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail("hleb.webdriver.3", "4815162342!");
            steps.ConfirmForward();
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail("hleb.webdriver.2", "4815162342!");
            steps.GoToSettings();
            steps.GoToPOPIMAP();
            steps.ChooseRadioButtonForwardTo();
            steps.CreateForwardFilter("hleb.webdriver.1@gmail.com");
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail("hleb.webdriver.1", "4815162342!");
            steps.SendMessage("hleb.webdriver.2@gmail.com", "lasqwdfgl", "asdksdfgjasdkk", @"C:\RHDSetup.log");
            steps.SendMessage("hleb.webdriver.2@gmail.com", "lajkgl", "asdkjgsdfgasdkk");
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail("hleb.webdriver.2", "4815162342!");
            steps.GoToImportant();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            steps.OpenLastUnreadLetter();
            StringAssert.Contains("asdkjgsdfgasdkk", steps.GetLetterText());
            steps.GoToTrash();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            steps.OpenLastUnreadLetter();
            StringAssert.Contains("RHDSetup.log", steps.GetAttachName());
            StringAssert.Contains("asdksdfgjasdkk", steps.GetLetterText());
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail("hleb.webdriver.3", "4815162342!");
            steps.OpenLastUnreadLetter();
        }

        /*
        [Test]
        public void ATempTest()
        {
            
             
        }
        */

    }
}
