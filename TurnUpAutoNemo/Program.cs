using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

//Open Chrome Browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//Launch TurnUp portal and navigate to login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

//Identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Identify Login button and click on it
IWebElement loginBtn = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginBtn.Click();

//Wait for 3 secs
//Thread.Sleep(3000);

//Check if the user has logged in successfully
IWebElement helloUser = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloUser.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("User has not logged in.");
}

//Test Case - Create a new Time record

//Navigate to Time & Material module
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

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

//Wait for 3 secs
Thread.Sleep(3000);

//Check if a new Time record is created succesfully
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

//test123
