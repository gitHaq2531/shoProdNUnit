using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using shoProd.ObjectRepositoryShoProd;
using shoProdSample.ObjectRepositoryShoProd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProd.GenericUtility
{
    internal class BaseClass
    {
        public HomePage hp;
        ExcelUtils excelUtils=new ExcelUtils();
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LaunchBrowser() 
        {
            string browser = excelUtils.getDataFromExcelFile(1, 2);
            string url = excelUtils.getDataFromExcelFile(2, 2);
            if (browser.Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            if (browser.Equals("edge"))
            {
                driver = new EdgeDriver();
            }
            if (browser.Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            hp=new HomePage(driver);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            driver.Url =url;
        }

        [SetUp]
        public void Setup()
        {
            hp.getLoginLink().Click();
            string username = excelUtils.getDataFromExcelFile(3, 2);
            string password = excelUtils.getDataFromExcelFile(4, 2);
            Console.WriteLine(username + "..... " + password);
            SignInSignUpPage lp=new SignInSignUpPage(driver);
            lp.SignInToApp(username,password);
            Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDown()
        {
            hp.getLogoutLink().Click();
            Console.WriteLine("logout here");
        }

        [OneTimeTearDown]
        public void TearDownNow()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
