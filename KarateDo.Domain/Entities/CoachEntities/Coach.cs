using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KarateDo.Domain.Entities.CoachEntities
{
    public class Coach
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
    }
}
