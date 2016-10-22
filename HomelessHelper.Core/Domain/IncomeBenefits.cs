using System;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Core.Infrastructure.Conventions;

namespace HomelessHelper.Core.Domain
{
    [Table("IncomeBenefits")]
    public class IncomeBenefits : Entity
    {
        public long IncomeId { get; set; }
        public DateTime InformationDate { get; set; }
        public Income Income { get; set; }
        public bool EarnedIncomeFlag { get; set; }
        [Currency]
        public decimal EarnedIncome { get; set; }
        public bool UnemploymentInsuranceFlag { get; set; }
        [Currency]
        public decimal UnemploymentInsurance { get; set; }
        public bool SSIFlag { get; set; }
        [Currency]
        [LabelOverride("Supplemental Security Income (SSI)")]
        public decimal SSI { get; set; }
        public bool SSDIFlag { get; set; }
        [Currency]
        [LabelOverride("Social Security Disability Income (SSDI)")]
        public decimal SSDI { get; set; }
        public bool VAServiceCompensationFlag { get; set; }
        [Currency]
        [LabelOverride("VA Service-Connected Disability Compensation")]
        public decimal VAServiceCompensation { get; set; }
        public bool VANonServicePensionFlag { get; set; }
        [Currency]
        [LabelOverride("VA Non-Service-Connected Disability Pension")]
        public decimal VANonServiceCompensation { get; set; }
        public bool PrivateDisabilityInsuranceFlag { get; set; }
        [Currency]
        public decimal PrivateDisabilityInsurance { get; set; }
        public bool WorkersCompensationFlag { get; set; }
        [Currency]
        [LabelOverride("Worker's Compensation")]
        public decimal WorkersCompensation { get; set; }
        public bool TANFFlag { get; set; }
        [Currency]
        [LabelOverride("Temporary Assistance for Needy Families (TANF)")]
        public decimal TANF { get; set; }
        public bool GAFlag { get; set; }
        [Currency]
        [LabelOverride("General Assistance (GA)")]
        public decimal GA { get; set; }
        public bool RetirementIncomeFlag { get; set; }
        [Currency]
        [LabelOverride("Retirement Incomme from Social Security")]
        public decimal RetirementIncome { get; set; }
        public bool PensionOrRetirementFlag { get; set; }
        [Currency]
        [LabelOverride("Pension or Retirement Income from a Former Job")]
        public decimal PensionOrRetirement { get; set; }
        public bool ChildSupportFlag { get; set; }
        [Currency]
        public decimal ChildSupport { get; set; }
        public bool AlimonyFlag { get; set; }
        [Currency]
        [LabelOverride("Alimony or Other Spousal Support")]
        public decimal Alimony { get; set; }
        public bool OtherFlag { get; set; }
        [Currency]
        public decimal Other { get; set; }
        [Text]
        public string SourceOfOtherIncome { get; set; }
        [Currency]
        public decimal TotalMonthlyIncome => GetTotalMonthlyIncome();
        public NonCashBenefits NonCashBenefits { get; set; }

        public decimal GetTotalMonthlyIncome()
        {
            return EarnedIncome + UnemploymentInsurance + SSI + SSDI + VAServiceCompensation + VANonServiceCompensation +
                   PrivateDisabilityInsurance + WorkersCompensation + TANF + GA + RetirementIncome + PensionOrRetirement +
                   ChildSupport + Alimony + Other;
        }
    }
}