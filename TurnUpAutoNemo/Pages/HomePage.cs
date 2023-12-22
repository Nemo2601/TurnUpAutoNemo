using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpAutoNemo.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            try
            {
                //Navigate to Time & Material module
                IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                administrationDropdown.Click();
            }
            catch(Exception) 
            {
                Assert.Fail("TurnUp Portal Home page not displayed");
            }

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
    }
}
