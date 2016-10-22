using System;

namespace HomelessHelper.Core.Infrastructure.Conventions
{
    public class LabelOverrideAttribute : Attribute
    {
        public string LabelName { get; private set; }

        public LabelOverrideAttribute(string labelName)
        {
            LabelName = labelName;
        }
    }
}