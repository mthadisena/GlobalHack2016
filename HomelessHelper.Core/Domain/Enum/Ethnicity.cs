using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum Ethnicity
    {
        [Description("Non-Hispanic/Non-Latino")]
        NonHispanicNonLatino,
        [Description("Hispanic/Latino")]
        HispanicLatino,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused
    }
}