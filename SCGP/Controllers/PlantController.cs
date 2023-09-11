using Microsoft.AspNetCore.Mvc;
using SCGP.Data;
using SCGP.Models.MasterData.PlantModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class PlantController : Controller
    {
        private readonly ApplicationDBContext _db;

        public PlantController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var viweModel = new PlantViewModel();
            /*viweModel.plants = _db.Plants.ToList();
            viweModel.servers = _db.Servers.ToList();*/
            return View(viweModel);
        }

        // Create Storage
        [HttpPost]
        public IActionResult Create(PlantViewModel obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }

            _db.Plants.Add(obj.submitPlant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(PlantViewModel obj) 
        {
            //_db.SaveChanges();
            return View();
        }

        public IActionResult Delete(PlantViewModel obj)
        {
            //_db.SaveChanges();
            return View();
        }
    }
}

