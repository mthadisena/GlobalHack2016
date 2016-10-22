using System.ComponentModel;
using HomelessHelper.Core.Infrastructure.Conventions;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum TypeOfResidence
    {
        [ResidencialCategory(ResidenceStatusCategory.LiterallyHomeless)]
        PlaceNotMeantForHabitation,
        [ResidencialCategory(ResidenceStatusCategory.LiterallyHomeless)]
        EmergencyShelter,
        [ResidencialCategory(ResidenceStatusCategory.LiterallyHomeless)]
        SafeHaven,
        [ResidencialCategory(ResidenceStatusCategory.LiterallyHomeless)]
        InterimHousing,

        [ResidencialCategory(ResidenceStatusCategory.InstitutionalSituation)]
        FosterCareHome,
        [ResidencialCategory(ResidenceStatusCategory.InstitutionalSituation)]
        HospitalOrOtherResidentialMedicalFacility,
        [ResidencialCategory(ResidenceStatusCategory.InstitutionalSituation)]
        [Description("Jail, Prison, or Juvenile Detention Facility")]
        JailPrisonOrJuvenileDetentionFacility,
        [ResidencialCategory(ResidenceStatusCategory.InstitutionalSituation)]
        [Description("Long-Term Care Facility")]
        LongTermCareFacility,
        [ResidencialCategory(ResidenceStatusCategory.InstitutionalSituation)]
        PsychiatricHospitalOrOtherPsychiatricFacility,
        [ResidencialCategory(ResidenceStatusCategory.InstitutionalSituation)]
        SubstanceAbuseTreatmentFacilityOrDetoxCenter,

        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        [Description("Hotel or Motel Paid for Without Emergency Shelter Voucher")]
        HotelOrMotel,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        [Description("Owned ByClient, No Ongoing HousingSubsidy")]
        OwnedByClientWithoutHousingSubsidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        [Description("Owned ByClient, With Ongoing HousingSubsidy")]
        OwnedByClientWithHousingSubsidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        [Description("Permanent Housing For Formerly Homeless Persons")]
        PermanentHousingForFormerlyHomelessPersons,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        [Description("Rental By Client, No Ongoing Housing Subsidy")]
        RentalByClientWithoutHousingSubsidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        [Description("Rental By Client, With VASH Subsidy")]
        RentalByClientWithVASHSubsidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        [Description("Rental By Client, With GPD TIP Subsidy")]
        RentalByClientWithGPDTIPSubdidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        [Description("Rental By Client, With Other Ongoing Housing Subsidy")]
        RentalByClientWithHousingSubsidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        [Description("Residential Project Or Halfway House With No Homeless Criteria")]
        ResidentialProjectOrHalfwayHouse,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        StayingOrLivingWithFamily,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        StayingOrLivingWithFriends,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        [Description("Transitional Housing for Homeless Persons")]
        TransitionalHousing,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        ClientRefused,
    }
}