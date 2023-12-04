using Microsoft.EntityFrameworkCore;

namespace PirateScaffold.Models
{
    public class PirateContext : DbContext
    {
        public PirateContext (DbContextOptions<PirateContext> options)
            : base (options)
            {
            }
        
        public DbSet<Pirate> Pirates {get; set;} = default!;
        public DbSet<PirateCrew> PirateCrews {get; set;} = default!;
    }
}