using SCGP.Models.MasterData.ServerModel;

namespace SCGP.Models.MasterData.PlantModel
{
    public class PlantViewModel
    {
        public IEnumerable<Plant> plants { get; set; }

        public IEnumerable<Server> servers { get; set; }

        public Plant submitPlant { get; set; }
    }
}