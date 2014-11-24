﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Spam.Pages
{
    public abstract class AbstractPage
    {
        public abstract void OpenPage();

        public bool IsElementPresent(By locator)
        {
            return WebDriverInstance.GetInstance().FindElements(locator).Count > 0;
        }
    }
}
