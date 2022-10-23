using Microsoft.AspNetCore.Mvc;
using TrainManagement.Web.Data;
using TrainManagement.Web.Models;

namespace TrainManagement.Web.Controllers
{
    public class TrainController : Controller
    {
        public readonly ApplicationDbContext _context;
        public TrainController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<TrainModel> trainList = _context.Trains.ToList();
            return View(trainList);
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

        public IActionResult TrainDelete(int? Id)
        {
            var _trainModel = _context.Trains.Find(Id);
            if (_trainModel == null)
            {
                return NotFound();
            }

            return View(_trainModel);
        }

        public IActionResult Delete(int? TrainId)
        {
            var _trainModel = _context.Trains.Find(TrainId);
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
