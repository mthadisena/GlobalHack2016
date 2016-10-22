using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.Domain.Enum;

namespace HomelessHelper.Core.Domain
{
    [Table("Client")]
    public class Client : Person
    {
        public Guid ClientId { get; set; }
        public long UserId { get; set; }

        public string SSN { get; set; }
        public SSNDataQuality SsnDataQuality { get; set; }

        public string Condition { get; set; }
        public string Description { get; set; }
        
        public NameQuality NameQuality { get; set; }
        public DateOfBirthType DateOfBirthType { get; set; }

        public Race Race { get; set; }
        public Ethnicity Ethnicity { get; set; }
        public VeteranStatus VeteranStatus { get; set; }
        public VetStatus VetStatus { get; set; }
        public List<WarService> WarServices { get; set; }
        public ClientStatus ClientStatus { get; set; }
        public DisablingConditions DisablingConditions { get; set; }
        public LivingSituation LivingSituation { get; set; }

        public Shelter Shelter { get; set; }
        public Bed Bed { get; set; }

        public string Skills { get; set; }
    }
}