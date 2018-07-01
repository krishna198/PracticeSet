using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeSetFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace PracticeSetOperations
{
	public class LoginLogout : BaseClass
	{
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

        HelperClass helperClass = new HelperClass();
        public void LogintoApplication(string userName, string password)
        {

            //helperClass.SetTextToField(Username, userName);
            //helperClass.SetTextToField(Password, password);
            //LoginButton.Click();
            By loc = By.Id("username");
            helperClass.WaitForElement(loc);
            driver.FindElement(loc).SendKeys(userName);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@title='Login']")).Click();

            driver.FindElement(By.XPath("//a[contains(@class,'Timesheet')]")).Click();
            driver.FindElement(By.XPath("//a[contains(@class,'Timesheet')]")).Click();
            var linkName = driver.FindElement(By.XPath("//a/span[text()='View/Edit/Delete Timesheet']"));
            linkName.Click();

            var addTimeSheet = driver.FindElement(By.Id("MainContent_UcViewDataEntry1_lnkAddNewEntry"));
            addTimeSheet.Click();

            //Adding date
            var date = DateTime.Now.Day;
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            int year1 = 6;
            string curr = "";
            switch (month)
            {
                case 1:
                    curr = "Jan";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    curr = "Jun";
                    break;
                    
            }
            
            var timesheetDate = date + "-"+curr+"-"+year;

            By date1 = By.XPath("//div[@id='MainContent_UcAddDataEntry1_ucFromDate_divCalenderPopup']/div/input");
            driver.FindElement(date1).Clear();
            driver.FindElement(date1).SendKeys(timesheetDate);

            

            var workDesc = "Creating Automation scripts.";
            var hours = "8";
            var mins = "30";

            driver.FindElement(By.Id("MainContent_UcAddDataEntry1_txtDesc")).SendKeys(workDesc);

        }




    }
}
