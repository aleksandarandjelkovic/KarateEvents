using KarateDo.Domain.Entities.ClubEntities;
using System.Collections.Generic;

namespace KarateDo.Infrastructure.IRepositories
{
    public interface IClubRepository : IBaseRepository
    {
        List<Club> GetAllClubs(string[] include = null);

        Club GetClubById(int clubId, string[] include = null);

        void SaveClub(Club club);

        void DeleteClub(int clubId);
    }
}
