using KarateEvents.Models.ClubModel;
using KarateEvents.Models.CoachModel;
using KarateEvents.Models.CoachTypeModel;
using KarateEvents.Models.GenderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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