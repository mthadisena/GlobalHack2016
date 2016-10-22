using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HomelessHelper.Core.Domain;

namespace HomelessHelper.Models
{
    public class SearchModel
    {
        public string SearchTerm { get; set; }
        public List<Client> Clients { get; set; }
    }
}