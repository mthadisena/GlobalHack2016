using System;
using HomelessHelper.Core.Domain.Enum;

namespace HomelessHelper.Core.Infrastructure.Conventions
{
    public class ResidencialCategoryAttribute : Attribute
    {
        private readonly ResidenceStatusCategory _residenceStatusCategory;

        public ResidencialCategoryAttribute(ResidenceStatusCategory residenceStatusCategory)
        {
            _residenceStatusCategory = residenceStatusCategory;
        }

        public ResidenceStatusCategory ResidenceStatusCategory { get; set; }
    }
}