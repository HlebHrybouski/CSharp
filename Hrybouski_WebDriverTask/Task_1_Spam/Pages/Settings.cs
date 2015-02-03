using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaghettiTests.Pages
{
    class Settings
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='T-I J-J5-Ji ash T-I-ax7 L3']")]
        private IWebElement contextMenuSettings;

        [FindsBy(How = How.XPath, Using = "//div[@class='J-N aMS']")]
        private IWebElement settings;

        private IWebDriver driver;

        public Settings(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void GoToSettings()
        {
            contextMenuSettings.Click();
            settings.Click();   
        }

        


    }
}
