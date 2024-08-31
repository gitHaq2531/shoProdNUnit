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
    internal class ComicsPage
    {
        IWebDriver driver;
        public ComicsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[text()='The Wimpy Kid Do -It- Yourself Book']/ancestor::div[@class='product']//button[text()='Add to cart']")]
        private IWebElement addTocartButton;
        public IWebElement getAddToCartButton() 
        {
            return addTocartButton; 
        }
    }
}
