using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
namespace AQA_selenium_12_2_
{

    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.calc.ru/kalkulyator-kalorii.html");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            IWebElement ageElement = driver.FindElement(By.Id("age"));
            ageElement.Click();
            ageElement.SendKeys("35");
            IWebElement weightElement = driver.FindElement(By.Id("weight"));
            weightElement.Click();
            weightElement.SendKeys("85");
            IWebElement growthElement = driver.FindElement(By.Id("sm"));
            growthElement.Click();
            growthElement.SendKeys("185");
            IWebElement activityElement = driver.FindElement(By.Id("activity"));
            activityElement.Click();
            SelectElement select = new SelectElement(activityElement);
            select.SelectByText("5 раз в неделю");
            IWebElement bottonElement = driver.FindElement(By.Id("submit"));
            bottonElement.Click();
            Thread.Sleep(3000);
            IWebElement resultElement1 = driver.FindElement(By.XPath("//td[contains(text(),'3028 ккал/день')]"));
            Assert.AreEqual("3028 ккал/день", resultElement1.Text);
            Thread.Sleep(3000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}