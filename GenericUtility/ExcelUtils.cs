using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ClosedXML;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using OpenQA.Selenium.Interactions;

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
            wb.Dispose();
            return value;
        }

        [Property("author"," afzaul")]
        [Test]
        public void GetMultipleDataFromExcelFile()
        {

            string path = "C:\\Users\\afzau\\source\\repos\\shoProd\\TestData\\shoProdData.xlsx";
            XLWorkbook wb = new XLWorkbook(path);
            IXLWorksheet sheet = wb.Worksheet("Sheet1");
            int totalRow = sheet.LastRowUsed().RowNumber();
            int rown=sheet.RowCount();
            for (int i=1;i<=totalRow; i++)
            {
               int totalCell= sheet.Row(i).CellsUsed().Count();
                Console.WriteLine(totalCell);
                for (int j = 1; j <= totalCell; j++)
                {
                    string value = sheet.Row(i).Cell(j).GetValue<string>();
                    Console.Write(value+" ");
                }
                Console.WriteLine();
            }
            //int c=sheet.LastColumnUsed().ColumnNumber();
            //int v1 = sheet.Row(1).CellsUsed().Count();
            //Console.WriteLine("total col : "+v1);
        }
    }
}
