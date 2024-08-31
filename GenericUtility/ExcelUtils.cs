using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ClosedXML;
using ClosedXML.Excel;

namespace shoProd.GenericUtility
{
    internal class ExcelUtils
    {
        public string getDataFromExcelFile(int rowNum,int cellNum)
        {
            string path = "C:\\Users\\afzau\\source\\repos\\shoProd\\TestData\\shoProdData.xlsx";
            XLWorkbook wb = new XLWorkbook(path);
            IXLWorksheet sheet = wb.Worksheet("Sheet1");
            IXLRow row = sheet.Row(rowNum);
            IXLCell cell= row.Cell(cellNum);
            string value = cell.GetValue<string>();
            return value;
        }
    }
}
