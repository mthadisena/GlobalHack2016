using System;
using System.ComponentModel.DataAnnotations;
using HomelessHelper.Core.Domain.Enum;

namespace HomelessHelper.Models
{
    public class VetStatus
    {
        [Display(Name = "Year Entered Service:")]
        public DateTime YearEnteredService { get; set; }
        [Display(Name = "Year Left Service:")]
        public DateTime YearLeftService { get; set; }
        [Display(Name = "War Served In:")]
        public WarServedIn WarServedIn { get; set; }
        [Display(Name = "Military Branch:")]
        public MilitaryBranch MilitaryBranch { get; set; }
        [Display(Name = "Discharge Status:")]
        public DischargeStatus DischargeStatus { get; set; }
    }
}