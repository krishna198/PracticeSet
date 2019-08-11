using NUnit.Framework;
using PracticeSetTest.PracticeSetOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSetTest
{
    [TestFixture]
    public class YahooTests : TestBase
    {
        YahooPO objYahooPO = new YahooPO();

        [Test]
        public void YahooTest1()
        {
            //driver.Url = "https://in.yahoo.com/";


            objYahooPO.LoginToYahoo("krishna_sinha84@yahoo.co.in", "StrongPassword01*");

            //delete the emails
            objYahooPO.DeleteUnwantedEmails();


        }
    }
}
