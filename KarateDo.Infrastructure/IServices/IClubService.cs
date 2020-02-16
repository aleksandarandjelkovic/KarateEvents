using KarateDo.Domain.Entities.ClubEntities;
using System.Collections.Generic;

namespace KarateDo.Infrastructure.IServices
{
    public interface IClubService
    {
        List<Club> GetAllClubs();

        Club GetClubById(int clubId);

        void SaveClub(Club club);

        void DeleteClub(int clubId);

        void Dispose(bool disposing);

    }
}
