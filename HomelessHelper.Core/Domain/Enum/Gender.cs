using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum Gender
    {
        Female,
        Male,
        [Display(Name = "Male-Female Transgender")]
        TransgenderMaleToFemale,
        [Display(Name = "Female-Male Transgender")]
        TransgenderFemaleToMale,
        [Display(Name = "Choose not to disclose")]
        ClientRefused,
        Other
    }
}