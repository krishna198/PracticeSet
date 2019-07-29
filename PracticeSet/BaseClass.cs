using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
//using AventStack.ExtentReports;
using System.Configuration;
//using OpenQA.Selenium.Support;

namespace PracticeSetFramework
{
    public class BaseClass
	{
		public static IWebDriver driver;

        public void ExtentObj()
        {
            //var extent = new ExtentReports();            
        }

        public double timeout = Convert.ToDouble(ConfigurationManager.AppSettings["Timeout"]);


        public IWebDriver InitializeChromeDriver(string path)
        {
            ChromeOptions options = new ChromeOptions();
            driver = new ChromeDriver();
            var te = ConfigurationManager.AppSettings["Timeout"];
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
            return driver;
        }

        public IWebDriver InitializeFirefoxDriver()
        {
            driver = new FirefoxDriver();
            return driver;
        }

        public By GenerateFormattedLocator(By loc, params string[] val)
        {
            By value = null;
            return value;
        }


    }
}
