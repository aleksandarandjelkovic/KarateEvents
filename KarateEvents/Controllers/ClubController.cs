using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Infrastructure;
using KarateDo.Infrastructure.IServices;
using KarateEvents.ViewModels.ClubViewModels;
using System.Linq;
using System.Web.Mvc;

namespace KarateEvents.Controllers
{
    public class ClubController : Controller
    {
        private ApplicationDbContext _dbContext;
        private readonly IClubService _clubService;

        public ClubController(IClubService clubService)
        {
            _dbContext = new ApplicationDbContext();
            _clubService = clubService;
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
                Club = new Club()
            };

            return View("AddEditClub", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveClub(Club club)
        {
            if (!ModelState.IsValid)
            {
                var vm = new AddEditClubViewModel()
                {
                    Club = new Club()
                };

                return View("AddEditClub", vm);
            }

            _clubService.SaveClub(club);

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

        public ActionResult DeleteClub(int id)
        {
            var club = _dbContext.Clubs.Single(x => x.Id == id);
            _dbContext.Clubs.Remove(club);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }
    }
}