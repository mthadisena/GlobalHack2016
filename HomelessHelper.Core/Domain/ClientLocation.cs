using System;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.EntityFramework;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;

namespace HomelessHelper.Core.Domain
{
    [Table("ClientLocation")]
    public class ClientLocation : Entity
    {
        public DateTime InformationDate { get; set; }
        public long HUDCocCode { get; set; }
    }
}