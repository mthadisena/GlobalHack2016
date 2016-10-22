using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomelessHelper.Core.Domain
{
    [Table("Client")]
    public class Client:Person
    {
        public Guid ClientId { get; set; }
        public long UserId { get; set; }

        public string Condition { get; set; }
        public string Description { get; set; }
        public string Race { get; set; }
        public bool Veteran { get; set; }

        public bool Disabled { get; set; }

        public string Skills { get; set; }
        public string Email { get; set; }

        public Shelter Shelter { get; set; }
        public int BedNumber { get; set; }

        public ClientStatus ClientStatus { get; set; }
    }
}