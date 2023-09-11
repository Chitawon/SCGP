using SCGP.Models.MasterData.ServerModel;
namespace SCGP.Models.MasterData.PlantModel
{
    public class Plant
    {
        public Server server { get; set; }
        public string PlantNO { get; set; }
        public string Location { get; set; }
        public string Plant_Description { get; set; }
    }
}