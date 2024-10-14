using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace shoProd.ObjectRepositoryShoProd
{
    internal class BooksPage
    {
        IWebDriver driver;
        public BooksPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Comics')]")]
        private IWebElement comicsLink;
        public ComicsPage ClickOnComicsLink()
        {
            comicsLink.Click();
            return new ComicsPage(driver);
        }
    }
}
