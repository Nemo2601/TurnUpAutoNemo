using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpAutoNemo.Utilities;

namespace TurnUpAutoNemo.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //Launch TurnUp portal and navigate to login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

            //Identify username textbox and enter valid username
            Wait.WaitToBeVisible(driver, "Id", "UserName", 5);
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            //Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //Identify Login button and click on it
            IWebElement loginBtn = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginBtn.Click();
        }
    }
}
