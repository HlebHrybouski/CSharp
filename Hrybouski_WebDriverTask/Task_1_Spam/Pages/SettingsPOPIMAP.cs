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
    class SettingsPOPIMAP
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='f1'][6]")]
        private IWebElement buttonSettingsForwardPopImap;

        [FindsBy(How = How.XPath, Using = "//td[@class='r9']//input[@type='button']")]
        private IWebElement buttonAddForward;

        [FindsBy(How = How.XPath, Using = "//div[@class='PN']//input[@type='text']")]
        private IWebElement setForward;

        [FindsBy(How = How.XPath, Using = "//button[@class='J-at1-auR']")]
        private IWebElement nextStep;

        [FindsBy(How = How.CssSelector, Using = "iframe.ds")]
        private IWebElement secondWindow;

        [FindsBy(How = How.XPath, Using = "//tr//input[@type='submit']")]
        private IWebElement acceptForward;

        [FindsBy(How = How.XPath, Using = "//button[@class='J-at1-auR']")]
        private IWebElement okay;

        [FindsBy(How = How.XPath, Using = "//input[@name='sx_em'][@value='1']")]
        private IWebElement radioButton;

        

        private IWebDriver driver;

        public SettingsPOPIMAP(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void GoToPopImap()
        { 
            buttonSettingsForwardPopImap.Click();
        }

        public void SetForaward(string smth)
        {
            
            buttonAddForward.Click();
            setForward.SendKeys(smth);
            nextStep.Click();
            IWrapsElement wrap = secondWindow as IWrapsElement;
            driver.SwitchTo().Frame(wrap.WrappedElement);
            acceptForward.Click();
            driver.SwitchTo().DefaultContent();
            okay.Click();
        }

        public void ChooseRadioButtonForwardTo()
        {
            radioButton.Click();
        }

        


    }
}
