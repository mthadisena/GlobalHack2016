using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum Income
    {
        No,
        Yes,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused
    }
}