using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpAutoNemo.Pages
{
    public class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            //Identify and click Create New btn
            IWebElement createNewBtn = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewBtn.Click();

            //Select TypeCode - Time from dropdown
            IWebElement typeCodeDrpDwn = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDrpDwn.Click();
            IWebElement typeCodeDrpDwn1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1] "));
            typeCodeDrpDwn1.Click();

            //Enter Code
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("September2023");

            //Enter Description
            IWebElement desriptionTextBox = driver.FindElement(By.Id("Description"));
            desriptionTextBox.SendKeys("September2023");

            //Enter Price
            IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextBox.SendKeys("150");

            //Click the Save btn
            IWebElement saveBtn = driver.FindElement(By.Id("SaveButton"));
            saveBtn.Click();

            //Wait for 1 secs
            Thread.Sleep(1000);

            //Check if a new Time record is created succesfully in the last page of the table
            IWebElement goToLastPageBtn = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]"));
            goToLastPageBtn.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newCode.Text == "September2023")
            {
                Console.WriteLine("New Entry is created");
            }
            else
            {
                Console.WriteLine("New Entry not created");
            }
        }

        public void UpdateTimeRecord(IWebDriver driver) 
        {
            //Edit the last entry on the table

            IWebElement editEntry = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editEntry.Click();

            //Click the Save btn
            IWebElement saveEditBtn = driver.FindElement(By.Id("SaveButton"));
            saveEditBtn.Click();

            //Wait for 1 secs
            Thread.Sleep(1000);
        }

        public void DeleteTimeRecord(IWebDriver driver) 
        {
            //Delete the last entry input into table after going to last page
            IWebElement goToLastPageBtn1 = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]"));
            goToLastPageBtn1.Click();

            IWebElement delBtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            delBtn.Click();

            //Wait for 1 secs
            Thread.Sleep(1000);

            driver.SwitchTo().Alert().Accept();
        }
    }
}
