using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum LengthOfStay
    {
        OneNightOrLess,
        TwoToSixNights,
        [Description("One Week Or More, but Less than One Month")]
        OneWeekOrMore,
        [Description("One Month or More, but Less than 90 Days")]
        OneMonthOrMore,
        [Description("90 Days or More, but Less than One Year")]
        NinetyDaysOrMore,
        OneYearOrLonger,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused
    }
}