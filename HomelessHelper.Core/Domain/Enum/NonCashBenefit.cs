using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum NonCashBenefit
    {
        No,
        Yes,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused
    }
}