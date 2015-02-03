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
    class Filter
    {
        [FindsBy(How = How.XPath, Using = "//span[@act='filter']")]
        private IWebElement filter;

        [FindsBy(How = How.XPath, Using = "//input[@class='ZH nr aQa']")]
        private IWebElement filterFrom;

        [FindsBy(How = How.XPath, Using = "//span[@class='w-Pv ZG']/input")]
        private IWebElement filterHasAttachment;

        [FindsBy(How = How.XPath, Using = "//div[@class='ZC']")]
        private IWebElement filterButtonSearch;

        [FindsBy(How = How.XPath, Using = "//button[@class='J-at1-auR J-at1-atl']")]
        private IWebElement filterOk;

        [FindsBy(How = How.XPath, Using = "//div[@class='aoq']")]
        private IWebElement trayAtSearchLine;

        [FindsBy(How = How.XPath, Using = "//div[@class='acM']")]
        private IWebElement createFilterForCurrentRequest;

        [FindsBy(How = How.XPath, Using = "//div[@class='nH lZ'][6]/input")]
        private IWebElement filterDeleteIt;

        [FindsBy(How = How.XPath, Using = "//div[@class='nH lZ'][8]/input")]
        private IWebElement filterAlwaysMarkAsImportant;

        [FindsBy(How = How.XPath, Using = "//div[@class='T-I J-J5-Ji Zx acL T-I-atl L3']")]
        private IWebElement createFilterButton;

        private IWebDriver driver;

        public Filter(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void CreateForwardFilter(string from)
        {
            filter.Click();
            filterFrom.SendKeys(from);
            filterHasAttachment.Click();
            filterButtonSearch.Click();
            filterOk.Click();
            trayAtSearchLine.Click();
            createFilterForCurrentRequest.Click();
            filterDeleteIt.Click();
            filterAlwaysMarkAsImportant.Click();
            createFilterButton.Click();
        }
    }
}
