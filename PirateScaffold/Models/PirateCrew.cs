using System.ComponentModel.DataAnnotations;

namespace PirateScaffold.Models
{
    public class PirateCrew
    {
        public int PirateCrewID {get; set;} //Primary key for PirateCrew class

        [Required]
        public string CrewName {get; set;} = string.Empty;

        public string Ship {get; set;} = string.Empty;

        [Display(Name = "Pirate")]
        [Required]
        public int PirateID {get; set;} //foreign Key linking PirateCrew and Pirate
        public Pirate? Pirate {get; set;}
    }
}