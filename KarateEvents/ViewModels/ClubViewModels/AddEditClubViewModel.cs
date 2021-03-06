﻿using System;
using System.ComponentModel.DataAnnotations;

namespace KarateEvents.ViewModels.ClubViewModels
{
    public class AddEditClubViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Naziv kluba je obavezan")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Najmanje 3 karaktera")]
        [Display(Name = "Naziv kluba")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Ime vlasnika je obavezno")]
        [StringLength(50)]
        [Display(Name = "Vlasnik kluba")]
        public string Owner { get; set; }
        [Required(ErrorMessage = "Pib broj je obavezan")]
        [StringLength(8)]
        [Display(Name = "Poreski identifikacioni broj (PIB)")]
        public string Pib { get; set; }
        [Required(ErrorMessage = "Adresa kluba je obavezna")]
        [StringLength(100)]
        [Display(Name = "Adresa (sedište) kluba")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Naziv grada je obavezan")]
        [StringLength(50)]
        [Display(Name = "Grad")]
        public string City { get; set; }
        [Required(ErrorMessage = "Broj telefona je obavezan")]
        [StringLength(50)]
        [Display(Name = "Kontakt telefon")]
        public string Phone { get; set; }

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}