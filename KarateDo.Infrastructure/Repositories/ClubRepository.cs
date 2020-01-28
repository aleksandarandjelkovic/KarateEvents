using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Infrastructure.IRepositories;
using System.Collections.Generic;
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

        public List<Club> GetAllClubs()
        {
            return _dbContext.Clubs.ToList();
        }

        public Club GetClubById(int clubId)
        {
            return _dbContext.Clubs.SingleOrDefault(x => x.Id == clubId);
        }

        public void SaveClub(Club club)
        {
            if (club.Id == 0)
            {
                _dbContext.Clubs.Add(club);
            }
            else
            {
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

        public void DeleteClub(int clubId)
        {
            var club = _dbContext.Clubs.Single(x => x.Id == clubId);
            _dbContext.Clubs.Remove(club);
            _dbContext.SaveChanges();
        }
    }
}
