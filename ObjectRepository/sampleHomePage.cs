using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProd.ObjectRepository
{
    internal class sampleHomePage
    {
        IWebDriver driver;
        public sampleHomePage(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            
        }

        [FindsBy(How = How.XPath, Using = "//a[text()=' Home']")]
        private IWebElement homeLinkEdt;
        public IWebElement getHomeLink() {return homeLinkEdt;}

        [FindsBy(How = How.CssSelector, Using = "a[href='/logout']")]
        private IWebElement logoutLinkEdt;
        public IWebElement getLogoutEdt() { return logoutLinkEdt; }

        [FindsBy(How = How.CssSelector, Using = "a[href='/products']")]
        private IWebElement productLinkEdt;
        public IWebElement getproductLinkEdt() { return productLinkEdt; }

        [FindsBy(How = How.CssSelector, Using = "a[href='/view_cart']")]
        private IWebElement cartLinkEdt;
        public IWebElement getCartLinkEdt() { return cartLinkEdt; }

        [FindsBy(How = How.CssSelector, Using = "a[href='/delete_account']")]
        private IWebElement deleteAccountLinkEdt;
        public IWebElement getDeleteAccountLinkEdt() { return deleteAccountLinkEdt; }

        [FindsBy(How=How.XPath,Using = "//a[text()=' Test Cases']")]
        private IWebElement testCaseLinkEdt;
        public IWebElement getTestCaseLinkEdt() {return testCaseLinkEdt;}

        [FindsBy(How =How.XPath,Using = "//a[text()=' API Testing']")]
        private IWebElement apiTestingLinkEdt;
        public IWebElement getApiTestingLinkEdt() { return apiTestingLinkEdt; }

        [FindsBy(How = How.XPath, Using = "//a[text()=' Video Tutorials']")]
        private IWebElement videoTutorialLinkEdt;
        public IWebElement getVideoTutorialEdt() { return videoTutorialLinkEdt; }

        [FindsBy(How = How.XPath, Using = "//a[text()=' Contact us']")]
        private IWebElement contactUsLinkEdt;
        private IWebElement getContactUsLinkEdt() { return contactUsLinkEdt; }
    }
}
