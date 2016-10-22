using System.ComponentModel.DataAnnotations;

namespace HomelessHelper.Models
{
    public class SearchModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string SSN { get; set; }
    }
}