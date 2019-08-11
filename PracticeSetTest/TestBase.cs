using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PracticeSetFramework;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace PracticeSetTest
{    
    public class TestBase : BaseClass
	{
		BaseClass bc = new BaseClass();
		HelperClass hc = new HelperClass();
        

        [SetUp]
		public void TestInitialize()
		{
            string browser = ConfigurationManager.AppSettings["Browser"].ToLower();
            switch (browser.ToLowerInvariant())
            {
                case "chrome":
                    driver = InitializeChromeDriver("chromedriver.exe");
                    break;
                case "firefox":
                    driver = InitializeFirefoxDriver();
                    break;
            }
            driver.Url = "https://in.yahoo.com/";
            //hc.BrowseApplicationUrl(ConfigurationManager.AppSettings["Url"]);
            driver.Manage().Window.Maximize();
		}

		[TearDown]
		public void TestCleanup()
		{
			hc.CloseDriver();
		}


        [SetUp]
        public void demo()
        {

        }

        [TearDown]
        public void demo1()
        {

        }
    }
}
