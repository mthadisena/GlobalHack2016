using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum Gender
    {
        Female,
        Male,
        TransgenderMaleToFemale,
        TransgenderFemaleToMale,
        [Description("Doesn't Identify as Male, Female, or Transgender")]
        DoesNotIdentifyAsMaleFemaleOrTransgender,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused,
        Other
    }
}