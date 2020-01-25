using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Domain.Entities.CoachEntities;
using System.Collections.Generic;

namespace KarateEvents.ViewModels.CoachViewModel
{
    public class CoachViewModel
    {
        public List<Coach> Coaches { get; set; }
        public List<CoachType> CoachTypes { get; set; }
        public List<Club> Clubs { get; set; }
    }
}