using KarateDo.Domain.Entities.CategoryEntities;
using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Domain.Entities.CompetitorEntities;
using System.Collections.Generic;

namespace KarateEvents.ViewModels.CompetitorViewModel
{
    public class CompetitorsListViewModel
    {
        public List<Competitor> Competitors { get; set; }
        public List<Category> Categories { get; set; }
        public List<Club> Clubs { get; set; }
    }
}