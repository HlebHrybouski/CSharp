using MouseKeyboardActivityMonitor;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using Shell32;
//using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace SpaghettiTests.Pages
{
    
    class SendMessage
    {
        private MouseHookListener m_mouseListener;

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='T-I J-J5-Ji T-I-KE L3']")]
        private IWebElement createMail;

        [FindsBy(How = How.XPath, Using = "//textarea[@class='vO']")]
        private IWebElement to;

        [FindsBy(How = How.XPath, Using = "//input[@class='aoT']")]
        private IWebElement theme;

        [FindsBy(How = How.XPath, Using = "//div[@class='Am Al editable LW-avf']")]
        private IWebElement message;

        [FindsBy(How = How.XPath, Using = "//div[@class='T-I J-J5-Ji aoO T-I-atl L3']")]
        private IWebElement sendMessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='a1 aaA aMZ']")]
        private IWebElement buttonAttach;

        [FindsBy(How = How.XPath, Using = "//div[@class='vh']//span[@id='link_vsm']")]
        private IWebElement mailSent;

        [FindsBy(How = How.XPath, Using = "//input[@name='attach']")]
        private IWebElement fileAttached;
        
        /*
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        public static void PressKey(Keys key, bool up)
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;
            if (up)
            {
                keybd_event((byte)key, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            }
            else
            {
                keybd_event((byte)key, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            }
        }

        void TestProc()
        {
            PressKey(Keys.ControlKey, false);
            PressKey(Keys.P, false);
            PressKey(Keys.P, true);
            PressKey(Keys.ControlKey, true);
        }
        */
        
        public SendMessage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        private void GenerateMail(string toSmth, string someTheme, string someMessage)
        {
            createMail.Click();
            to.SendKeys(toSmth);
            theme.SendKeys(someTheme);
            message.SendKeys(someMessage);
        }

        private void AttachFile(string pathToAttach)
        {
            buttonAttach.Click();
            SendKeys.SendWait(@pathToAttach);
            Thread.Sleep(TimeSpan.FromSeconds(1));
            SendKeys.SendWait(@"{Enter}");
            Utils.WaitingElement wl = new Utils.WaitingElement(driver);
            wl.WaitElement(fileAttached);
            
        }

        public void CreateMail(string toSmth, string someTheme, string someMessage)
        {
            GenerateMail(toSmth, someTheme, someMessage);
            sendMessage.Click();
        }

        public void CreateMail(string toSmth, string someTheme, string someMessage, string pathToAttach)
        {
            GenerateMail(toSmth, someTheme, someMessage);
            AttachFile(pathToAttach); 
            sendMessage.Click();
            Utils.WaitingElement wl = new Utils.WaitingElement(driver);
            wl.WaitElement(mailSent);
        }
        

        
    }
     
}
