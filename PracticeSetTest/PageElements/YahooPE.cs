using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSetTest.PracticeSetElements
{
    public class YahooPE
    {
        public By usernameTextbox = By.Id("login-username");
        public By yahoo_Next_Button = By.Id("login-signin");
        public By passwordTextbox = By.Id("login-passwd");
        public By signInButton = By.Id("login-signin");
    }
}
