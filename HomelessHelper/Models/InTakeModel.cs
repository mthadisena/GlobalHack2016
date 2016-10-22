using System;
using HomelessHelper.Core.Domain.Enum;

namespace HomelessHelper.Models
{
    public class InTakeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Race Race { get; set; }
        public bool Gender { get; set; }
        public VetStatus VetStatus { get; set; }
    }
