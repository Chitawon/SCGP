using SCGP.Models.MasterData.PlantModel;

namespace SCGP.Models.MasterData.StorageModel
{
    public class Storage
    {
        public Plant? Plant { get; set; }
        public string StorageLocation { get; set; }
        public string Description { get; set; }
    }
}