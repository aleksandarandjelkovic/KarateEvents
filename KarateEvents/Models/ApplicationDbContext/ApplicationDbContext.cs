using System.Data.Entity;
using KarateEvents.Models.ClubModel;
using KarateEvents.Models.CompetitorModel;

namespace KarateEvents.Models.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Competitor> Competitors { get; set; }
    }
}