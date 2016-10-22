using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Domain
{
    [Table("Bed")]
    public class Bed : Entity
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }

        public Shelter Shelter { get; set; }
    }
}