using Microsoft.AspNetCore.Mvc;
using SCGP.Models.MasterData.StorageModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class StorageController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            var viweModel = new StorageViewModel();
            //viweModel.storages = _db.Storages.ToList();
            return View(viweModel);
        }

        // Create Storage
        [HttpPost]
        public IActionResult Create(StorageViewModel obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(StorageViewModel obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {

            //_db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

