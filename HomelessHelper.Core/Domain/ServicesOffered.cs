using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Domain
{
    public class ServicesOffered:Entity
    {
        public ServiceType ServiceType { get; set; }
        public Shelter Shelter { get; set; }
    }
}