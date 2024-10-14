using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using shoProd.GenericUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SeleniumExtras.PageObjects;


namespace shoProd.pr
{
    [TestFixture]
    internal class DemoApp
    {
        [Test]
        public void HandleTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://demoapps.qspiders.com/ui/audio?sublist=0&scenario=1");
            System.Drawing.Point location = driver.FindElement(By.TagName("audio")).Location;
            Console.WriteLine(location);
            Actions act = new Actions(driver);
            act.MoveToLocation(555, 308).Click().Perform();
        }
        [Test]
        public void HandleTest1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://demoapps.qspiders.com/ui/video?sublist=0&scenario=1");
            System.Drawing.Point location = driver.FindElement(By.TagName("video")).Location;
            Console.WriteLine(location);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Actions act = new Actions(driver);
            act.MoveToLocation(440, 305).Click().Perform();
        }
        [Test]
        public void HandleTest2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://demoapps.qspiders.com/ui/slider?sublist=0");
            System.Drawing.Point location = driver.FindElement(By.XPath("//input[@class=' rangeInputSlidebar']")).Location;
            Console.WriteLine(location);
            Actions act = new Actions(driver);
            act.MoveToLocation(395, 144).ClickAndHold().MoveByOffset(400, 0).Perform();

        }

        [Test]
        public void HandleTest3()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disabled-notifications");
            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            string src = "Marathahalli";
            string destn = "Chennai";
            driver.Url = "https://www.redbus.in";
            driver.FindElement(By.Id("src")).Click();
            driver.FindElement(By.Id("src")).SendKeys("Marath");
            List<IWebElement> sug = driver.FindElements(By.XPath("//ul[@class='sc-dnqmqq dZhbJF']/li")).ToList();
            foreach (var s in sug)
            {
                string text = s.Text;
                Console.WriteLine(text);
                if (text.Contains(src))
                {
                    s.Click();
                    break;
                }
            }



            driver.FindElement(By.Id("dest")).Click();
            driver.FindElement(By.Id("dest")).SendKeys("chenn");
            List<IWebElement> sug1 = driver.FindElements(By.XPath("//ul[@class='sc-dnqmqq dZhbJF']/li")).ToList();
            foreach (var s1 in sug1)
            {
                string text = s1.Text;
                Console.WriteLine(text);
                if (text.Contains(destn))
                {
                    s1.Click();
                    break;
                }
            }


            bool flag = false;
            while (flag == false)
            {
                IWebElement calendar = driver.FindElement(By.XPath("//div[contains(@style,'font') and @class='DayNavigator__IconBlock-qj8jdz-2 iZpveD']"));
                string text1 = calendar.Text;
                Console.Write(text1);
                if (text1.Contains("Sep 2024"))
                {
                    Console.WriteLine("yes");
                    driver.FindElement(By.XPath("//span[text()='21']")).Click();
                    driver.FindElement(By.Id("search_button")).Click();
                    //string status = driver.FindElement(By.XPath("//div[@class='oops-wrapper new_oops_wrapper']")).Text;
                    //Console.WriteLine(status);
                    driver.FindElement(By.XPath("//div[text()='Jabbar  Travels']/ancestor::div[@class='clearfix bus-item']/descendant::div[text()='View Seats']")).Click();
                    //driver.Quit();
                    flag = true;
                    break;
                }
                else
                {
                    driver.FindElement(RelativeBy.WithLocator(By.XPath("//*[local-name()='svg']")).RightOf(calendar)).Click();
                }
                IWebElement seats = driver.FindElement(By.XPath("//div[@class='lower-canvas canvas-wrapper']//canvas"));


                Thread.Sleep(5000);
                Actions act = new Actions(driver);
                //act.MoveToElement(seats).ContextClick().Perform();
                act.MoveToLocation(510, 211).ContextClick().Perform();


                //Console.WriteLine(location);
            }
        }

        [Test]
        public void makeMyTrip()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disabled-notifications");
            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            string src = "Marathahalli";
            string destn = "Bengaluru";
            driver.Url = "https://www.makemytrip.com";
            driver.FindElement(By.XPath("//span[@data-cy='closeModal']")).Click();
            driver.FindElement(By.XPath("//label[@for='fromCity']")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='From']")).SendKeys("Marath");
            List<IWebElement> sug = driver.FindElements(By.XPath("//ul[@role='listbox']/li")).ToList();
            foreach (var s in sug)
            {
                string text = s.Text;
                Console.WriteLine(text);
                if (text.Contains(src))
                {
                    s.Click();
                    break;
                }
            }




            driver.FindElement(By.XPath("//label[@for='toCity']")).Click();
            driver.FindElement(By.Id("toCity")).SendKeys("beng");
            List<IWebElement> sug1 = driver.FindElements(By.XPath("//ul[@role='listbox']/li")).ToList();
            Thread.Sleep(3000);
            foreach (var s1 in sug1)
            {
                string text = s1.Text;
                Console.WriteLine(text);
                if (text.Contains(destn))
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(s1));
                    s1.Click();
                    break;
                }
            }
            Boolean flag = false;
            while (flag == false)
            {
                string dep = driver.FindElement(By.XPath("//div[@class='DayPicker-Caption'][1]")).Text;
                if (dep.Contains("September 2024"))
                    {
                   // (//div[@class='DayPicker-Caption']/ancestor::div[@class='DayPicker-Month']//p[text()='21'])[2]
                }
            }
        }
        [Test]
        public void GMail()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
          //  WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            List<IWebElement> webElements = driver.FindElements(By.XPath("//div[@class='header-links']//a")).ToList();
            foreach (var webElement in webElements)
            {
               // wait.Until(ExpectedConditions.ElementToBeClickable(webElement));
                webElement.Click();
                Console.WriteLine(driver.Title);
                driver.Navigate().Back();
            }
        }
        [Test]
        public void RedBus() {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            driver.FindElement(By.XPath("//span[@data-cy='closeModal']")).Click();
            IWebElement oneway = driver.FindElement(By.XPath("//li[@data-cy='oneWayTrip']"));
            Console.WriteLine(oneway.Enabled);
            if (oneway.Enabled)
            {
                Console.WriteLine("selected");
            }
            else
            {
                Console.WriteLine("not selected");
            }
            
            IWebElement roundtrip= driver.FindElement(By.XPath("//li[@data-cy='roundTrip']"));
            roundtrip.Click();
            Console.WriteLine(roundtrip.Selected);
            if (roundtrip.Selected)
            {
                Console.WriteLine("selected");
            }
            else
            {
                Console.WriteLine("not selected");
            }
            IWebElement multicity = driver.FindElement(By.XPath("//li[@data-cy='mulitiCityTrip']/span"));
            multicity.Click();
            Console.WriteLine(multicity.Selected);  
            if (multicity.Selected)
            {
                Console.WriteLine("selected");
            }
            else
            {
                Console.WriteLine("not selected");
            }

        }
    }
}