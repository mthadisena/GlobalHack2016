using System;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Domain
{
    [Table("LivingSituation")]
    public class LivingSituation : Entity
    {
        public ResidenceHeader ResidenceHeader { get; set; }
        public TypeOfResidence TypeOfResidence { get; set; }
        public LengthOfStay LengthOfStay { get; set; }
        public DateTime DateStarted { get; set; }
        public TimesHomeless TimesHomeless { get; set; }
        public int MonthsHomeless { get; set; }
    }
}