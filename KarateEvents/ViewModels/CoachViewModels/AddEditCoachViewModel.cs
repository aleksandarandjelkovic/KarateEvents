using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Domain.Entities.CoachEntities;
using KarateDo.Domain.Entities.GenderEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace KarateEvents.ViewModels.CoachViewModel
{
    public class AddEditCoachViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ime trenera je obavezno")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Najmanje 5 karaktera")]
        [Display(Name = "Ime i prezime")]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Datum rođenja")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Pol")]
        public int GenderId { get; set; }

        [Required(ErrorMessage = "Tip trenera je obavezan")]
        [Display(Name = "Tip trenera")]
        public int CoachTypeId { get; set; }

        [Display(Name = "Klub")]
        public int ClubId { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public List<Club> Clubs { get; set; }
        public List<Gender> Genders { get; set; }
        public List<CoachType> Types { get; set; }

    }
}