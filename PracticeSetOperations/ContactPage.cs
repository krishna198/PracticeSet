using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeSetFramework;
using OpenQA.Selenium;

namespace PracticeSetOperations
{
	public class ContactPage : HelperClass
	{
		public void OpenCreateContactAndClickOnSaveButton()
		{
			WaitForElement(By.LinkText("Contacts"));
			WaitForElement(By.Id("moduleTab_0_Contacts"));
			driver.FindElement(By.Id("moduleTab_0_Contacts")).Click();
			//var element = driver.FindElement();
			WaitForElement(By.XPath("//div[@class='moduleTitle']/h2[contains(text(),'Contacts')]"));
			driver.FindElement(By.Id("create_link")).Click();

			WaitForElement(By.Id("last_name"));
			driver.FindElement(By.Id("SAVE_HEADER")).Click();					
		}

		public string getLastNameFieldValidationMessage()
		{
			WaitForElement(By.Id("last_name"));
			var validation = driver.FindElement(By.ClassName("validation-message"));
			return validation.Text;
		}
	}
}
