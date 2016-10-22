using System;
using System.Collections.Generic;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;

namespace HomelessHelper.Core.Domain
{
    public class VetStatus
    {
        public DateTime YearEnteredService { get; set; }
        public DateTime YearLeftService { get; set; }
        public MilitaryBranch MilitaryBranch { get; set; }
        public List<WarService> WarsServedIn { get; set; }
        public DischargeStatus DischargeStatus { get; set; }
    }

    public class WarService
    {
        public DateTime YearStarted { get; set; }
        public DateTime YearEnded { get; set; }
        public WarServedIn WarServedIn { get; set; }
    }
}