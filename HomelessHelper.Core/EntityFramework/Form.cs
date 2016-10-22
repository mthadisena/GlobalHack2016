using System.ComponentModel.DataAnnotations.Schema;

namespace HomelessHelper.Core.EntityFramework
{
    [Table("Form")]
    public class Form : Entity
    {
        public string FirstName { get; set; }   
    }
}