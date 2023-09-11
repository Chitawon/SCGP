using Microsoft.AspNetCore.Mvc;
using SCGP.Data;
using SCGP.Models.MasterData.Storage;

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
            var viweModel = new StorageViweModel();

            var testStorage_1 = new Storage();
            testStorage_1.StorageLocation = "okl";
            testStorage_1.Description = ";lkjhgfd";

            var testStorage_2 = new Storage();
            testStorage_2.StorageLocation = "popoik";
            testStorage_2.Description = "nhuhbnmkl";

            var storageList = new List<Storage>();
            storageList.Add(testStorage_1);
            storageList.Add(testStorage_2);

            IEnumerable<Storage> objStorageList = storageList;
            viweModel.storages = objStorageList;
            return View(viweModel);
        }

        // Create Storage
        [HttpPost]
        public IActionResult Create(StorageViweModel obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }

            _db.Storages.Add(obj.submitStorage);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(StorageViweModel obj)
        {
            if (!ModelState.IsValid)
            {
                //return View(obj);
            }


            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {

            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

