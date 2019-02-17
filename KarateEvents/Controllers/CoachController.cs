using KarateEvents.Models.ApplicationDbContext;
using KarateEvents.Models.CoachModel;
using KarateEvents.ViewModels.CoachViewModel;
using System.Linq;
using System.Web.Mvc;

namespace KarateEvents.Controllers
{
    public class CoachController : Controller
    {
        private ApplicationDbContext _dbContext;

        public CoachController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Coach
        public ActionResult Index()
        {
            var coaches = _dbContext.Coaches.ToList();
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

            if (coach.Id == 0)
            {
                _dbContext.Coaches.Add(coach);
            }
            else
            {
                var coachInDb = _dbContext.Coaches.Single(x => x.Id == coach.Id);
                coachInDb.Name = coach.Name;
                coachInDb.DateOfBirth = coach.DateOfBirth;
                coachInDb.CoachTypeId = coach.CoachTypeId;
                coachInDb.GenderId = coach.GenderId;
                coachInDb.ClubId = coach.ClubId;
            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Coach");
        }

        public ActionResult EditCoach(int id)
        {
            var coach = _dbContext.Coaches.SingleOrDefault(x => x.Id == id);
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
        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }
    }
}