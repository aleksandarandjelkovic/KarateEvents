﻿using KarateEvents.Models.ApplicationDbContext;
using KarateEvents.Models.ClubModel;
using KarateEvents.ViewModels.ClubViewModels;
using System.Linq;
using System.Web.Mvc;

namespace KarateEvents.Controllers
{
    public class ClubController : Controller
    {
        private ApplicationDbContext _dbContext;

        public ClubController()
        {
            _dbContext = new ApplicationDbContext();
        }
        
        public ActionResult Index()
        {
            var clubs = _dbContext.Clubs.ToList();

            var vm = new ClubViewModel()
            {
                Clubs = clubs
            };

            return View(vm);
        }

        public ActionResult AddClub()
        {
            var vm = new AddEditClubViewModel()
            {
                
            };

            return View("AddEditClub", vm);
        }

        [HttpPost]
        public ActionResult SaveClub(Club club)
        {
            if (!ModelState.IsValid)
            {
                var vm = new AddEditClubViewModel()
                {

                };

                return View("AddEditClub", vm);
            }

            if (club.Id == 0)
            {
                _dbContext.Clubs.Add(club);
            }
            else
            {
                var clubInDb = _dbContext.Clubs.Single(x => x.Id == club.Id);
                clubInDb.Name = club.Name;
                clubInDb.Owner = club.Owner;
                clubInDb.Phone = club.Phone;
                clubInDb.Pib = club.Pib;
                clubInDb.Address = club.Address;
                clubInDb.City = club.City;
            }


            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Club");
        }

        public ActionResult EditClub(int id)
        {
            var club = _dbContext.Clubs.SingleOrDefault(x => x.Id == id);

            if (club == null)
            {
                return HttpNotFound();
            }

            var vm = new AddEditClubViewModel
            {
                Club = club,
            };

            return View("AddEditClub", vm);
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }
    }
}