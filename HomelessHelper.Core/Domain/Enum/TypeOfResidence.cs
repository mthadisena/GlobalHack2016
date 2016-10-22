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
        OwnedByClientWithoutHousingSubsidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        OwnedByClientWithHousingSubsidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        PermanentHousingForFormerlyHomelessPersons,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        RentalByClientWithoutHosingSubsidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        RentalByClientWithVASHSubsidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        RentalByClientWithGPDTIPSubdidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        RentalByClientWithHousingSubsidy,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        ResidentialProjectOrHalfwayHouse,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        StayingOrLivingWithFamily,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        StayingOrLivingWithFriend,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        TransitionalHousing,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        ClientDoesNotKnow,
        [ResidencialCategory(ResidenceStatusCategory.TransitionalPermanentSituation)]
        ClientRefused,
    }
}