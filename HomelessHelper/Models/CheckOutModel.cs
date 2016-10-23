using System;
using System.ComponentModel.DataAnnotations;

namespace HomelessHelper.Models
{
    public class CheckOutModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.MultilineText)]
        public string CheckOutSummary { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfDaysStayed => GetNumberOfDays();

        public int GetNumberOfDays()
        {
            var diff = CheckOutDate - CheckInDate;
            return (int)diff.TotalDays;
        }
    }
}