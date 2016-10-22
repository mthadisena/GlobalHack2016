using System;
using System.ComponentModel.DataAnnotations;

namespace HomelessHelper.Core.EntityFramework
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}