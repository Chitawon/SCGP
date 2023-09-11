using Microsoft.AspNetCore.Mvc;
using SCGP.Data;
using SCGP.Models.MasterData.ServerModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class ServerController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ServerController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var viweModel =  new ServerViewModel();
            viweModel.servers = _db.Servers.ToList();
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

            _db.Servers.Add(obj.submitServer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(ServerViewModel obj)
        {
            //_db.SaveChanges();
            return View();
        }

        public IActionResult Delete(Guid id)
        {
            //_db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

