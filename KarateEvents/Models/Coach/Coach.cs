using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KarateEvents.Models.CoachModel
{
    public class Coach
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
        [Required]
        [Display(Name = "Pol")]
        public int GenderId { get; set; }
        [Required]
        [Display(Name = "Tip")]
        public int CoachTypeId { get; set; }
        [Display(Name = "Klub")]
        public int ClubId { get; set; }
    }
}