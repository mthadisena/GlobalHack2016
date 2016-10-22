using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;

namespace HomelessHelper.Core.Domain
{
    [Table("VetStatus")]
    public class VetStatus : Entity
    {
        public DateTime YearEnteredService { get; set; }
        public DateTime YearLeftService { get; set; }
        public MilitaryBranch MilitaryBranch { get; set; }
        public DischargeStatus DischargeStatus { get; set; }
    }

    [Table("WarService")]
    public class WarService : Entity
    {
        public Client Client { get; set; }
        public DateTime YearStarted { get; set; }
        public DateTime YearEnded { get; set; }
        public WarServedIn WarServedIn { get; set; }
    }
}