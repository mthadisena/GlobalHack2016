using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum ResidenceHeader
    {
        LiterallyHomeless,
        InstitutionalSituation,
        [Description("Transitional & Permanent Housing Situation")]
        TransitionalPermanentSituation
    }
}