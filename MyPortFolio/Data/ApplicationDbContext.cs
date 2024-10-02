using Microsoft.EntityFrameworkCore;
using MyPortFolio.Models;

namespace MyPortFolio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Messages> Messages_TBL { get; set; }

        public DbSet<Education> Education_TBL { get; set; }

        public DbSet<Experience> Experience_TBL { get; set; }

        public DbSet<Projects> Project_TBL { get; set; }

        public DbSet<Skills> Skill_TBL { get; set; }

    }
}
