using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum HousingStatus
    {
        [Description("Category 1 - Homeless")]
        Category1,
        [Description("Category 2 - At Imminent Risk of Losing Housing")]
        Category2,
        [Description("Category 3 - Homeless Only Under Other Federal Statutees")]
        Category3,
        [Description("Category 4 - Fleeing Domestic Violence")]
        Category4,
        AtRiskOfHomeless,
        StablyHoused,
        [Description("Client Doesn't Know")]
        ClientDoesNotKnow,
        ClientRefused
    }
}