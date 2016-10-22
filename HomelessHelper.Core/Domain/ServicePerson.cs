using System.ComponentModel.DataAnnotations.Schema;

namespace HomelessHelper.Core.Domain
{
    [Table("ServicePerson")]
    public class ServicePerson : BasePerson
    {
        public long Id { get; set; }
        public string Role { get; set; }
    }
}