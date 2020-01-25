using KarateDo.Domain.Entities.CategoryEntities;
using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Domain.Entities.CompetitorEntities;
using KarateDo.Domain.Entities.GenderEntities;
using System.Collections.Generic;

namespace KarateEvents.ViewModels.CompetitorViewModel
{
    public class AddEditCompetitorViewModel
    {
        public Competitor Competitor { get; set; }
        public List<Club> Clubs { get; set; }
        public List<Gender> Genders { get; set; }
        public List<Category> Categories { get; set; }
    }
}