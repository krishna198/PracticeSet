using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeSetOperations;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace PracticeSetTest
{
    [TestFixture]
    public class LoginLogoutTest : TestBase
    {
        
        //LoginLogout objLoginLogout = new LoginLogout();
        
        public LoginLogoutTest()
        {
            //PageFactory.InitElements(driver, objLoginLogout);
            
        }

        [Test]
        public void LoginToApplication()
        {
            LoginLogout objLoginLogout = new LoginLogout();
            //PageFactory.InitElements(driver, objLoginLogout);
            //new LoginLogout().LogintoApplication("krsinha", "Admin@@123");
            objLoginLogout.Username.SendKeys("krsinha");
            objLoginLogout.Password.SendKeys("Admin@@123");
            objLoginLogout.LoginButton.Click();

            
            //ksks
            //mmdm
            //lllss
        }
    }
}
