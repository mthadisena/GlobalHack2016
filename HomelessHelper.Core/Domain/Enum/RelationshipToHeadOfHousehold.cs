using System.ComponentModel;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum RelationshipToHeadOfHousehold
    {
        Self,
        Child,
        Spouse,
        OtherRelationMember,
        [Description("Other: Non-relation member")]
        OtherNoRelation
    }
}