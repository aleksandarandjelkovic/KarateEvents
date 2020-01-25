using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KarateEvents.Models.CompetitorModel
{
    public class Competitor
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

    }
}