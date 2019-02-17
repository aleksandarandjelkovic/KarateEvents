using System.Data.Entity;
using KarateEvents.Models.ClubModel;
using KarateEvents.Models.CoachModel;
using KarateEvents.Models.CoachTypeModel;
using KarateEvents.Models.CompetitorModel;
using KarateEvents.Models.GenderModel;

namespace KarateEvents.Models.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<CoachType> CoachTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }

    }
}