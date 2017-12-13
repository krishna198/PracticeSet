using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PracticeSetFramework;
using PracticeSetOperations;

namespace PracticeSetTest
{
	[TestFixture]
	public class AccountTests : TestBase
	{
		AccountPage ap = new AccountPage();
		HelperClass hc = new HelperClass();
		string path = @"\\DataSource\\Data.xlsx";

		[Test]
		public void CreateAccountFromDataSource()
		{
			ap.ClickOnSalesTab();
			ap.ClickOnAccountsTab();
			ap.ClickOnCreateLink();
			
			string accountName = hc.ReadDataFromExcel(path, "Account", 1, 0);
			string streeName = hc.ReadDataFromExcel(path, "Account", 1, 1);
			string city = hc.ReadDataFromExcel(path, "Account", 1, 2);
			string state = hc.ReadDataFromExcel(path, "Account", 1, 3);
			string pincode = hc.ReadDataFromExcel(path, "Account", 1, 4);
			string website = hc.ReadDataFromExcel(path, "Account", 1, 5);

			ap.EnterAccountDetails(accountName, website, streeName, city, state, pincode, website);
			ap.ClickOnSaveButton();

			//Search for the account
			Assert.IsTrue(ap.IsAccountDisplayedInTable(accountName),"The account is not displayed after searching.");

		}

		[Test]
		public void VerifyAccountNameAccepts1000Characters()
		{
			ap.ClickOnSalesTab();
			ap.ClickOnAccountsTab();
			ap.ClickOnCreateLink();
			string accountNameWith1000Characters = "LV48suDn12LQbaALyPcVKp47JfSVXqEkVzrOfIp7dNPxhIMIiJP0ipdVJpR3fRtkJCFlbv3kRWdFD4PphifayYUF6O6SOKL3arrVeIqhuwAKFoZnmPETsIutS7e5258Bx7W7Fa89a48vzi1FsDBkfdsoo6B7DJloYziumXHkezZuHSngbWq42fk8OSHhNeIVfCltIPTRY8O9IDO3OvrmFQkhgo5z5Pr3HxYsj2S8qtL52wCo5RDXkuzpBFotzVFeHLRN2rVqSknygm0uLItEzp1GujMSfT6Yd60ZsTH783JbUXpLDmHknSRIl9WujSS8m1iu1fGbWrUy97VkhRL4YpTkVZasa95QKsfXLJKfs3a2bR1d3mEO3olMyPYH3Wq6jxztlRtCwhPhk0ehzvstV2lCbsvxCg49kiH9s5srqnrzbMs3LVIxLzRRB8f1KqWOpHj1YOBJWzdxrblKnCuEVU4N4M96ZQpusieJyblrmLVIoX6m3dFvJ5X1BX9DTFHU8sfNIcyjSBWsI0Y7VzEDHjxlmivuwjp7N9pVaFo0BmTJIMNEO8HXBGiuATsHJZJN1HjghGLIKaQXeJz7cmjdEL0lbl0ZaX0iu4FVG5L0lD5BYJSf6gZTlDweA8uN5IhgOMVXuJDVa6QsgUwzYeKhm0nEpE6A39xHiZFuBRQfXz4cKTGSPONrzGWf1h2X0TmTdnlNL3THRshMQ4U8TuqNcNQ2DVz1x3DN158L9bFthYPuZyZsUyCKbIvPrAZFHqjD8ucXFFgi2yhTNJhTNooiAFEU4bKVWxf3uBsNLWbu5Xxl2KAnV3IYQo32P3bbp4NaHx95N2O8EveOTNwTx30Mu8DDlr6H6ko28xPl3So9phfs4igm6bogz8iQq3fghVfSBmyyitZRf81NEYaMLfnAEyCq86EkO1P6PfRH0svsVkLs2YaFz6QqPwxLh6P6VkS2PM0QjSdRRwryNMNsOFyENN0MHwRgcUetlsVJvUv4";
			ap.SetAccountNameField(accountNameWith1000Characters);
			string accountName = ap.FetchAccountName();
			Assert.AreNotEqual(accountName, accountNameWith1000Characters, "The Account name accepts 1000 chars.");			
		}
	}
}
