using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum DestinationType
    {
        Deceased,
        EmergencyShelter,
        [Description("Foster Case Home or Foster Care Group Home")]
        FosterCare,
        [Description("Hospital or Other Residential Non-Psychiatric Medical Faciltiy")]
        Hospital,
        [Description("Hotel or Motel Paid for Without Emergency Shelter Voucher")]
        HotelOrMotel,
        [Description("Jail, Prison, or Juvenile Detention Facility")]
        JailPrisonOrJuvenileDetention,
        [Description("Long-Term Care Facility")]
        LongTermCareFacility,
        [Description("Moved From One HOPWA Funded Project to HOPWA PH")]
        MovedFromOneHOPWAToHOPWA_PH,
        [Description("Moved From One HOPWA Funded Project to HOPWA TH")]
        MoveFromOneHOPWAToHOPWA_TH,
        [Description("Owned ByClient, No Ongoing HousingSubsidy")]
        OwnedByClientWithoutHousingSubsidy,
        [Description("Owned ByClient, With Ongoing HousingSubsidy")]
        OwnedByClientWithHousingSubsidy,
        [Description("Permanent Housing For Formerly Homeless Persons")]
        PermanentHousing,
        PlaceNotMeantForHabitation,
        [Description("Psychiatric Hospital or Other Psychiatric Faciltiy")]
        PsychiatricHospital,
        [Description("Rental By Client, No Ongoing Housing Subsidy")]
        RentalByClientWithoutHousingSubsidy,
        [Description("Rental By Client, With VASH Subsidy")]
        RentalByClientWithVASHSubsidy,
        [Description("Rental By Client, With GPD TIP Subsidy")]
        RentalByClientWithGPDTIPSubdidy,
        [Description("Rental By Client, With Other Ongoing Housing Subsidy")]
        RentalByClientWithHousingSubsidy,
        [Description("Residential Project Or Halfway House With No Homeless Criteria")]
        ResidentialProjectOrHalfwayHouse,
        SafeHaven,
        [Description("Satying or Living With Family, Permanent Tenure")]
        PermanentStayingOrLivingWithFamily,
        [Description("Satying or Living With Family, Temporary Tenure")]
        TemporaryStayingOrLivingWithFamily,
        [Description("Satying or Living With Friends, Permanent Tenure")]
        PermanentStayingOrLivingWithFriend,
        [Description("Satying or Living With Friends, Temporary Tenure")]
        TemporaryStayingOrLivingWithFriend,
        SubstanceAbuseTreatmentFacilityOrDetoxCenter,
        [Description("Transitional Housing for Homeless Persons")]
        TransitionalHousing,
        Other,
        NoExitInterviewCompleted,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused
    }
}