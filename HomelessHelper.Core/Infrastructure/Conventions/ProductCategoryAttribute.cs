using System;
using HomelessHelper.Core.Domain.Enum;

namespace HomelessHelper.Core.Infrastructure.Conventions
{
    public class ProductCategoryAttribute : Attribute
    {
        private readonly ResidenceHeader _residenceHeader;

        public ProductCategoryAttribute(ResidenceHeader residenceHeader)
        {
            _residenceHeader = residenceHeader;
        }

        public ResidenceHeader ResidenceHeader { get; set; }
    }
}