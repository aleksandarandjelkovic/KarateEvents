using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Domain.Entities.CoachEntities;
using KarateDo.Domain.Entities.GenderEntities;
using System.Collections.Generic;

namespace KarateEvents.ViewModels.CoachViewModel
{
    public class AddEditCoachViewModel
    {
        public Coach Coach { get; set; }
        public List<Club> Clubs { get; set; }
        public List<Gender> Genders { get; set; }
        public List<CoachType> Types { get; set; }

    }
}