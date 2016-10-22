using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum DateOfBirthType
    {
        FullDOBReported,
        ApproximateOrPartialDOBReported,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused,
    }
}