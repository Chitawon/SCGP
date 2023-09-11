namespace SCGP.Models.MasterData.Storage
{
    public class StorageViweModel
    {
        public IEnumerable<Storage> storages { get; set; }

        public Storage submitStorage { get; set; }

        public IEnumerable<Plant> plants { get; set; }
    }
}
