using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PracticeSetFramework;

namespace PracticeSetTest
{
	public class TestBase : BaseClass
	{
		BaseClass bc = new BaseClass();
		HelperClass hc = new HelperClass();

		[SetUp]
		public void TestInitialize()
		{
			bc.InitializeFirefoxDriver();
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
