using KarateDo.Domain.Entities.CoachEntities;
using KarateDo.Infrastructure.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace KarateDo.Infrastructure.Repositories
{
    public class CoachRepository : BaseRepository, ICoachRepository
    {
        public CoachRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public List<Coach> GetAllCoaches(string[] include = null)
        {
            return GetAll<Coach>(include).ToList();
        }

        public Coach GetCoachById(int coachId, string[] include = null)
        {
            return GetById<Coach>(coachId, include);
        }

        public void SaveCoach(Coach coach)
        {
            SaveOrUpdate(coach);
        }

        public void DeleteCoach(int coachId)
        {
            Delete<Coach>(coachId);
        }
    }
}
