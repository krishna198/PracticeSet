using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeSetFramework;
using OpenQA.Selenium;

namespace PracticeSetOperations
{
	public class AccountPage : HelperClass
	{
		#region Elements

		public string SalesTabLink = "grouptab_0";
		public string AccountLink = "moduleTab_0_Accounts";
		public string CreateAccountLink = "create_link";


		//Contact
		public string ContactTabLink = "moduleTab_0_Contacts";

		public string AccountNameIdLocator = "name";

		#endregion

		public void CreateAccount()
		{
			ClickOnSalesTab();
			ClickOnAccountsTab();

			//CLick on the create link
			ClickOnCreateLink();
			EnterAccountDetails("DemoAccountName1", "brownbooks.com", "49, Milk Street",
				"Boston", "MA", "32592", "brownbooks.com");

			//Save
			ClickOnSaveButton();

		}

		public void ClickOnSaveButton()
		{
			var saveHeader = driver.FindElement(By.Id("SAVE_HEADER"));
			saveHeader.Click();
		}

		public void EnterAccountDetails(string accountName, string websiteUrl, string street, 
			string city, string state, string pincode, string addressLink)
		{
			SetAccountNameField(accountName);
			driver.FindElement(By.Id("website")).SendKeys(websiteUrl);

			//text area - Address
			driver.FindElement(By.Id("billing_address_street")).SendKeys(street);

			driver.FindElement(By.Id("billing_address_city")).SendKeys(city);

			driver.FindElement(By.Id("billing_address_state")).SendKeys(state);

			driver.FindElement(By.Id("billing_address_postalcode")).SendKeys(pincode);

			driver.FindElement(By.Id("addresslink_c")).SendKeys(addressLink);

		}

		public void SetAccountNameField(string accountName)
		{
			WaitForElement(By.Id(AccountNameIdLocator));
			driver.FindElement(By.Id(AccountNameIdLocator)).SendKeys(accountName);
		}

		public bool IsAccountDisplayedInTable(string accountName)
		{
			ClickOnSalesTab();
			ClickOnAccountsTab();
			WaitForElement(By.XPath("//div[@id='Accountsbasic_searchSearchForm']//input[@id='name_basic']"));

			driver.FindElement(By.Id("search_form_clear")).Click();
			driver.FindElement(By.XPath("//div[@id='Accountsbasic_searchSearchForm']//input[@id='name_basic']")).SendKeys(accountName);

			driver.FindElement(By.Id("search_form_submit")).Click();

			WaitForElement(By.XPath("//table[@class='list view']/tbody"));
			var list = driver.FindElements(By.XPath("//table[@class='list view']/tbody/tr[contains(@class,'ListRowS1')]/td[3]//a"));
			bool isAccountNamedisplayed = false;
			foreach (var item in list)
			{
				if (item.Text.Contains(accountName))
				{
					isAccountNamedisplayed = true;
				}
			}
			return isAccountNamedisplayed;
		}

		public void ClickOnCreateLink()
		{
			WaitForElement(By.Id(CreateAccountLink));
			driver.FindElement(By.Id(CreateAccountLink)).Click();
		}

		public void ClickOnAccountsTab()
		{
			WaitForElement(By.Id(AccountLink));
			driver.FindElement(By.Id(AccountLink)).Click();
		}

		public void ClickOnSalesTab()
		{
			WaitForElement(By.Id(SalesTabLink));
			driver.FindElement(By.Id(SalesTabLink)).Click();
		}

		public string VerifyAccountNameAccepts1000Characters(string textToPass)
		{
			WaitForElement(By.Id("name"));
			driver.FindElement(By.Id("name")).SendKeys(textToPass);
			return "";
		}

		public string FetchAccountName()
		{
			WaitForElement(By.Id("name"));			
			return driver.FindElement(By.Id("name")).GetAttribute("value");
		}
	}
}
