using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PracticeSetTest.PracticeSetElements
{
    public class LoginLogoutPE
    {
        //public const string userName_Id = "username";
        //public const string password_Id = "password";
        public By usernameTextbox = By.Id("username");
        public By passwordTextbox = By.Id("password");
        public By loginButton = By.XPath("//button[@title='Login']");

        //Time sheet
        public By timeSheetLink = By.XPath("//a[contains(@class,'Timesheet')]");
        public By viewEditLink = By.XPath("//a/span[text()='{0}']");
    }
}
