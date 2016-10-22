using System;
using System.ComponentModel.DataAnnotations;
using HomelessHelper.Core.Domain.Enum;

namespace HomelessHelper.Models
{
    public class InTakeModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string SSN { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public Race Race { get; set; }
        public Gender Gender { get; set; }
        public VetStatus VetStatus { get; set; }
        public Ethnicity Ethnicity { get; set; }
        public bool IsVet { get; set; }
    }
}
