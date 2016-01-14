using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace selenium.Metody
{
    class SelMetody
    {
        public static IWebDriver ConfigureDriver(IWebDriver driver, string driverType, string driverPath)
        {
            switch (driverType)
            {
                case "ie":
                    {
                        driver = new InternetExplorerDriver(driverPath);
                        driver.Manage().Window.Maximize();
                        return driver;
                    }
                case "firefox":
                    {
                        driver = new FirefoxDriver();
                        driver.Manage().Window.Maximize();
                        return driver;
                    }
                case "chrome":
                    {
                        driver = new ChromeDriver(driverPath);
                        driver.Manage().Window.Maximize();
                        return driver;
                    }
            }
            return driver;
        }

        public static IWebDriver GoToWebsite(IWebDriver driver, string websiteurl)
        {
            driver.Navigate().GoToUrl(websiteurl);
            return driver;
        }
    }   
}
