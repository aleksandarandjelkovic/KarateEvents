using KarateDo.Domain.Entities.CategoryEntities;
using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Domain.Entities.CoachEntities;
using KarateDo.Domain.Entities.CompetitorEntities;
using KarateDo.Domain.Entities.GenderEntities;
using System.Data.Entity;

namespace KarateDo.Infrastructure.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<CoachType> CoachTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
