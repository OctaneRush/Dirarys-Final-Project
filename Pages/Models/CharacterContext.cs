using Microsoft.EntityFrameworkCore;

namespace Dirarys_Final_Project.Models
{
    public class CharacterDbContext : DbContext
    {
        // Creates a session with the database.
        public CharacterDbContext (DbContextOptions<CharacterDbContext> options)
                : base(options)
                { 
                }
                // Collections of each object in the database.
                public DbSet<Character> Characters {get; set;}
                public DbSet<LandOfOrigin> LandOfOrigins {get; set;}
                public DbSet<Guild> Guilds {get; set;}
    }
}