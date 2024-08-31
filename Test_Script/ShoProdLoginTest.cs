using shoProd.GenericUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProdSample.Test_Script
{
    internal class ShoProdLoginTest:BaseClass
    {
        [Test]
        public void LoginTest()
        {
            ExcelUtils excelUtils = new ExcelUtils();
            string username = excelUtils.getDataFromExcelFile(3, 2);
            string password = excelUtils.getDataFromExcelFile(4, 2);
            Console.WriteLine(username);
            Console.WriteLine(password);
        }
    }
}
