using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace shoProd.GenericUtility
{
    internal class WebDriverUtils
    {
        IWebDriver driver;
        public WebDriverUtils(IWebDriver driver)  
        {
            this.driver = driver;
        }
        public void ImplicitWait() {
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
        }
        public WebDriverWait ExpilicitWait() {
            WebDriverWait wait=new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            return wait;
        }

        public void WaitForAlertToBePresent()  { 
            ExpilicitWait().Until(ExpectedConditions.AlertIsPresent());
        }

        public void WaitForElementToBeClickable(IWebElement element)
        {
            ExpilicitWait().Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public void WaitForElementToBeVisible(IWebElement element)
        {
            ExpilicitWait().Until(ExpectedConditions.ElementIsVisible((By)element));
        }

        public void WaitForTitleContains(string PartialTitle)
        {
            ExpilicitWait().Until(ExpectedConditions.TitleContains(PartialTitle));
        }

        public Actions Actions() {
            Actions act=new Actions(driver);
            return act;
        }

        public void MoveToElement(IWebElement element) {
            Actions().MoveToElement(element);
        }

        public void scrollPageByAmount(int x,int y) {
            Actions().ScrollByAmount(x, y).Perform();
        }

        public void ScrollToElement(IWebElement element) {
            Actions().ScrollToElement(element);
        }

        public SelectElement SelectElement(IWebElement element)
        {
            SelectElement select = new SelectElement(element);
            
            return select;
        }

        public void SelectByIndex(IWebElement element, int index) 
        { 
            SelectElement(element).SelectByIndex(index);
        }

        public void SelectByValue(IWebElement element, string value)
        {
            SelectElement(element).SelectByValue(value);
        }

        public void SelectByText(IWebElement element, string text)
        {
            SelectElement(element).SelectByText(text);
        }

        public void SwitchToWindowByTitle(string title)
        {
            List<string> windowHandles = driver.WindowHandles.ToList();
            foreach (string windowHandle in windowHandles)
            {
                driver.SwitchTo().Window(windowHandle);
                string windowTitle = driver.Title;
                if(windowTitle.Equals(title))
                {
                    break;
                }

            }
        }
        public void SwitchToWindowByUrl(string partialUrl)
        {
            List<string> windowHandles = driver.WindowHandles.ToList();
            foreach (string windowHandle in windowHandles)
            {
                driver.SwitchTo().Window(windowHandle);
                string windowTitle = driver.Url;
                if (windowTitle.Equals(partialUrl))
                {
                    break;
                }

            }
        }

    }
}
