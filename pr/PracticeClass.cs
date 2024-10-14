using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V127.Debugger;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace shoProd.pr
{
    internal class PracticeClass
    {
        [Test]
        public void Programs()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://www.amazon.in";
            List<IWebElement> webElements = driver.FindElements(By.XPath("//div[@class='navFooterVerticalRow navAccessibility']//a")).ToList();
            Console.WriteLine(webElements.Count);
            Actions act=new Actions(driver);
            foreach (IWebElement webElement in webElements)
            {
                act.MoveToElement(webElement).Perform();
                Thread.Sleep(500);
                Console.WriteLine(webElement.Text);
            }
        }
        [Test]
        public void Programs2()
        {
            String s = "afzaul haque";
            Console.WriteLine(s.Split()[1]+" " + s.Split()[0]);
        }
    }
}