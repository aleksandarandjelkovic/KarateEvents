using KarateDo.Domain.Entities.CoachEntities;
using System.Collections.Generic;

namespace KarateDo.Infrastructure.IServices
{
    public interface ICoachService
    {
        List<Coach> GetAllCoaches(string[] include = null);

        Coach GetCoachById(int coachId);

        void SaveCoach(Coach coach);

        void DeleteCoach(int coachId);

        void Dispose(bool disposing);
    }
}
