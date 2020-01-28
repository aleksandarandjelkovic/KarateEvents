using KarateDo.Domain.Entities.CoachEntities;
using KarateDo.Infrastructure.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace KarateDo.Infrastructure.Repositories
{
    public class CoachRepository : ICoachRepository
    {
        public ApplicationDbContext _dbContext;

        public CoachRepository()
        {
            _dbContext = new ApplicationDbContext();
        }

        public List<Coach> GetAllCoaches()
        {
            return _dbContext.Coaches.ToList();
        }

        public Coach GetCoachById(int coachId)
        {
            return _dbContext.Coaches.FirstOrDefault(x => x.Id == coachId);
        }

        public void SaveCoach(Coach coach)
        {
            if (coach.Id == 0)
            {
                _dbContext.Coaches.Add(coach);
            }
            else
            {
                var coachInDb = _dbContext.Coaches.Single(x => x.Id == coach.Id);
                coachInDb.Name = coach.Name;
                coachInDb.DateOfBirth = coach.DateOfBirth;
                coachInDb.CoachTypeId = coach.CoachTypeId;
                coachInDb.GenderId = coach.GenderId;
                coachInDb.ClubId = coach.ClubId;
            }

            _dbContext.SaveChanges();
        }

        public void DeleteCoach(int coachId)
        {
            var coach = _dbContext.Coaches.Single(x => x.Id == coachId);
            _dbContext.Coaches.Remove(coach);
            _dbContext.SaveChanges();
        }
    }
}
