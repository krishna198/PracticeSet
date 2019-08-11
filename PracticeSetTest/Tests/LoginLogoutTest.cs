using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using PracticeSetTest.PracticeSetOperations;

namespace PracticeSetTest
{
    [TestFixture]
    public class LoginLogoutTest : TestBase
    {       

        [Test]
        [Description("Login to HRInnova")]
        public void LoginToApplication()
        {
            LoginLogoutPO objLoginLogout = new LoginLogoutPO();
            //PageFactory.InitElements(driver, objLoginLogout);
            new LoginLogoutPO().LogintoApplication("krsinha", "Admin@@123");
           
        }
    }
}
