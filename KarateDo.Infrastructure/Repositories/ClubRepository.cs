using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Infrastructure.IRepositories;
using System.Linq;

namespace KarateDo.Infrastructure.Repositories
{
    public class ClubRepository : IClubRepository
    {
        public ApplicationDbContext _dbContext;

        public ClubRepository()
        {
            _dbContext = new ApplicationDbContext();
        }

        public void SaveClub(Club club)
        {
            if (club.Id == 0)
            {
                _dbContext.Clubs.Add(club);
            }
            else {
                var clubInDb = _dbContext.Clubs.Single(x => x.Id == club.Id);
                clubInDb.Name = club.Name;
                clubInDb.Owner = club.Owner;
                clubInDb.Phone = club.Phone;
                clubInDb.Pib = club.Pib;
                clubInDb.Address = club.Address;
                clubInDb.City = club.City;
            }

            _dbContext.SaveChanges();
        }
    }
}
