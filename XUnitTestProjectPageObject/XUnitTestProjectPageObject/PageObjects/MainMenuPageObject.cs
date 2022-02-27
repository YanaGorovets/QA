using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace XUnitTestProjectPageObject.PageObjects
{
    class MainMenuPageObject
    {
        private IWebDriver _webdriver;
        private readonly By _button = By.XPath("//*[contains(text(),'')] ");
        private readonly By _button1 = By.Id("react-burger-menu-btn");
        private readonly By _button2 = By.Id("inventory_sidebar_link");
        public MainMenuPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }
        public string MainMenu()
        {
            _webdriver.FindElement(_button).Click();
            Thread.Sleep(600);
            return _webdriver.FindElement(_button).Text;
        }
        public void buttonMenu()
        {
            _webdriver.FindElement(_button1).Click();
            Thread.Sleep(600);
            _webdriver.FindElement(_button2).Click();
            Thread.Sleep(600);

        }
    }
}
