using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum DisablingConditions
    {
        Yes,
        No,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused
    }
}