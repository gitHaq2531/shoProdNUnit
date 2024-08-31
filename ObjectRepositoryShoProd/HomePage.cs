using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProd.ObjectRepositoryShoProd
{
    internal class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement loginLink;
        public IWebElement getLoginLink() { return loginLink; }

        [FindsBy(How = How.LinkText, Using = "Logout")]
        private IWebElement logoutLink;
        public IWebElement getLogoutLink() {return logoutLink;}

        [FindsBy(How = How.XPath, Using = "//a[text()=' Books']")]
        private IWebElement booksLink;
        public BooksPage clickOnBooksLink() 
        {
            booksLink.Click();
            return new BooksPage(driver);
        }

        [FindsBy(How = How.XPath, Using = "//a[text()=' Electronics']")]
        private IWebElement electronicsLink;
        public ElectronicsPage ClickOnElectronicsLink() 
        {
            electronicsLink.Click();
            return new ElectronicsPage(driver);
        }

        [FindsBy(How = How.XPath, Using = "//li/a[text()='My Cart']")]
        private IWebElement myCartLink;
        public IWebElement getMyCartLink() { return myCartLink; }
    }
}
