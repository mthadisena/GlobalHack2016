using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum Ethnicity
    {
        [Display(Name = "Non-Hispanic/Non-Latino")]
        [Description("Non-Hispanic/Non-Latino")]
        NonHispanicNonLatino,
        [Display(Name = "Hispanic/Non-Latino")]
        [Description("Hispanic/Latino")]
        HispanicLatino,
        [Display(Name = "Client Doesn't Know")]
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        [Display(Name = "Don't want to disclose")]
        NonDisclosed
    }
}