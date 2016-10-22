using System;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Core.Infrastructure.Conventions;

namespace HomelessHelper.Core.Domain
{
    [Table("NonCashBenefits")]
    public class NonCashBenefits : Entity
    {
        public DateTime InformationDate { get; set; }
        public NonCashBenefit NonCashBenefit { get; set; }
        [LabelOverride("Supplemental Nutrition Assistance Program (SNAP)")]
        public bool SNAP { get; set; }
        [LabelOverride("Special Supplemental Nutrition Program for Women, Infants,and Children(WIC)")]
        public bool WIC { get; set; }
        [LabelOverride("TANF Child Care Services")]
        public bool TANFChildCareServices { get; set; }
        [LabelOverride("TANF Transportation Services")]
        public bool TANFTransportationService { get; set; }
        [LabelOverride("Other TANF-Funded Services")]
        public bool OtherTANF { get; set; }
        [LabelOverride("Section 8, Public Housing, or Other Ongoing Rental Assistance ")]
        public bool Section8 { get; set; }
        public bool OtherSource { get; set; }
        public bool TemporaryRentalAssistance { get; set; }
        [Text]
        public string SpecifyTemporarySource { get; set; }
    }
}