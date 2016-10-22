using System.Collections.Generic;
using OfficeOpenXml;


namespace HomelessHelper.Core.Infrastructure
{
    public static class Extensions
    {
        public static List<ExcelRow> GetWorksheetRows(this ExcelWorksheet worksheet)
        {
            var startRow = worksheet.Dimension.Start.Row;
            var endRow = worksheet.Dimension.End.Row;
            var rows = new List<ExcelRow>();
            for (var row = startRow; row < endRow; row++)
            {
                rows.Add(worksheet.Row(row));
            }
            return rows;
        }
    }
}
