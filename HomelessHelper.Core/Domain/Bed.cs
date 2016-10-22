using System;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Domain
{
    [Table("Client")]
    public class Bed : Entity
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
       
    }
}