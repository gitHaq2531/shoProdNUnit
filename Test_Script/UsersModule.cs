using shoProd.GenericUtility;
using shoProd.ObjectRepositoryShoProd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace shoProd.Test_Script
{
    internal class UsersModule:BaseClass
    {
        [Test]
        public void AddTocartFromBooks()
        {
            Console.WriteLine("addTo cart");
            BooksPage bp = hp.clickOnBooksLink();
            ComicsPage cp = bp.ClickOnComicsLink();
            cp.getAddToCartButton().SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            Console.WriteLine(alertText);
        }

        [Test]
        public void AddToCartFromElectronics()
        {
            ElectronicsPage ep = hp.ClickOnElectronicsLink();
            IAlert alert = ep.ClickOnAddTocartButton();
            string alertText = alert.Text;
            Console.WriteLine(alertText);
            alert.Accept();
        }

        [Test]
        public void AddProductFromWishlist()
        {
            ElectronicsPage ep = hp.ClickOnElectronicsLink();
            Thread.Sleep(2000);
            MyWishlistPage wp = ep.ClickOnWishlistIcon();
            wp.ClickOnAddToCartlink();
            driver.SwitchTo().Alert().Accept();
            hp.getMyCartLink().Click();            
        }



    }
}
