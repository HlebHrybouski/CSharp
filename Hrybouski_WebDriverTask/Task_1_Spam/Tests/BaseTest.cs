using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Task_1_Spam
{
   
    public class BaseTest
    {
       public IWebDriver driver;

       [SetUp]
       public void startBrowser()
       {
               driver = new FirefoxDriver();
       }

       [TearDown]
       public void closeBrowser()
       {
               driver.Quit();
       }

    }


}
