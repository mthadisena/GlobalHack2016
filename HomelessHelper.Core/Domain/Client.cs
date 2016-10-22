namespace HomelessHelper.Core.Domain
{
    public class Client:Person
    {
        public string Condition { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public string Email { get; set; }
        public Shelter Shelter { get; set; }
    }
}