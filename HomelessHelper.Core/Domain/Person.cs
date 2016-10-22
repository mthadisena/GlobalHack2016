using System;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Domain
{
    public class Person : Entity
    {
        public string SSN { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}