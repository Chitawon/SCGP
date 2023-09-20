using SCGP.Models.MasterData.UserModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class AuthorizeController : Controller
    {
       
        public IActionResult Index()
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

            return RedirectToAction("Index");
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
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

