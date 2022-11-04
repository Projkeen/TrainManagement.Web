using Microsoft.AspNetCore.Mvc;
using TrainManagement.Web.Data;
using TrainManagement.Web.Models;

namespace TrainManagement.Web.Controllers
{
    public class UserController : Controller
    {
        public readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login(string FirstName, string LastName, string Password)
        {
            ViewBag.LoginStatus = "";
            if (ModelState.IsValid)
            {
                var userCheck = _context.Users.FirstOrDefault(u => u.FirstName == FirstName && u.LastName == LastName && u.Password == Password);

                if (userCheck == null)
                {
                    ViewBag.LoginStatus = "User not registered";
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public IActionResult Registration(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(userModel);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
