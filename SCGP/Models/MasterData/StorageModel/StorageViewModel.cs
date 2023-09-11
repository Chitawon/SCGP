using SCGP.Models.MasterData.PlantModel;

namespace SCGP.Models.MasterData.StorageModel
{
    public class StorageViewModel
    {
        public IEnumerable<Storage> storages { get; set; }

        public Storage submitStorage { get; set; }

        public IEnumerable<Plant> plants { get; set; }
    }
}