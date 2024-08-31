using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using shoProd.GenericUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProd.ObjectRepositoryShoProd
{
    internal class ElectronicsPage
    {
        IWebDriver driver;
        public ElectronicsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[text()='Apple iPhone 6 (Silver, 16 GB)']/ancestor::div[@class='product']//button[text()='Add to cart']")]
        private IWebElement addToCart;
        public IAlert ClickOnAddTocartButton() 
        {
            addToCart.SendKeys(Keys.Enter);
            return driver.SwitchTo().Alert();
        }

        [FindsBy(How = How.XPath, Using = "//a[text()='Apple iPhone 6 (Silver, 16 GB)']/ancestor::div[@class='product']//li[@class='lnk wishlist']")]
        private IWebElement wishlistIcon;
        public MyWishlistPage ClickOnWishlistIcon()
        {
            Console.WriteLine(wishlistIcon.Displayed);
            WebDriverUtils web=new WebDriverUtils(driver);
            web.Actions().SendKeys(wishlistIcon,Keys.Enter);
            return new MyWishlistPage(driver);
        }
    }
}
