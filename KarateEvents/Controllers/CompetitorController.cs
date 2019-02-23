using KarateEvents.Models.ApplicationDbContext;
using KarateEvents.Models.CompetitorModel;
using KarateEvents.ViewModels.CompetitorViewModel;
using System.Linq;
using System.Web.Mvc;

namespace KarateEvents.Controllers
{
    public class CompetitorController : Controller
    {
        private ApplicationDbContext _dbContext;

        public CompetitorController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var competitors = _dbContext.Competitors.ToList();
            var categories = _dbContext.Categories.ToList();
            var clubs = _dbContext.Clubs.ToList();

            var vm = new CompetitorViewModel()
            {
                Competitors = competitors,
                Categories = categories,
                Clubs = clubs
            };

            return View(vm);
        }

        public ActionResult AddCompetitor()
        {
            var clubs = _dbContext.Clubs.ToList();
            var genders = _dbContext.Genders.ToList();
            var categories = _dbContext.Categories.ToList();

            var vm = new AddEditCompetitorViewModel()
            {
                Clubs = clubs,
                Genders = genders,
                Categories = categories
            };

            return View("AddEditCompetitor", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveCompetitor(Competitor competitor)
        {
            if (!ModelState.IsValid)
            {
                var clubs = _dbContext.Clubs.ToList();
                var genders = _dbContext.Genders.ToList();
                var categories = _dbContext.Categories.ToList();

                var vm = new AddEditCompetitorViewModel()
                {
                    Clubs = clubs,
                    Genders = genders,
                    Categories = categories
                };
            }

            if (competitor.Id == 0)
            {
                _dbContext.Competitors.Add(competitor);
            }
            else
            {
                var competitorInDb = _dbContext.Competitors.Single(x => x.Id == competitor.Id);
                competitorInDb.Name = competitor.Name;
                competitorInDb.CategoryId = competitor.CategoryId;
                competitorInDb.DateOfBirth = competitor.DateOfBirth;
                competitorInDb.GenderId = competitor.GenderId;
                competitorInDb.ClubId = competitor.ClubId;
            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Competitor");
        }

        public ActionResult EditCompetitor(int id)
        {
            var competitor = _dbContext.Competitors.SingleOrDefault(x => x.Id == id);
            var clubs = _dbContext.Clubs.ToList();
            var genders = _dbContext.Genders.ToList();
            var categories = _dbContext.Categories.ToList();

            if (competitor == null)
            {
                return HttpNotFound();
            }

            var vm = new AddEditCompetitorViewModel
            {
                Competitor = competitor,
                Clubs = clubs,
                Genders = genders,
                Categories = categories
            };

            return View("AddEditCompetitor", vm);
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }
    }
}