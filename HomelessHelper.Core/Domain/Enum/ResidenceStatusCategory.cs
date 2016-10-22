using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum ResidenceStatusCategory
    {
        LiterallyHomeless,
        InstitutionalSituation,
        [Description("Transitional & Permanent Housing Situation")]
        TransitionalPermanentSituation
    }
}