﻿using KarateDo.Domain.Entities.CoachEntities;
using KarateDo.Infrastructure.IRepositories;
using KarateDo.Infrastructure.IServices;
using System.Collections.Generic;

namespace KarateDo.Infrastructure.Services
{
    public class CoachService : ICoachService
    {
        private readonly ICoachRepository _coachRepository;

        public CoachService(ICoachRepository coachRepository)
        {
            _coachRepository = coachRepository;
        }

        public List<Coach> GetAllCoaches(string[] include = null)
        {
            return _coachRepository.GetAllCoaches(include);
        }

        public Coach GetCoachById(int coachId)
        {
            return _coachRepository.GetCoachById(coachId);
        }

        public void SaveCoach(Coach coach)
        {
            _coachRepository.SaveCoach(coach);
        }

        public void DeleteCoach(int coachId)
        {
            _coachRepository.DeleteCoach(coachId);
        }

        public void Dispose(bool disposing)
        {
            _coachRepository.Dispose(disposing);
        }
    }
}
