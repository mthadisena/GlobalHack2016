using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Domain
{
    public abstract class BasePerson : Entity
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
    }
}