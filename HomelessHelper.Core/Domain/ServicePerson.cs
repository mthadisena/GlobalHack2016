using System.ComponentModel.DataAnnotations.Schema;

namespace HomelessHelper.Core.Domain
{
    [Table("ServicePerson")]
    public class ServicePerson : Person
    {
        public string Role { get; set; }
    }
}