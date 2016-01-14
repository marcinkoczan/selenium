using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using selenium.Metody;
using selenium.Parametry;
using OpenQA.Selenium;


namespace selenium
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _driver;
        public static IWebElement _input;
        private IWebElement _btn;
        public IWebElement koszyk;

        [TestInitialize()]
        public void BeforeTests()
        {
            _driver = SelMetody.ConfigureDriver(_driver, "ie", SelParametry.IeDriverPath);
        }

        [TestMethod]
        public void IdzDoAllegro()
        {
            SelMetody.GoToWebsite(_driver, SelParametry.AllegroURL);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void wprowadzText()
        {
            IdzDoAllegro();
            _input = _driver.FindElement(By.XPath(SelParametry.input));
            _input.Clear();
            _input.SendKeys("Xbox One");
            Thread.Sleep(2000);
        }

        //[TestMethod]
        //public void szukaj()
        //{
        //    IdzDoAllegro();
        //    wprowadzText();
        //    _btn = _driver.FindElement(By.XPath(SelParametry.btn));
        //    _btn.Click();
        //    Thread.Sleep(2000);
        //}

        //[TestMethod]
        //public void klawiatura()
        //{
        //    IdzDoAllegro();
        //    _input = _driver.FindElement(By.XPath(SelParametry.input));
        //    _input.Clear();
        //    _input.SendKeys("sam");
        //    for (int i = 0; i < 3; i++)
        //    {
        //        _input.SendKeys(Keys.ArrowDown);
        //    }
        //    _input.SendKeys(Keys.Enter);
        //    Thread.Sleep(2000);
        //}

        //[TestMethod]
        //public void assertowanie()
        //{
        //    if (_driver.Title == "Allegro.pl - Więcej niż aukcje. Najlepsze oferty na największej platformie handlowej.")
        //    {
        //        Assert.IsTrue(true);
        //    }
        //}

        [TestCleanup()]
        public void AfterTests()
        {
            _driver.Dispose();
        }
    }   
}
