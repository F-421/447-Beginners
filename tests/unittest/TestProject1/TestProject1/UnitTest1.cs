using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _driver;

        /*initialize our web driver*/
        [TestInitialize]
        public void EdgeDriverInitialize()
        {
            _driver = new FirefoxDriver();
        }

        /*Simple Unit Test: Get to website and check title */
        [TestMethod]
        public void TestPageTitle()
        {
            _driver.Url = "https://f-421.github.io/";
            Assert.AreEqual("COVID Lunch Profile Test", _driver.Title);
        }

        /*close our web driver*/
        [TestCleanup]
        public void EdgeDriverCleanup()
        {
            _driver.Quit();
        }
    }
}
