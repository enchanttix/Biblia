using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Biblia
{
    internal class Functional
    {
        int rowCount;
        int colCount;
        Excel.Application excelApp = new Excel.Application();//создаем объект приложения
        Range fileAccess(int numberList)
        {           
            Workbook ExcelBook = excelApp.Workbooks.Open(@"C:\Users\СмердоваЕВ\source\repos\Biblia\list.xlsx");
            _Worksheet worksheet = (Worksheet)ExcelBook.Worksheets[numberList];//выбираем лист
            Range excelRange = worksheet.UsedRange;//найти используемые ячейки в массиве
            return excelRange;
        }
        public void conclusionReaders()//выыод должников
        {
            Range excelRange = fileAccess(1);
            rowCount = excelRange.Rows.Count;
            colCount = excelRange.Columns.Count;

            for (int i = 2; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {                   
                    if ((excelRange.Cells[i, j] != null) && (excelRange.Cells[i, j].Value2 != null) && (excelRange.Cells[i, 6].Value2 == null))
                    { 
                        Console.Write(excelRange.Cells[i, j].Value2.ToString() + "\t");
                        if (j == (colCount - 1))
                        {
                            Console.Write("\r\n");
                        } 
                    }
                    
                }
            }          
            excelApp.Quit();
            Marshal.FinalReleaseComObject(excelApp);
        }

        public void bookList() 
        {
            Range excelRange = fileAccess(2);
            rowCount = excelRange.Rows.Count;
            colCount = excelRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (excelRange.Cells[i, j].Value2 == null)
                    {
                        Console.Write("\t");
                    }
                    if ((excelRange.Cells[i, j] != null) && (excelRange.Cells[i, j].Value2 != null))
                    {
                        Console.Write(excelRange.Cells[i, j].Value2.ToString() + "\t");                      
                    }
                }
             Console.WriteLine();
            }
            excelApp.Quit();
            Marshal.FinalReleaseComObject(excelApp);
        }
        public void returnMarkBook()
        {
            Range excelRange = fileAccess(1);
            rowCount = excelRange.Rows.Count;
            colCount = excelRange.Columns.Count;
            Console.WriteLine("Введите ФИО читателя");
            string reader = Console.ReadLine();

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {                   
                    if ((excelRange.Cells[i, j] != null) && (excelRange.Cells[i, j].Value2 != null) && (excelRange.Cells[i,2].Value2==reader) && (excelRange.Cells[i, 6].Value2 == null))
                    {
                        Console.Write(excelRange.Cells[i, j].Value2.ToString() + "\t");
                        if (j == (colCount - 1))
                        {
                            Console.Write("\r\n");
                            Console.WriteLine("Введите дату возврата (пример: 10 10 2010)");
                            excelRange.Cells[i, 6] = Console.ReadLine();
                            excelApp.Save(@"C:\Users\СмердоваЕВ\source\repos\Biblia\list.xlsx");
                        }                       
                    }
                }
            }
            excelApp.Quit();
            Marshal.FinalReleaseComObject(excelApp);
        }

        public void addingNewEntry()
        {

        }
    }
}
