using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProd.pr
{
    internal class Class1
    {
        [Test]
        public void test1() 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            driver.Url = "https://demoapps.qspiders.com/ui/table?scenario=1";
            List<IWebElement> table = driver.FindElements(By.XPath("//table//tr")).ToList();
            foreach (IWebElement element in table)
            {
                if (!element.Text.Contains("Levis Shirt"))
                {
                    Console.WriteLine(element.Text);
                }
            }
        }
        [Test]
        public void test2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.espncricinfo.com/rankings/icc-team-ranking";
            List<IWebElement> webElements = driver.FindElements(RelativeBy.WithLocator(By.XPath("//table//tr")).Below(By.XPath("//h2[text()='ICC Test Rankings']"))).ToList();
            foreach (IWebElement element in webElements)
            {
                Console.WriteLine();
                if (!element.Text.Contains("Pakistan"))
                {
                    Console.Write(element.Text + " ");
                }
            }
        }
    }
}
