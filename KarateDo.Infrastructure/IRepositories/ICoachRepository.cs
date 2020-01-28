using KarateDo.Domain.Entities.CoachEntities;
using System.Collections.Generic;

namespace KarateDo.Infrastructure.IRepositories
{
    public interface ICoachRepository
    {
        List<Coach> GetAllCoaches();

        Coach GetCoachById(int coachId);

        void SaveCoach(Coach coach);

        void DeleteCoach(int coachId);
    }
}
