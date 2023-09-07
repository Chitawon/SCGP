using Microsoft.AspNetCore.Mvc;
using SCGP.Data;
using SCGP.Models.MasterData;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class StorageController : Controller
    {
        private readonly ApplicationDBContext _db;

        public StorageController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //IEnumerable<Storage> objStorageList = _db.Storages.ToList();
            return View();
        }

        /*// Creat Storage
        [HttpPost]
        public IActionResult Index(Storage obj) 
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }

            _db.Storages.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            return PartialView("_StorageDeletePartial");
        }*/
    }
}

