using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using AventStack.ExtentReports.Utils;
using AventStack.ExtentReports;

namespace PracticeSetFramework
{
	public class BaseClass
	{
		public static IWebDriver driver;

        public void ExtentObj()
        {
            var extent = new ExtentReports();            
        }


        public IWebDriver InitializeChromeDriver(string path)
        {
            driver = new ChromeDriver();
            return driver;
        }

        public IWebDriver InitializeFirefoxDriver()
        {
            driver = new FirefoxDriver();
            return driver;
        }


    }
}
