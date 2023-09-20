using Microsoft.AspNetCore.Mvc;
using SCGP.Models.MasterData.ServerModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class ServerController : Controller
    {
        public IActionResult Index()
        {
            var viweModel = new ServerViewModel();

            return View(viweModel);
        }

        // Create Storage
        [HttpPost]
        public IActionResult Create(ServerViewModel obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }


            return RedirectToAction("Index");
        }

        public IActionResult Edit(ServerViewModel obj)
        {
            return View();
        }

        public IActionResult Delete(Guid id)
        {
            //_db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

