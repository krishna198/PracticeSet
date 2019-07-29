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

        [Test]
        //[Description("This is the description for the test.")]
        public void LoginToApplication()
        {
            LoginLogout objLoginLogout = new LoginLogout();
            //PageFactory.InitElements(driver, objLoginLogout);
            new LoginLogout().LogintoApplication("krsinha", "Admin@@123");
           
            
            
            //ksks
            //mmdm
            //lllss
        }
    }
}
