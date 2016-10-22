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

        public static string MaskSSN(this string ssn)
        {
            if (string.IsNullOrEmpty(ssn) || ssn.Length != 9)
            {
                return ssn;
            }
            var last4SSN = ssn.Substring(5, 4);
            return $"***-**-{last4SSN}";
        }
    }
}
