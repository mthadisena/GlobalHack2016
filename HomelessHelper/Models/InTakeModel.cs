using System;

namespace HomelessHelper.Models
{
    public class InTakeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Race Race { get; set; }
        public bool Gender { get; set; }
        public VetStatus VetStatus { get; set; }


    }
}

public enum Race
{
    AmericanIndian,
    Asian,
    Black,
    HawaiiSouthPacificIslander,
    White,
    Other
}

public class VetStatus
{
    public bool IsVet { get; set; }
    public DateTime YearEnteredService { get; set; }
    public DateTime YearLeftService { get; set; }
    
    
}

public enum WarServedIn
{
    WorldWar2,
    KoreanWar,
    VietnamWar,
    DesertStorm,
    AfghanistanOEF,
    IraqOIF,
    OtherTheater
}

public enum MilitaryBranch
{
    Army,
    AirForce,
    Marines,
    Navy
}

public enum DischargeStatus
{
    Honorable,
    Dishonorable
}

