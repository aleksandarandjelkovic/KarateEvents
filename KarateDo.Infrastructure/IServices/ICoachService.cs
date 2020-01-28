using KarateDo.Domain.Entities.CoachEntities;
using System.Collections.Generic;

namespace KarateDo.Infrastructure.IServices
{
    public interface ICoachService
    {
        List<Coach> GetAllCoaches();

        Coach GetCoachById(int coachId);

        void SaveCoach(Coach coach);

        void DeleteCoach(int coachId);
    }
}
