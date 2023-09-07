using Microsoft.AspNetCore.Mvc;
using SCGP.Data;

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
            //IEnumerable<Plant> objPLaneList = _db.Plants.ToList();
            return View();
        }

    }
}

