using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;

namespace HomelessHelper.Core.Domain
{
    [Table("VetStatus")]
    public class VetStatus : Entity
    {
        [Display(Name = "Year Entered Service:")]
        [DataType(DataType.Date)]
        public DateTime? YearEnteredService { get; set; }
        [Display(Name = "Year Left Service:")]
        [DataType(DataType.Date)]
        public DateTime? YearLeftService { get; set; }
        [Display(Name = "War Served In:")]
        public WarServedIn? WarServedIn { get; set; }
        [Display(Name = "Military Branch:")]
        public MilitaryBranch? MilitaryBranch { get; set; }
        [Display(Name = "Discharge Status:")]
        public DischargeStatus? DischargeStatus { get; set; }
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