using KarateEvents.Models.ClubModel;
using KarateEvents.Models.CompetitorModel;
using KarateEvents.Models.GenderModel;
using System.Collections.Generic;

namespace KarateEvents.ViewModels.CompetitorViewModel
{
    public class AddEditCompetitorViewModel
    {
        public Competitor Competitor { get; set; }
        public List<Club> Clubs { get; set; }
        public List<Gender> Genders { get; set; }

    }
}