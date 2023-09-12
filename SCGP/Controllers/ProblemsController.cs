using Microsoft.AspNetCore.Mvc;
using SCGP.Data;
using SCGP.Models.MasterData.ListProblemModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class ProblemsController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ProblemsController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
			var viewModel = new ListProblemViewModel();
            return View(viewModel);
        }

		[HttpPost]
		public IActionResult Create(ListProblemViewModel obj)
		{
            if (!ModelState.IsValid)
            {
                return View(obj);
            }

            return RedirectToAction("Index");
		}

		public IActionResult Edit(ListProblemViewModel obj)
		{
            if (!ModelState.IsValid)
            {
                return View(obj);
            }

            return RedirectToAction("Index");
		}

		public IActionResult Delete()
		{
			return View();
		}
	}
}

