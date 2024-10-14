using AventStack.ExtentReports.Model;
using OpenQA.Selenium.Chrome;
using shoProd.GenericUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProd.crossBrowser
{
    [TestFixture(typeof(ChromeDriver))]
    [Parallelizable]
    internal class cross1:BaseClass
    {
        [Test]
        public void CrossTest1()
        {
            Console.WriteLine("cross 1");
        }

        [Test]
        public void CrossTest2()
        {
            Console.WriteLine("cross 2");
        }

        [Test]
        public void CrossTest3()
        {
            Console.WriteLine("cross 3");
        }

        [Test]
        public void CrossTest4()
        {
            Console.WriteLine("cross 4");
        }
    }
}
