using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace XUnitTestProjectPageObject.PageObjects
{
    class RegistrationPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _userName = By.Id("user-name");
        private readonly By _passWord = By.Id("password");
        private readonly By _button = By.Id("login-button");

        public RegistrationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainMenuPageObject Registration(string username, string password)
        {

            _webDriver.FindElement(_userName).SendKeys(username);
            _webDriver.FindElement(_userName).Click();
            Thread.Sleep(3000);
            _webDriver.FindElement(_passWord).SendKeys(password);
            _webDriver.FindElement(_passWord).Click();
            Thread.Sleep(3000);
            _webDriver.FindElement(_button).Click();
            Thread.Sleep(1000);
            return new MainMenuPageObject(_webDriver);
        }
    }
}
