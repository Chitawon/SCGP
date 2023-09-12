using Microsoft.AspNetCore.Mvc;
using SCGP.Data;
using SCGP.Models.MasterData.UserModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class AuthorizeController : Controller
    {
        private readonly ApplicationDBContext _db;

        public AuthorizeController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(User user)
        {
            return View(user);
        }

        public IActionResult EditUser(User user)
        {

            return RedirectToAction("Index");
        }
    }
}

