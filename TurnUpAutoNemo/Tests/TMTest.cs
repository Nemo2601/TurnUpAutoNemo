using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpAutoNemo.Pages;
using NUnit.Framework;
using TurnUpAutoNemo.Utilities;

namespace TurnUpAutoNemo.Tests
{
    //Defining the Test class used in the test
    [TestFixture]
    public class TMTest : CommonDriver
    {
        [SetUp]
        public void SetupTM()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();
            //LoginPage object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
            

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // HomePage initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }
        [Test, Order(1), Description("Creating a new record with valid data")]
        public void TestCreateTimeRecord()
        {
            //TMPage initialization and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTimeRecord(driver);
        }
        [Test, Order(2), Description("Editing a new record with valid data")]
        public void TestEditTimeRecord()
        {
            TMPage tMPageObj = new TMPage();
            tMPageObj.UpdateTimeRecord(driver);
        }
        [Test, Order(3), Description("Deleting a new record with valid data")]
        public void TestDeleteTimeRecord()
        {
            TMPage tMPageObj = new TMPage();
            tMPageObj.DeleteTimeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
