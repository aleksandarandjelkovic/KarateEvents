using KarateDo.Domain.Entities.CategoryEntities;
using KarateDo.Domain.Entities.CoachEntities;
using KarateDo.Domain.Entities.GenderEntities;

namespace KarateEvents.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<KarateDo.Infrastructure.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KarateDo.Infrastructure.ApplicationDbContext context)
        {
            context.Categories.AddOrUpdate(x => x.Id,
                new Category() { Id = 1, CategoryName = "Borbe -60kg" },
                new Category() { Id = 2, CategoryName = "Borbe -67kg" },
                new Category() { Id = 3, CategoryName = "Borbe -75kg" },
                new Category() { Id = 4, CategoryName = "Borbe -84kg" },
                new Category() { Id = 5, CategoryName = "Borbe +84kg" },
                new Category() { Id = 6, CategoryName = "Kate Muskarci" },
                new Category() { Id = 7, CategoryName = "Borbe -50kg" },
                new Category() { Id = 8, CategoryName = "Borbe -55kg" },
                new Category() { Id = 9, CategoryName = "Borbe -61kg" },
                new Category() { Id = 10, CategoryName = "Borbe -68kg" },
                new Category() { Id = 11, CategoryName = "Borbe +68kg" },
                new Category() { Id = 12, CategoryName = "Kate Zene" }
            );

            context.CoachTypes.AddOrUpdate(x => x.Id,
                new CoachType() { Id = 1, CoachTypeName = "Rucna tehnika" },
                new CoachType() { Id = 2, CoachTypeName = "Nozna tehnika" },
                new CoachType() { Id = 3, CoachTypeName = "Kombinovani" },
                new CoachType() { Id = 4, CoachTypeName = "Taktika" },
                new CoachType() { Id = 5, CoachTypeName = "Fizicka priprema" },
                new CoachType() { Id = 6, CoachTypeName = "Opsti" }
            );

            context.Genders.AddOrUpdate(x => x.Id,
                new Gender() { Id = 1, GenderName = "Muski" },
                new Gender() { Id = 2, GenderName = "Zenski" }
            );
        }
    }
}