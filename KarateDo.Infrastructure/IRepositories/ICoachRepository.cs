using KarateDo.Domain.Entities.CoachEntities;
using System.Collections.Generic;

namespace KarateDo.Infrastructure.IRepositories
{
    public interface ICoachRepository : IBaseRepository
    {
        List<Coach> GetAllCoaches(string[] include = null);

        Coach GetCoachById(int coachId, string[] include = null);

        void SaveCoach(Coach coach);

        void DeleteCoach(int coachId);
    }
}
