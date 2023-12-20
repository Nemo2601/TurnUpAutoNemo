using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.ComponentModel.DataAnnotations;
using TurnUpAutoNemo.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //Open Chrome Browser
        IWebDriver driver = new ChromeDriver();

        //LoginPage object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        // HomePage initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMPage(driver);

        //TMPage initialization and definition
        TMPage tMPageObj = new TMPage();
        tMPageObj.CreateTimeRecord(driver);
        tMPageObj.UpdateTimeRecord(driver);
        tMPageObj.DeleteTimeRecord(driver);
    }
}