using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum SSNDataQuality
    {
        FullSSNReported,
        ApproximateOrPartialSSNReported,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused,
    }
}