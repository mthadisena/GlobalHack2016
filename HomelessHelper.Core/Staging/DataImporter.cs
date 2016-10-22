using System;
using System.IO;
using System.Reflection;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Core.Infrastructure;
using HomelessHelper.Models;
using OfficeOpenXml;

namespace HomelessHelper.Core.Staging
{
    public class DataImporter
    {
        private readonly HomelessHelperDbContext _context;

        public DataImporter(HomelessHelperDbContext context)
        {
            _context = context;
        }

        public void Import()
        {
            var path = Path.Combine(AssemblyPath(), "HomelessHelper.Core", "Staging", "SampleDataSet.xlsx");           
            var file = new FileInfo(path);
            using (var app = new ExcelPackage(file))
            {
                var workbook = app.Workbook;
                var workSheet = workbook.Worksheets["Client"];
               
                for (var row = 2; row < workSheet.GetWorksheetRows().Count -1; row++)
                {
                    var client = AssembleClient(workSheet, row);
                    _context.Clients.Add(client);
                    _context.SaveChanges();
                }                
            }
        }

        private static string AssemblyPath()
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var almost = Uri.UnescapeDataString(uri.Path);
            var testPath = Path.GetDirectoryName(almost);
            return Directory.GetParent(Directory.GetParent(Directory.GetParent(testPath).ToString()).ToString()).ToString();
        }

        private Client AssembleClient(ExcelWorksheet workSheet, int rowIndex)
        {
            var uuID = string.IsNullOrEmpty(workSheet.Cells[rowIndex, 1].Text) ? (long?) null : long.Parse(workSheet.Cells[rowIndex, 1].Text);
            var firstName = string.IsNullOrEmpty(workSheet.Cells[rowIndex, 2].Text) ? null : workSheet.Cells[rowIndex, 2].Text;
            var middleName = string.IsNullOrEmpty(workSheet.Cells[rowIndex, 3].Text) ? null : workSheet.Cells[rowIndex, 3].Text;
            var lastName = string.IsNullOrEmpty(workSheet.Cells[rowIndex, 4].Text) ? null : workSheet.Cells[rowIndex, 4].Text;
            var nameQuality = workSheet.Cells[rowIndex, 5].Text == "1"
                ? NameQuality.FullNameReported
                : workSheet.Cells[rowIndex, 5].Text == "2"
                    ? NameQuality.PartialStreetCodeNameReported
                    : workSheet.Cells[rowIndex, 5].Text == "99"
                        ? NameQuality.ClientRefused
                        : NameQuality.ClientDoesNotKnow;
            var ssn = workSheet.Cells[rowIndex, 6].Text;
            var ssnDataQuality = workSheet.Cells[rowIndex, 7].Text == "1"
                ? SSNDataQuality.FullSSNReported
                : workSheet.Cells[rowIndex, 7].Text == "2"
                    ? SSNDataQuality.ApproximateOrPartialSSNReported
                    : workSheet.Cells[rowIndex, 7].Text == "99"
                        ? SSNDataQuality.ClientRefused
                        : SSNDataQuality.ClientDoesNotKnow;
            var dateOfBirth = string.IsNullOrEmpty(workSheet.Cells[rowIndex, 8].Text) 
                || workSheet.Cells[rowIndex, 8].Text.ToUpper().Trim() == "NULL"
                ? (DateTime?) null : DateTime.Parse(workSheet.Cells[rowIndex, 8].Text);
            var dateOfBirthType = workSheet.Cells[rowIndex, 8].Text == "1"
                ? DateOfBirthType.FullDOBReported
                : workSheet.Cells[rowIndex, 8].Text == "2"
                    ? DateOfBirthType.ApproximateOrPartialDOBReported
                    : workSheet.Cells[rowIndex, 8].Text == "99"
                        ? DateOfBirthType.ClientRefused
                        : DateOfBirthType.ClientDoesNotKnow;
            var race = GetRace(workSheet, rowIndex);
            var gender = workSheet.Cells[rowIndex, 16].Text == "0"
                ? Gender.Male
                : workSheet.Cells[rowIndex, 16].Text == "1"
                    ? Gender.Female
                    : workSheet.Cells[rowIndex, 16].Text == "99"
                        ? Gender.ClientRefused
                        : Gender.ClientDoesNotKnow;
            var veteranStatus = workSheet.Cells[rowIndex, 18].Text == "0"
                ? VeteranStatus.Yes
                : workSheet.Cells[rowIndex, 18].Text == "1"
                    ? VeteranStatus.No
                    : workSheet.Cells[rowIndex, 18].Text == "99"
                        ? VeteranStatus.ClientRefused
                        : VeteranStatus.ClientDoesNotKnow;
            var yearEntered = workSheet.Cells[rowIndex, 19].Text == "NULL" 
                || string.IsNullOrEmpty(workSheet.Cells[rowIndex, 19].Text)
                ? (int?) null : int.Parse(workSheet.Cells[rowIndex, 11].Text);
            var yearSeperated = workSheet.Cells[rowIndex, 20].Text == "NULL" 
                || string.IsNullOrEmpty(workSheet.Cells[rowIndex, 20].Text)
                ? (int?) null : int.Parse(workSheet.Cells[rowIndex, 12].Text);
            var militaryBranch = workSheet.Cells[rowIndex, 29].Text == "1"
                ? MilitaryBranch.Army
                : workSheet.Cells[rowIndex, 29].Text == "2"
                    ? MilitaryBranch.AirForce
                    : workSheet.Cells[rowIndex, 29].Text == "3"
                        ? MilitaryBranch.Navy
                        : workSheet.Cells[rowIndex, 29].Text == "4" ? MilitaryBranch.Marines : (MilitaryBranch?) null;
            var disChargeStatus = workSheet.Cells[rowIndex, 30].Text == "1"
                ? DischargeStatus.Honorable
                : workSheet.Cells[rowIndex, 30].Text == "2" ? DischargeStatus.Dishonorable : (DischargeStatus?) null;
            
            var vetStatus = new VetStatus
            {
                YearEnteredService = yearEntered == null || yearEntered == 0 ? (DateTime?) null : new DateTime(yearEntered.Value),
                YearLeftService = yearSeperated == null || yearEntered == 0 ? (DateTime?) null : new DateTime(yearSeperated.Value),
                DischargeStatus = disChargeStatus,
                MilitaryBranch = militaryBranch
            };

            return new Client
            {
                UUID = uuID,
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                NameQuality = nameQuality,
                SSN = ssn,
                SsnDataQuality = ssnDataQuality,
                DateOfBirth = dateOfBirth,
                DateOfBirthType = dateOfBirthType, 
                Race = race,
                Gender = gender,
                VeteranStatus = veteranStatus,
                VetStatus = vetStatus
            };
        }

        private static Race GetRace(ExcelWorksheet worksheet, int rowIndex)
        {
            const int raceStart = 8;
            const int raceEnd = 13;

            for (var raceColumnIndex = raceStart; raceColumnIndex < raceEnd; raceColumnIndex++)
            {
                if (worksheet.Cells[rowIndex, raceColumnIndex].Text == "1")
                {
                    return FindAppropraite(raceColumnIndex);
                }                
            }
            return Race.ClientRefused;
        }

        private static Race FindAppropraite(int column)
        {
            switch (column)
            {
                case 8:
                    return Race.AmericanIndianOrAlaskaNative;
                case 9:
                    return Race.Asian;
                case 10:
                    return Race.BlackOrAfricanAmerican;
                case 11:
                    return Race.NativeHawaiianOrOtherPacificIslander;
                case 12: 
                    return Race.White;
                case 13:
                    return Race.ClientRefused;
                default:
                    return Race.ClientDoesNotKnow;
            }
        }
    }
}
