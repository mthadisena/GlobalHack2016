using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum Race
    {
        AmericanIndianOrAlaskaNative,
        Asian,
        BlackOrAfricanAmerican,
        NativeHawaiianOrOtherPacificIslander,
        White,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused
    }
}