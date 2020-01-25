using KarateDo.Domain.Entities.ClubEntities;

namespace KarateDo.Infrastructure.IRepositories
{
    public interface IClubRepository
    {
        void SaveClub(Club club);
    }
}
