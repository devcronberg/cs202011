using ClosedXML.Excel;
using System;

namespace ExcelDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var workbook = new XLWorkbook())
            {
                Random rnd = new Random();
                int rows = 10;
                var ws = workbook.Worksheets.Add("Sheet1");
                ws.Cell(1, 1).Value = "Nr";
                ws.Cell(1, 2).Value = "Navn";
                ws.Cell(1, 3).Value = "Løn";
                for (int row = 2; row < rows + 1; row++)
                {
                    ws.Cell(row, 1).Value = row - 1;
                    ws.Cell(row, 2).Value = Convert.ToChar(row + 63);
                    ws.Cell(row, 3).Value = rnd.Next(10000, 100000);
                }

                var rngTable = ws.Range("A1:C" + rows);
                var rngHeaders = rngTable.Range("A1:C1");
                rngHeaders.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders.Style.Font.Bold = true;
                rngTable.Range("C2:C" + rows).Style.NumberFormat.Format = "#,##0.00";
                ws.Columns(1, 3).AdjustToContents();

                workbook.SaveAs(@"c:\temp\data.xlsx");
            }
        }
    }
}
