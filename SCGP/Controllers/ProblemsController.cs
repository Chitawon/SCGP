using Microsoft.AspNetCore.Mvc;
using SCGP.Models.MasterData.ListProblemModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class ProblemsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewModel = new ListProblemViewModel();
            var list = new List<Problem>();

            for (int i = 0; i < 5; i++)
            {
                var testProblem = new Problem();
                var array = Enum.GetValues(typeof(ProblemTypeEnum));
                Random random = new Random();
                testProblem.ProblemType = (ProblemTypeEnum)array.GetValue(random.Next(array.Length));
                testProblem.Description = "AC D:" + i;
                list.Add(testProblem);
            }

            viewModel.ListProblems = list;
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(ListProblemViewModel obj)
        {
            ModelState.Remove("ListProblems");

            if (!ModelState.IsValid)
            {
                return View(obj);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(ListProblemViewModel obj)
        {
            ModelState.Remove("ListProblems");

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
