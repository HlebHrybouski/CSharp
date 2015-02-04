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

        private const string USER1 = "hleb.webdriver.1@gmail.com";
        private const string USER2 = "hleb.webdriver.2@gmail.com";
        private const string USER3 = "hleb.webdriver.3@gmail.com";
        private const string PASS = "4815162342!";

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
            steps.LoginGmail(USER1, PASS);
            steps.SendMessage(USER2, "lal", "asdkjasdkk");
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail(USER2, PASS);
            steps.MarkLetterAsSpam();
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail(USER2, PASS);
            steps.SendMessage(USER2, "lsdfdsal", "asdkjsdfsdafsdfasdkk");
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail(USER2, PASS);
            steps.GoToSpamBox();
            steps.LogOut();
            steps.CleanCookie();
        }

        [Test]
        public void Forward()
        {
            steps.LoginGmail(USER2, PASS);
            steps.GoToSettings();
            steps.GoToPOPIMAP();
            steps.SetForward(USER3);
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail(USER3, PASS);
            steps.ConfirmForward();
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail(USER2, PASS);
            steps.GoToSettings();
            steps.GoToPOPIMAP();
            steps.ChooseRadioButtonForwardTo();
            steps.CreateForwardFilter(USER2);
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail(USER1, PASS);
            steps.SendMessage(USER2, "lasqwdfgl", "asdksdfgjasdkk", @"C:\RHDSetup.log");
            steps.SendMessage(USER2, "lajkgl", "asdkjgsdfgasdkk");
            steps.LogOut();
            steps.CleanCookie();
            steps.LoginGmail(USER2, PASS);
            steps.GoToImportant();
            steps.OpenLastUnreadLetter();
            StringAssert.Contains("asdkjgsdfgasdkk", steps.GetLetterText());
            steps.GoToTrash();
            steps.OpenLastUnreadLetter();
            StringAssert.Contains("RHDSetup.log", steps.GetAttachName());
            StringAssert.Contains("asdksdfgjasdkk", steps.GetLetterText());
            steps.LogOut();
            steps.CleanCookie();
        }

        /*
        [Test]
        public void ATempTest()
        {
            
             
        }
        */

    }
}
