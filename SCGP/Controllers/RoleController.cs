using Microsoft.AspNetCore.Mvc;
using SCGP.Data;
using SCGP.Models.MasterData.RoleManagementModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class RoleController : Controller
    {
        private readonly ApplicationDBContext _db;

        public RoleController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //IEnumerable<Role> viewModel = _db.Roles.ToList();

            return View();
        }

        public IActionResult Detail(Role role)
        {
            return View(role);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Create(Role role)
        {
            _db.Roles.Add(role);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Role role)
        {
            return View(role);
        }

		public IActionResult EditRole(Role role)
		{
            return RedirectToAction("Index");
        }
	}
}
