using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Tests
{
    public class GoogleTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {

            driver.Navigate().GoToUrl("https://www.google.co.in");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
