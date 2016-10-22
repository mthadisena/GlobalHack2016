using System;
using HomelessHelper.Core.Domain.Enum;

namespace HomelessHelper.Models
{
    public class VetStatus
    {
        public DateTime YearEnteredService { get; set; }
        public DateTime YearLeftService { get; set; }
        public WarServedIn WarServedIn { get; set; }
        public MilitaryBranch MilitaryBranch { get; set; }
        public DischargeStatus DischargeStatus { get; set; }
    }
}