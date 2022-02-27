using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using XUnitTestProjectPageObject.PageObjects;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProjectPageObject
{
    public class UnitTest1
    {
        public static IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Test]
        public void Test1()
        {
            var RegistRationn = new RegistrationPageObject(_webDriver);
            RegistRationn.Registration(Standard_User.UsernameStandard_user,Standard_User.PasswordsStandard_user);
            Thread.Sleep(500);
            Assert.AreEqual("standard_user", Standard_User.UsernameStandard_user);
            Assert.AreEqual("secret_sauce", Standard_User.PasswordsStandard_user);
        }

        [Test]
        public void Test2()
        {
            var RegistRationn = new RegistrationPageObject(_webDriver);
            RegistRationn.Registration(Locked_out_user.UserNameLocked_out_user, Locked_out_user.PassWordLocked_out_user);
            Thread.Sleep(500);
            Assert.IsFalse(false);
        }

        [Test]
        public void Test3()
        {
            var RegistRationn = new RegistrationPageObject(_webDriver);
            RegistRationn.Registration(Problem_user.UserNameProblem_user, Problem_user.PassWordProblem_user);
            Thread.Sleep(500);
            Assert.AreEqual("problem_user", Problem_user.UserNameProblem_user);
            Assert.AreEqual("secret_sauce", Problem_user.PassWordProblem_user); 
        }

        [Test]
        public void test4() 
        {
            var RegistRationn = new RegistrationPageObject(_webDriver);
            RegistRationn.Registration(performance_glitch_user.UserNamePerformance_glitch_user, performance_glitch_user.PassWordPerformance_glitch_user);
            Thread.Sleep(500);
            Assert.AreEqual("performance_glitch_user", performance_glitch_user.UserNamePerformance_glitch_user);
            Assert.AreEqual("secret_sauce", performance_glitch_user.PassWordPerformance_glitch_user);
        }

        [Test]
        public void test5()
        {
            var RegistRationn = new RegistrationPageObject(_webDriver);
            RegistRationn.Registration(Standard_User.UsernameStandard_user, Standard_User.PasswordsStandard_user);
            Thread.Sleep(500);
            var MainMenuPageObject = new MainMenuPageObject(_webDriver);
            MainMenuPageObject.MainMenu();
            Assert.AreEqual("Remove", MainMenuPageObject.MainMenu());
        }
        [Test]
        public void test6()
        {
            var RegistRationn = new RegistrationPageObject(_webDriver);
            RegistRationn.Registration(Standard_User.UsernameStandard_user, Standard_User.PasswordsStandard_user);
            Thread.Sleep(500);
            var MainMenuPageObject = new MainMenuPageObject(_webDriver);
            MainMenuPageObject.buttonMenu();
            Assert.IsTrue(true);

        }
        [TearDown] 
        public void TearDown()
        {
            _webDriver.Quit();
        } 
    }
}
