using Microsoft.AspNetCore.Mvc;
using TrainManagement.Web.Data;
using TrainManagement.Web.Models;

namespace TrainManagement.Web.Controllers
{
    public class TrainController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TrainController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string SearchString)
        {
            //IEnumerable<TrainModel> trainList = _context.Trains.ToList();
            //return View(trainList);
            ViewData["Filter"] = SearchString;
            var train = from t in _context.Trains select t;
            if (!String.IsNullOrEmpty(SearchString))
            {
                train = train.Where(t => t.FinalDestination.Contains(SearchString) || t.DepartureStation.Contains(SearchString));               
            }           

            return View(train);
        }

        public IActionResult Add(TrainModel trainModel)
        {
            if (ModelState.IsValid)
            {
                _context.Trains.Add(trainModel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult TrainEdit(int? Id)
        {
            var _trainModel = _context.Trains.Find(Id);
            if (_trainModel == null)
            {
                return NotFound();
            }

            return View(_trainModel);
        }

        [HttpPost]
        public IActionResult Edit(TrainModel trainModel)
        {
            if (ModelState.IsValid)
            {
                _context.Trains.Update(trainModel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
                
        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int? Id)
        {
            var _trainModel = _context.Trains.Find(Id);
            if (_trainModel == null)
            {
                return NotFound();
            }
            _context.Trains.Remove(_trainModel);
            _context.SaveChanges();            
            return RedirectToAction("Index");
                        
        }
        public IActionResult TrainCalculate(int? Id)
        {
            var _trainModel = _context.Trains.Find(Id);
            if (_trainModel == null)
            {
                return NotFound();
            }

            return View(_trainModel);
        }
    }
}
