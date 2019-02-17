using KarateEvents.Models.CategoryModel;
using KarateEvents.Models.ClubModel;
using KarateEvents.Models.CompetitorModel;
using System.Collections.Generic;

namespace KarateEvents.ViewModels.CompetitorViewModel
{
    public class CompetitorViewModel
    {
        public List<Competitor> Competitors { get; set; }
        public List<Category> Categories { get; set; }
        public List<Club> Clubs { get; set; }
    }
}