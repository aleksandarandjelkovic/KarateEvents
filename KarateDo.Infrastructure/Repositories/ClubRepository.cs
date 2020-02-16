using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Infrastructure.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace KarateDo.Infrastructure.Repositories
{
    public class ClubRepository : BaseRepository, IClubRepository
    {
        public ClubRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            
        }

        public List<Club> GetAllClubs(string[] include = null)
        {
            return GetAll<Club>(include).ToList();
        }

        public Club GetClubById(int clubId, string[] include = null)
        {
            return GetById<Club>(clubId, include);
        }

        public void SaveClub(Club club)
        {
            SaveOrUpdate(club);
        }

        public void DeleteClub(int clubId)
        {
            Delete<Club>(clubId);
        }
    }
}
