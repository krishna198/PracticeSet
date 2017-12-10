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
		public void CreateContact()
		{
			//Salutation
			SelectElementByText(driver.FindElement(By.Id("salutation")), "Mr.");

		}
	}
}
