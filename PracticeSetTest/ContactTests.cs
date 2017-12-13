using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PracticeSetFramework;
using PracticeSetOperations;

namespace PracticeSetTest
{
	[TestFixture]
	public class ContactTests : TestBase
	{
		BaseClass bc = new BaseClass();
		AccountPage ap = new AccountPage();
		LoginLogout ll = new LoginLogout();
		HelperClass hc = new HelperClass();
				
		[Test]
		public void CreateContact()
		{
			//hc.ReadDataFromExcel("");
			ap.CreateAccount();
		}

		

		[Test]
		public void VerifyLastNameOfContactDoesNotAcceptBlank()
		{
		}

		

	}
}
