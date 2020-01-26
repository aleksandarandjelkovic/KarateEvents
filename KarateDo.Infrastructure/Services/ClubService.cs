using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Infrastructure.IRepositories;
using KarateDo.Infrastructure.IServices;

namespace KarateDo.Infrastructure.Services
{
    public class ClubService : IClubService
    {
        private IClubRepository _clubRepository { get; set; }

        public ClubService(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }

        public void SaveClub(Club club)
        {
            _clubRepository.SaveClub(club);
        }
    }
}
