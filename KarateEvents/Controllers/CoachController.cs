using KarateDo.CMS.Mappers.CoachMappers;
using KarateDo.Domain.Entities.CoachEntities;
using KarateDo.Infrastructure;
using KarateDo.Infrastructure.IServices;
using KarateEvents.ViewModels.CoachViewModels;
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

        public ActionResult Index()
        {
            string[] include = new string[] { "CoachType", "Club" };
            var coaches = _coachService.GetAllCoaches(include);

            var mapper = new CoachListViewModelMapper();
            var vm = mapper.From(coaches);

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
        [ValidateInput(true)]
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
            _coachService.Dispose(disposing);
        }
    }
}