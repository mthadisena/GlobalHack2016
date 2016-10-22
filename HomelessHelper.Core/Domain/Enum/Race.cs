using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum Race
    {
        [Display(Name = "American Indian/Alaskan Native")]
        AmericanIndianOrAlaskaNative,
        Asian,
        [Display(Name = "African American")]
        AfricanAmerican,
        [Display(Name = "Native Hawaiian/South Pacific Islander")]
        NativeHawaiianOrOtherPacificIslander,
        White,
        [Display(Name = "Choose not to disclose")]
        ClientRefused,
        Other
    }
}