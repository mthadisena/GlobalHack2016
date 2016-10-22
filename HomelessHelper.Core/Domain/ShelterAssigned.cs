using System;

namespace HomelessHelper.Core.Domain
{
    public class ShelterAssigned
    {
        public Client Client { get; set; }
        public Shelter Shelter { get; set; }
        public Bed Bed { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
        
    }
}