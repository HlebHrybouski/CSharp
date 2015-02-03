using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaghettiTests.Utils
{
    class AlertsChecker
    {
        private IWebDriver driver;

        public AlertsChecker(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void CheckAlerts()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                if (driver.SwitchTo().Alert() != null)
                {

                    alert.Accept();
                }
            }
            catch (Exception e) { }
        }
    }
}
