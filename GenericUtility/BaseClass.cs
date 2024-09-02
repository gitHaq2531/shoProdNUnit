using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using shoProd.ObjectRepositoryShoProd;
using shoProdSample.ObjectRepositoryShoProd;
using shoProd.GenericUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Internal.Logging;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter.Config;
using NUnit.Framework.Internal;

namespace shoProd.GenericUtility
{
    internal class BaseClass
    {
        public HomePage hp;
        ExcelUtils excelUtils = new ExcelUtils();
        ExtentReports reports;
        ExtentTest test;
        string testName = "";
        public IWebDriver driver;

        public ActionTargets Targets => throw new NotImplementedException();

        [OneTimeSetUp]
        public void LaunchBrowser()
        {
            ExtentSparkReporter spark = new ExtentSparkReporter("C:\\Users\\afzau\\source\\repos\\shoProd\\Reports\\advanceReport.html");
            spark.Config.DocumentTitle = "shoProdAppReport";
            spark.Config.ReportName = "shoProdApp";
            spark.Config.Theme = Theme.Dark;
            reports = new ExtentReports();
            reports.AttachReporter(spark);

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
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = url;
        }

        [SetUp]
        public void Setup()
        {
            hp = new HomePage(driver);
            hp.getLoginLink().Click();
            string username = excelUtils.getDataFromExcelFile(3, 2);
            string password = excelUtils.getDataFromExcelFile(4, 2);
            Console.WriteLine(username + "..... " + password);
            SignInSignUpPage lp = new SignInSignUpPage(driver);
            lp.SignInToApp(username, password);
            Thread.Sleep(2000);

            // createv test
            testName = TestContext.CurrentContext.Test.Name;
            test = reports.CreateTest(testName);

        }
       

        [TearDown]
        public void TearDown()
        {
            test.Log(Status.Info, testName + " start");        
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                test.Log(Status.Fail, testName + " failed");
                ITakesScreenshot ts = (ITakesScreenshot)driver;
                string value = ts.GetScreenshot().AsBase64EncodedString;
                test.AddScreenCaptureFromBase64String(value, testName);
            }
            else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                test.Log(Status.Pass, testName + " passed");
            }

            hp.getLogoutLink().Click();
            Console.WriteLine("logout here");
        }

        [OneTimeTearDown]
        public void TearDownNow()
        {
            driver.Quit();
            driver.Dispose();
            reports.Flush();
        }

    }
}
