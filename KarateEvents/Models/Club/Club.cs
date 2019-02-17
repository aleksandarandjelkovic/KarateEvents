using KarateEvents.Models.CompetitorModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KarateEvents.Models.ClubModel
{
    public class Club
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Naziv kluba")]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Vlasnik kluba")]
        public string Owner { get; set; }
        [Required]
        [StringLength(8)]
        [Display(Name = "Poreski identifikacioni broj (PIB)")]
        public string Pib { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Adresa (sedište) kluba")]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Grad")]
        public string City { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Kontakt telefon")]
        public string Phone { get; set; }
    }
}