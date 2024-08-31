using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using shoProd.ObjectRepository;
using System.Data.Common;


namespace shoProd
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            SampleLoginPage lp=new SampleLoginPage(driver);
            

            
        }
    }
}