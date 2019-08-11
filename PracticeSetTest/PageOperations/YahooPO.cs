using OpenQA.Selenium;
using PracticeSetFramework;
using PracticeSetTest.PracticeSetElements;

namespace PracticeSetTest.PracticeSetOperations
{
    public class YahooPO : HelperClass
    {
        YahooPE objYahooPE = new YahooPE();

        public YahooPO()
        {

        }

        public void LoginToYahoo(string username, string password)
        {
            WaitForElementVisible(objYahooPE.usernameTextbox);
            SetTextToField(objYahooPE.usernameTextbox, username);
            ClickElementByJavascript(objYahooPE.yahoo_Next_Button);
            
            SetTextToField(objYahooPE.passwordTextbox, password);
            ClickElementByJavascript(objYahooPE.signInButton);
                        
        }

        public void DeleteUnwantedEmails()
        {
            string te = GetAttribute(By.XPath("//div[@data-test-id='navigation']"),"aria-label");
            ClickElementByJavascript(By.XPath("//span[contains(@title,'Inbox')]/span/span/span"));

            var list = driver.FindElements(By.XPath("//*[@data-test-id='infinite-scroll-ROW']"));


        }
    }
}
