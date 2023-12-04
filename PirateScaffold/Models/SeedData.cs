using Microsoft.EntityFrameworkCore;

namespace PirateScaffold.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PirateContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PirateContext>>()))
            {
                if (context == null || context.Pirates == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any Pirates.
                if (context.Pirates.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pirates.AddRange(
                    new Pirate
                    {
                        Name = "Monkey D. Luffy",
                        Epithet = "Mugiwara(Straw Hat) Luffy",
                        Bounty = 300000000,
                        Age = 19,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "StrawHat Pirates", Ship = "Thousand Sunny"},
                        }
                        
                    },
                    new Pirate
                    {
                        Name = "Roronoa Zoro",
                        Epithet = "Pirate Hunter",
                        Bounty = 1111000000,
                        Age = 21,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "StrawHat Pirates", Ship = "Thousand Sunny"},
                        }
                        
                    },
                    new Pirate
                    {
                        Name = "Black leg, Sanji",
                        Epithet = "Black leg",
                        Bounty = 1032000000,
                        Age = 21,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "StrawHat Pirates", Ship = "Thousand Sunny"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Cyborg, Franky",
                        Epithet = "Cyborg",
                        Bounty = 394000000,
                        Age = 36,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "StrawHat Pirates", Ship = "Thousand Sunny"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Brook",
                        Epithet = "Soul King",
                        Bounty = 383000000,
                        Age = 36,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "StrawHat Pirates", Ship = "Thousand Sunny"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Ussop",
                        Epithet = "SogeKing",
                        Bounty = 500000000,
                        Age = 19,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "StrawHat Pirates", Ship = "Thousand Sunny"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Nami",
                        Epithet = "Cat Burglar",
                        Bounty = 500000000,
                        Age = 19,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "StrawHat Pirates", Ship = "Thousand Sunny"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Tony Tony Chopper",
                        Epithet = "Cotton Candy Lover",
                        Bounty = 1000,
                        Age = 17,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "StrawHat Pirates", Ship = "Thousand Sunny"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Jinbe",
                        Epithet = "Knight of the Sea",
                        Bounty = 1100000000,
                        Age = 46,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "StrawHat Pirates", Ship = "Thousand Sunny"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Nico Robin",
                        Epithet = "Devil Child",
                        Bounty = 930000000,
                        Age = 30,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "StrawHat Pirates", Ship = "Thousand Sunny"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Shanks",
                        Epithet = "Red-Haired Shanks",
                        Bounty = 4048900000,
                        Age = 39,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Red Hair Pirates", Ship = "Red Force"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Yassopp",
                        Epithet = "Chaser",
                        Bounty = 1100000000,
                        Age = 47,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Red Hair Pirates", Ship = "Red Force"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Donquixote Doflamingo",
                        Epithet = "Heavenly Demon",
                        Bounty = 340000000,
                        Age = 41,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Donquixote Pirates", Ship = "Numancia Flamingo"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Trafalgar D. Water Law",
                        Epithet = "Surgeon of Death",
                        Bounty = 3000000000,
                        Age = 26,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Heart Pirates", Ship = "Polar Tang"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Edward Newgate",
                        Epithet = "The Strongest Man in the World",
                        Bounty = 5046000000,
                        Age = 72,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Whitebeard Pirates", Ship = "Moby Dick"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Portgas D. Ace",
                        Epithet = "Fire Fist Ace",
                        Bounty = 550000000,
                        Age = 20,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Whitebeard Pirates", Ship = "Moby Dick"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Marco",
                        Epithet = "Marco the Phoenix",
                        Bounty = 1374000000,
                        Age = 45,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Whitebeard Pirates", Ship = "Moby Dick"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Gol D. Roger",
                        Epithet = "Pirate King",
                        Bounty = 5564800000,
                        Age = 51,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Roger Pirates", Ship = "Oro Jackson"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Silvers Rayleigh",
                        Epithet = "Dark King",
                        Bounty = 0,
                        Age = 78,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Roger Pirates", Ship = "Oro Jackson"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Kozuki Oden",
                        Epithet = "Idiot Lord",
                        Bounty = 0,
                        Age = 39,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Whitebeard Pirates", Ship = "Moby Dick"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Kaidou",
                        Epithet = "King of the Beasts",
                        Bounty = 4611100000,
                        Age = 59,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Beast Pirates", Ship = "Mammoth"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Marshall D. Teach",
                        Epithet = "BlackBeard",
                        Bounty = 3996000000,
                        Age = 40,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Blackbeard Pirates", Ship = "Saber of Xebec"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Jesus Burgess",
                        Epithet = "Champion",
                        Bounty = 20000000,
                        Age = 29,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Blackbeard Pirates", Ship = "Saber of Xebec"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Alvida",
                        Epithet = "Iron Mace",
                        Bounty = 5000000,
                        Age = 27,
                        DevilFruit = false,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Cross Guild", Ship = "Big Top"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Boa Hancock",
                        Epithet = "Pirate Empress",
                        Bounty = 1659000000,
                        Age = 31,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Kuja Pirates", Ship = "Perfume Yuda"},
                        }

                    },
                    new Pirate
                    {
                        Name = "Buggy",
                        Epithet = "Buggy The Clown",
                        Bounty = 1111000000,
                        Age = 39,
                        DevilFruit = true,
                        PirateCrews = new List<PirateCrew>{
                            new PirateCrew {CrewName = "Cross Guild", Ship = "Big Top"},
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}