using System;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.Domain.Enum;

namespace HomelessHelper.Core.Domain
{
    [Table("Client")]
    public class Client : Person
    {
        public string SSN { get; set; }
        public SSNDataQuality SsnDataQuality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public string Email { get; set; }
        public NameQuality NameQuality { get; set; }
        public DateOfBirthType DateOfBirthType { get; set; }
        public Race Race { get; set; }
        public Ethnicity Ethnicity { get; set; }
    }
}