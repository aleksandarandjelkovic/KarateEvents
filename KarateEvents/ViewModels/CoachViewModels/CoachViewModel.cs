﻿using KarateEvents.Models.ClubModel;
using KarateEvents.Models.CoachModel;
using KarateEvents.Models.CoachTypeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarateEvents.ViewModels.CoachViewModel
{
    public class CoachViewModel
    {
        public List<Coach> Coaches { get; set; }
        public List<CoachType> CoachTypes { get; set; }
        public List<Club> Clubs { get; set; }
    }
}