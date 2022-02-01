using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
namespace AQA_12_selenium
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
            driver.Navigate().GoToUrl("https://calc.by/building-calculators/laminate.html");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            IWebElement lengthroomElement = driver.FindElement(By.Id("ln_room_id"));
            lengthroomElement.Click();
            lengthroomElement.Clear();
            lengthroomElement.SendKeys("500");
            IWebElement widthroomElement = driver.FindElement(By.Id("wd_room_id"));
            widthroomElement.Click();
            widthroomElement.Clear();
            widthroomElement.SendKeys("400");
            IWebElement lenghlaminateElement = driver.FindElement(By.Id("ln_lam_id"));
            lenghlaminateElement.Click();
            lenghlaminateElement.Clear();
            lenghlaminateElement.SendKeys("2000");
            IWebElement widthlaminateElement = driver.FindElement(By.Id("wd_lam_id"));
            widthlaminateElement.Click();
            widthlaminateElement.Clear();
            widthlaminateElement.SendKeys("200");
            IWebElement stylingElement = driver.FindElement(By.Id("laying_method_laminate"));
            stylingElement.Click();
            SelectElement select = new SelectElement(stylingElement);
            select.SelectByText("с использованием отрезанного элемента");
            IWebElement directionElement = driver.FindElement(By.Id("direction-laminate-id1"));
            directionElement.Click();
            IWebElement bottonElement = driver.FindElement(By.LinkText("Рассчитать"));
            bottonElement.Click();
            Thread.Sleep(3000);
            IWebElement resultElement1 = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[3]/article/section/div[2]/div[3]/div[2]/div[1]/span"));
            Assert.AreEqual("53", resultElement1.Text);
            Thread.Sleep(1000);
            IWebElement resultElement2 = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[3]/article/section/div[2]/div[3]/div[2]/div[2]/span"));
            Assert.AreEqual("7", resultElement2.Text);
            Thread.Sleep(3000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}