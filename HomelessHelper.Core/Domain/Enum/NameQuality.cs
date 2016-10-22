using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum NameQuality
    {
        FullNameReported,
        [Description("Partial/Street/Code Name Reported")]
        PartialStreetCodeNameReported,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused
    }
}