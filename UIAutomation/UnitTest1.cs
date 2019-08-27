using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace UIAutomation
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _chrome;

        [TestInitialize]
        public void Init()
        {
            var drivers = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _chrome = new ChromeDriver(drivers);
        }


        [TestMethod]
        public void TestMethod1()
        {
            _chrome.Navigate().GoToUrl("https://localhost:12000");

            var el1 = _chrome.FindElement(By.Id("userName"));

            Assert.IsNotNull(el1);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _chrome.Dispose();
        }
    }
}
