using KarateDo.Domain.Entities.ClubEntities;
using System.Collections.Generic;

namespace KarateDo.Infrastructure.IRepositories
{
    public interface IClubRepository
    {
        List<Club> GetAllClubs();

        Club GetClubById(int clubId);

        void SaveClub(Club club);

        void DeleteClub(int clubId);
    }
}
