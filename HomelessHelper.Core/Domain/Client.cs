using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.Infrastructure.Conventions;

namespace HomelessHelper.Core.Domain
{
    [Table("Client")]
    public class Client : Person
    {
        public Guid ClientId { get; set; }
        public long UserId { get; set; }
        public long? UUID { get; set; }

        public long HouseHoldId { get; set; }
        public string SSN { get; set; }
        public SSNDataQuality SsnDataQuality { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string DateOfBirthFormatted => DateOfBirth?.ToString("MM/dd/yyyy");
        public string Condition { get; set; }
        public string Description { get; set; }
        public bool Veteran { get; set; }

        public bool Disabled { get; set; }

        public string Skills { get; set; }
        public string Email { get; set; }
        public NameQuality NameQuality { get; set; }
        public List<Shelter> Shelters { get; set; }
        public DateOfBirthType DateOfBirthType { get; set; }

        public Race Race { get; set; }
        public Ethnicity Ethnicity { get; set; }
        public VeteranStatus VeteranStatus { get; set; }
        public VetStatus VetStatus { get; set; }
        public List<WarService> WarServices { get; set; } = new List<WarService>();
        public int BedNumber { get; set; }
        public ClientStatus ClientStatus { get; set; }
        public DisablingConditions DisablingConditions { get; set; }
        public LivingSituation LivingSituation { get; set; }
        public DestinationType Destination { get; set; }
        [Text]
        public string DestinationText { get; set; }
        public RelationshipToHeadOfHousehold HeadOfHousehold { get; set; }

        public Shelter Shelter { get; set; }
        public Bed Bed { get; set; }

        public HousingStatus HousingStatus { get; set; }
        public IncomeBenefits IncomeBenefits { get; set; }
    }
}
