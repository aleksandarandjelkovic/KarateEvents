using KarateDo.Domain.Entities.CoachEntities;
using KarateDo.Infrastructure;
using KarateDo.Infrastructure.IServices;
using KarateEvents.ViewModels.CoachViewModel;
using System.Linq;
using System.Web.Mvc;

namespace KarateEvents.Controllers
{
    public class CoachController : Controller
    {
        private ApplicationDbContext _dbContext;
        private readonly ICoachService _coachService;

        public CoachController(ICoachService coachService)
        {
            _dbContext = new ApplicationDbContext();
            _coachService = coachService;
        }
        // GET: Coach
        public ActionResult Index()
        {
            var coaches = _coachService.GetAllCoaches();
            var coachTypes = _dbContext.CoachTypes.ToList();
            var clubs = _dbContext.Clubs.ToList();

            var vm = new CoachViewModel()
            {
                Coaches = coaches,
                CoachTypes = coachTypes,
                Clubs = clubs
            };

            return View(vm);
        }

        public ActionResult AddCoach()
        {
            var clubs = _dbContext.Clubs.ToList();
            var genders = _dbContext.Genders.ToList();
            var types = _dbContext.CoachTypes.ToList();

            var vm = new AddEditCoachViewModel()
            {
                Clubs = clubs,
                Genders = genders,
                Types = types
            };

            return View("AddEditCoach", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveCoach(Coach coach)
        {
            if (!ModelState.IsValid) {
                var clubs = _dbContext.Clubs.ToList();
                var genders = _dbContext.Genders.ToList();
                var types = _dbContext.CoachTypes.ToList();

                var vm = new AddEditCoachViewModel()
                {
                    Clubs = clubs,
                    Genders = genders,
                    Types = types
                };

                return View("AddEditCoach", vm);
            }

            _coachService.SaveCoach(coach);

            return RedirectToAction("Index", "Coach");
        }

        public ActionResult EditCoach(int coachId)
        {
            var coach = _coachService.GetCoachById(coachId);
            var clubs = _dbContext.Clubs.ToList();
            var genders = _dbContext.Genders.ToList();
            var types = _dbContext.CoachTypes.ToList();

            if (coach == null)
            {
                return HttpNotFound();
            }

            var vm = new AddEditCoachViewModel
            {
                Coach = coach,
                Clubs = clubs,
                Genders = genders,
                Types = types
            };

            return View("AddEditCoach", vm);
        }

        public ActionResult DeleteCoach(int coachId)
        {
            _coachService.DeleteCoach(coachId);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }
    }
}