using DndCharacterCreation.Models;
using Microsoft.EntityFrameworkCore;

namespace DndCharacterCreation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AppUser>? AppUsers { get; set; }  
        public DbSet<Character>? Characters { get; set; }

    }
}
