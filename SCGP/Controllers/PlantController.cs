using Microsoft.AspNetCore.Mvc;
using SCGP.Models.MasterData.ListProblemModel;
using SCGP.Models.MasterData.PlantModel;
using SCGP.Models.MasterData.ServerModel;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class PlantController : Controller
    {


        // GET: /<controller>/
        public IActionResult Index()
        {
            var viweModel = new PlantViewModel();
            /*viweModel.plants = _db.Plants.ToList();
            viweModel.servers = _db.Servers.ToList();*/
            var list = new List<Server>();
            var listP = new List<Plant>();
            for (int i = 0; i < 5; i++)
            {
                var plant = new Plant();
                var server = new Server();
                server.ServerName = "AC" + i;
                plant.server = server;
                plant.PlantNO = "P" + i;
                plant.Location = "L :" + i;
                plant.Plant_Description = "Description" + i;
                list.Add(server);
                listP.Add(plant);
            }
            viweModel.servers = list;
            viweModel.plants = listP;
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

