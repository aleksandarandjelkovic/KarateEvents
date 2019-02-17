using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KarateEvents.Models.CompetitorModel
{
    public class Competitor
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Ime i prezime")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "date")]
        [Display(Name = "Datum rođenja")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Uzrast")]
        public string Age { get; set; }
        [Display(Name = "Kategorija")]
        public string Category { get; set; }
        [Required]
        [Display(Name = "Pol")]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Klub")]
        public int ClubId { get; set; }

    }
}