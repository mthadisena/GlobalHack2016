using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum TimesHomeless
    {
        OneTime,
        TwoTimes,
        ThreeTimes,
        FourOrMoreTimes,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused
    }
}