using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum VeteranStatus
    {
        No,
        Yes,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused
    }
}