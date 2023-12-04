using System.ComponentModel.DataAnnotations;

namespace PirateScaffold.Models
{
    public class Pirate
    {
        public int PirateID {get; set;}

        [StringLength(60, MinimumLength = 2)]
        [Display(Name = "Pirates Name")]
        [Required]
        public string Name {get; set;} = string.Empty;

        public string Epithet {get; set;} = string.Empty;

        public int Age {get; set;}

        [Required]
        [DataType(DataType.Currency)]
        public long Bounty {get; set;}

        public bool DevilFruit {get; set;}

        public List<PirateCrew> PirateCrews {get; set;} = new List<PirateCrew>();
    }
}