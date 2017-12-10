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
		string applicationUrl = "http://buzzinglab.com/wr/";

		public void BrowseApplicationUrl()
		{
			driver.Navigate().GoToUrl(applicationUrl);			
		}

		public void LogintoApplication(string userName, string password)
		{
			SetTextToField(driver.FindElement(By.Id("user_name")), userName);
			SetTextToField(driver.FindElement(By.Id("user_password")), password);
			driver.FindElement(By.Id("login_button")).Click();
		}

		public void SetTextToField(IWebElement element, string text)
		{
			element.SendKeys(text);
		}

		public void WaitForElement(By element)
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
			wait.Until(ExpectedConditions.ElementIsVisible(element));
		}

		public void WriteDataToExcelsheet(string path)
		{
			Spreadsheet document = new Spreadsheet();

			// add new worksheet
			Worksheet Sheet = document.Workbook.Worksheets.Add("FormulaDemo");

			// headers to indicate purpose of the column
			Sheet.Cell("A1").Value = "Formula (as text)";
			// set A column width
			Sheet.Columns[0].Width = 250;

			Sheet.Cell("B1").Value = "Formula (calculated)";
			// set B column width
			Sheet.Columns[1].Width = 250;


			// write formula as text 
			Sheet.Cell("A2").Value = "7*3+2";
			// write formula as formula
			Sheet.Cell("B2").Value = "=7*3+2";

			// delete output file if exists already
			if (File.Exists("Output.xls"))
			{
				File.Delete("Output.xls");
			}

			// Save document
			document.SaveAs("Output.xls");

			// Close Spreadsheet
			document.Close();

			// open generated XLS document in default program
			Process.Start("Output.xls");
			/*
			Application ExcelObj = new Application();
			Workbook theWorkbook = ExcelObj.Workbooks.Open(@"D:\ContactDetailsofGICEmployee.xls", 0, true, 
				5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
			Sheets sheets = theWorkbook.Worksheets;
			Worksheet worksheet = (Worksheet)theWorkbook.Worksheets.get_Item(1);
			Range range = worksheet.UsedRange;
			int r = range.Rows.Count;
			dt.Columns.Add("EmpCode");
			dt.Columns.Add("EmpName");
			dt.Columns.Add("Email");
			dt.Columns.Add("ContactNo");
			for (int i = 1; i <= r; i++)
			{
				DataRow dr = dt.NewRow();
				dr["EmpCode"] = Convert.ToString((worksheet.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2);
				dr["EmpName"] = Convert.ToString((worksheet.Cells[i, 2] as Microsoft.Office.Interop.Excel.Range).Value2);
				dr["Email"] = Convert.ToString((worksheet.Cells[i, 3] as Microsoft.Office.Interop.Excel.Range).Value2);
				dr["Cont"] = Convert.ToString((worksheet.Cells[i, 4] as Microsoft.Office.Interop.Excel.Range).Value2);
				dt.Rows.Add(dr);
			}
			return dr;
			 */
		}

		public string ReadDataFromExcel(string path, string sheetName, int row, int col)
		{
			Spreadsheet document = new Spreadsheet();
			document.LoadFromFile(path);

			// Get worksheet by name
			Worksheet worksheet = document.Workbook.Worksheets.ByName(sheetName);
			string data = "";
			data = worksheet.Cell(row, col).ValueAsString;
			// Check dates
			//for (int i = 0; i < 4; i++)
			//{
			//	// Set current cell
			//	Cell currentCell = worksheet.Cell(i, 0);

			//	//DateTime date = currentCell.ValueAsDateTime;
			//	data = currentCell.ValueAsString;
			//	// Write Date
			//	//Console.WriteLine("{0}", date.ToShortDateString());
			//}
			// Close document
			document.Close();

			// Write message
			//Console.Write("Press any key to continue...");

			// Wait user input
			return data;
		}

		public void CloseDriver()
		{
			driver.Close();
		}
	}
}
