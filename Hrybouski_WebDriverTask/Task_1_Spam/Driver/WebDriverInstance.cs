using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Spam
{
    
        class WebDriverInstance
        {
            private static IWebDriver driver;

            private WebDriverInstance() { }

            public static IWebDriver GetInstance()
            {
                    driver = new FirefoxDriver();
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
                    //driver.Manage().Window.Maximize();
                
                return driver;
            }

            public static void CloseBrowser()
            {
                driver.Close();
                driver = null;
            }

            public static void QuitBrowser()
            {
                driver.Quit();
                driver = null;
            }

            /*
            private static IWebDriver CreateDriver()
            {
                IWebDriver driver;
                driver = new FirefoxDriver();
                return driver;
            }
             * */
        }
    
}
