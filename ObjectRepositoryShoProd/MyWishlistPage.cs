using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProd.ObjectRepositoryShoProd
{
    internal class MyWishlistPage
    {
        IWebDriver driver;
        public MyWishlistPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Add to cart")]
        private IWebElement addTocartLink;
        public void ClickOnAddToCartlink()
        {
            addTocartLink.SendKeys(Keys.Enter);
        }
    }
}
