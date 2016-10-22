using HomelessHelper.Core.Infrastructure.Conventions;

namespace HomelessHelper.Core.Domain.Enum
{
    public enum TypeOfResidence
    {
        [ProductCategory(ResidenceHeader.LiterallyHomeless)]
        PlaceNotMeantForHabitation,
        [ProductCategory(ResidenceHeader.LiterallyHomeless)]
        EmergencyShelter,
        [ProductCategory(ResidenceHeader.LiterallyHomeless)]
        SafeHaven,
        [ProductCategory(ResidenceHeader.LiterallyHomeless)]
        InterimHousing
    }
}