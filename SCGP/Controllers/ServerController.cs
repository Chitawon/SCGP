using Microsoft.AspNetCore.Mvc;
using SCGP.Data;
using SCGP.Models.MasterData;

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
            //IEnumerable<Server> objServerList = _db.Servers.ToList();
            return View();
        }

    }
}

