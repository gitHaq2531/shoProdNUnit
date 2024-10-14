using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using shoProd.ObjectRepositoryShoProd;
using shoProdSample.ObjectRepositoryShoProd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProd.Test_Script
{
    internal class SignUpSignInTest
    {
        public IWebDriver driver;
        SignInSignUpPage sp;

        [OneTimeSetUp]
        
        public void OneTimeSet()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
        }

        [SetUp]
        public void SetUp()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "http://49.249.28.218:8081/AppServer/Online_Shopping_Application/login.php";
            sp = new SignInSignUpPage(driver);
            sp.getUsernameTextField().SendKeys("miller123@gmail.com");
            sp.getLogInPasswordTextField().SendKeys("miller123");
            sp.getLoginButton().Click();
        }
        
        [TearDown]
        public void TearDown()
        {
            HomePage hp=new HomePage(driver);
            hp.getLogoutLink().Click();
            
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Close();
            driver.Dispose();
        }

        [Ignore("already executed")]
        [Test]
        public void createAccountTest()
        {
            sp.getFullNameTextField().SendKeys("david miller");
            sp.getEmailTextField().SendKeys("miller123@gmail.com");
            sp.getContactTextField().SendKeys("9876543210");
            sp.getSignUpPasswordTextField().SendKeys("miller123");
            sp.getConfirmPasswordTextField().SendKeys("miller123");
            sp.getSubmitButton().Click();
            driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("test 1");            
        }

        [Test,Order(0)]
        public void Test2()
        {
            Console.WriteLine("test 2");
        }

        [Test,Order(2)]
        public void Test3()
        {
            Console.WriteLine("test 3");
        }

        [Test,Order(1)]
        public void Test4()
        {
                        Console.WriteLine("test 4");
        }

    }
}
