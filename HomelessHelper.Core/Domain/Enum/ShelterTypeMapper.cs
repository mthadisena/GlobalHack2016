using System.Collections.Generic;

namespace HomelessHelper.Core.Domain.Enum
{ 
    public static class ShelterTypeMapper
    {
        public static Dictionary<Gender, ShelterType> Map =
            new Dictionary<Gender, ShelterType>
            {
                {Gender.Male, ShelterType.Men},
                {Gender.Female, ShelterType.Women},
                {Gender.Other, ShelterType.Family},
                {Gender.ClientDoesNotKnow, ShelterType.Family},
                {Gender.TransgenderFemaleToMale, ShelterType.LGBT},
                {Gender.TransgenderMaleToFemale, ShelterType.LGBT},
                {Gender.ClientRefused, ShelterType.Youth},
            };
    }
}