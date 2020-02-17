using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Infrastructure.IRepositories;
using KarateDo.Infrastructure.IServices;
using System.Collections.Generic;

namespace KarateDo.Infrastructure.Services
{
    public class ClubService : IClubService
    {
        private IClubRepository _clubRepository { get; set; }

        public ClubService(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }

        public List<Club> GetAllClubs()
        {
            return _clubRepository.GetAllClubs();
        }

        public Club GetClubById(int clubId)
        {
            return _clubRepository.GetClubById(clubId);
        }

        public void SaveClub(Club club)
        {
            _clubRepository.SaveClub(club);
        }

        public void DeleteClub(int clubId)
        {
            _clubRepository.DeleteClub(clubId);
        }

        public void Dispose(bool disposing) 
        {
            _clubRepository.Dispose(disposing);
        }
    }
}
