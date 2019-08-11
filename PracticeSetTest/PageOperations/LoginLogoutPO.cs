using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeSetFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PracticeSetTest.PracticeSetElements;

namespace PracticeSetTest.PracticeSetOperations
{
	public class LoginLogoutPO : HelperClass
	{
        LoginLogoutPE objLoginLogoutPE = new LoginLogoutPE();
        /*
        public LoginLogout()
        {
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(20)));
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement Username;// { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@title='Login']")]
        public IWebElement LoginButton { get; set; }
        */        
        public void LogintoApplication(string userName, string password)
        {            
            WaitForElementVisible(objLoginLogoutPE.usernameTextbox);            
            SetTextToField(objLoginLogoutPE.usernameTextbox, userName);
            SetTextToField(objLoginLogoutPE.passwordTextbox, password);            
            ClickElement(objLoginLogoutPE.loginButton);
                       
        }




    }
}
