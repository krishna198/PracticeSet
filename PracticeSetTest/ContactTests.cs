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
		ContactPage cp = new ContactPage();
				
		[Test]
		public void CreateContact()
		{
			ap.CreateAccount();
            //Create contact not implmented
		}

		

		[Test]
		public void VerifyLastNameOfContactDoesNotAcceptBlank()
		{
			ap.ClickOnSalesTab();
			cp.OpenCreateContactAndClickOnSaveButton();
			Assert.AreEqual(cp.getLastNameFieldValidationMessage().ToLower(), "Missing required field: Last Name".ToLower(),
					"The validation message is not displayed when we enter blank in last name");
		}

		

	}
}
