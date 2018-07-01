using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Internal;
//using Microsoft.Office.Interop.Excel;
using Bytescout.Spreadsheet;
using System.IO;
using System.Diagnostics;

namespace PracticeSetFramework
{
	public class HelperClass : BaseClass
	{
		string applicationUrl = "https://cygnet.hrinnova.com/";

		public void BrowseApplicationUrl(string url)
		{
           if(url == string.Empty || url == null)
                driver.Navigate().GoToUrl(applicationUrl);
           else
                driver.Navigate().GoToUrl(url);


        }

		public void SetTextToField(IWebElement element, string text)
		{
			element.SendKeys(text);
		}

		public void SelectElementByText(IWebElement element, string text)
		{
			SelectElement se = new SelectElement(element);
			se.SelectByText(text);
		}

		public void SelectElementByText(IWebElement element, int index)
		{
			SelectElement se = new SelectElement(element);
			se.SelectByIndex(index);
		}

        public void WaitForElement(By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
        }
		        
		public string ReadDataFromExcel(string path, string sheetName, int row, int col)
		{
			string data = "";
			Spreadsheet document = new Spreadsheet();
			try
			{
				string startupPath = AppDomain.CurrentDomain.BaseDirectory;
				
				document.LoadFromFile(startupPath + path);
				Worksheet worksheet = document.Workbook.Worksheets.ByName(sheetName);

				data = worksheet.Cell(row, col).ValueAsString;				
			}
			catch (Exception e)
			{
				string mess = e.Message;
			}
			finally
			{
				document.Close();
			}
			return data;
		}

		public void CloseDriver()
		{
			driver.Close();
		}

        //Generate random string
        public string GenerateRandomString(int length)
        {
            string text = "";
            Random random = new Random();
            var characters = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < length; i++)
            {                
                text = text + characters[random.Next(characters.Length)];
                if (i == 0)
                    text = text[0].ToString().ToUpper();
            }            
            return text;
        }

	}
}
