using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProd.ObjectRepository
{
    internal class SampleLoginPage
    {
        IWebDriver driver;
        public SampleLoginPage(IWebDriver driver) 
        { 
            this.driver=driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[data-qa='login-email']")]
        private IWebElement getUsernameEdt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[data-qa='login-password']")]
        private IWebElement getPasswordEdt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[data-qa='login-button']")]
        private IWebElement getLoginButtonEdt { get; set; }

      
        public sampleHomePage GetLoginToApp()
        {
            getUsernameEdt.SendKeys("afzaulhaque1@gmail.com");
            getPasswordEdt.SendKeys("Haque123");
           getLoginButtonEdt.Click();
            //after click on loginButton navigating to home page so passing driver ref to homepage.
            return new sampleHomePage(driver);
        }
    }
}
