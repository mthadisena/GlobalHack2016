using System.ComponentModel.DataAnnotations.Schema;

namespace HomelessHelper.Core.Domain
{
    [Table("Client")]
    public class Client:Person
    {
        public string Condition { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public string Email { get; set; }
    }
}