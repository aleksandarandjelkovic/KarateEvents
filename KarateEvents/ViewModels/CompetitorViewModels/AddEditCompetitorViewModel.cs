using KarateDo.Domain.Entities.CategoryEntities;
using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Domain.Entities.GenderEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace KarateEvents.ViewModels.CompetitorViewModel
{
    public class AddEditCompetitorViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ime takmičara je obavezno")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Najmanje 5 karaktera")]
        [Display(Name = "Ime i prezime")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Datum rođenja takmičara je obavezan")]
        [Column(TypeName = "date")]
        [Display(Name = "Datum rođenja")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Kategorija je obavezna")]
        [Display(Name = "Kategorija")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Pol takmičara je obavezan")]
        [Display(Name = "Pol")]
        public int GenderId { get; set; }

        [Display(Name = "Klub")]
        public int ClubId { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
        public List<Club> Clubs { get; set; }
        public List<Gender> Genders { get; set; }
        public List<Category> Categories { get; set; }
    }
}