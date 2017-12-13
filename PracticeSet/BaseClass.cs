using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;

namespace PracticeSetFramework
{
	public class BaseClass
	{
		public static IWebDriver driver;

		//public IWebDriver InitializeChromeDriver(string path)
		//{
		//	driver = new ChromeDriver(path);
		//	return driver;
		//}

		//public IWebDriver InitializeFirefoxDriver()
		//{
		//	driver = new FirefoxDriver();
		//	return driver;
		//}
	}
}
