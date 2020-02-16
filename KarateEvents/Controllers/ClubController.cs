using KarateDo.Infrastructure;
using KarateDo.Infrastructure.IServices;
using KarateEvents.ViewModels.ClubViewModels;
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
            var clubs = _clubService.GetAllClubs();

            var vm = new ClubsListViewModel()
            {
                Clubs = clubs
            };

            return View(vm);
        }

        public ActionResult AddClub()
        {
            var vm = new AddEditClubViewModel();

            return View("AddEditClub", vm);
        }

        [HttpPost]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        public ActionResult SaveClub(AddEditClubViewModel clubViewModel)
        {
            if (ModelState.IsValid)
            {
                //_clubService.SaveClub(club);

                return RedirectToAction("Index", "Club");
            }

            var vm = new AddEditClubViewModel();
            return View("AddEditClub", vm);
        }

        public ActionResult EditClub(int clubId)
        {
            var club = _clubService.GetClubById(clubId);

            if (club == null)
            {
                return HttpNotFound();
            }

            var vm = new AddEditClubViewModel();

            return View("AddEditClub", vm);
        }

        public ActionResult DeleteClub(int clubId)
        {
            _clubService.DeleteClub(clubId);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }
    }
}