using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PracticeSetFramework;
using OpenQA.Selenium.Chrome;

namespace PracticeSetTest
{
	public class TestBase : BaseClass
	{
		BaseClass bc = new BaseClass();
		HelperClass hc = new HelperClass();

		[SetUp]
		public void TestInitialize()
		{
            driver = new ChromeDriver();
            hc.BrowseApplicationUrl();
			hc.LogintoApplication("tester2", "kLSrQOa");
		}

		[TearDown]
		public void TestCleanup()
		{
			hc.CloseDriver();
		}
	}
}
