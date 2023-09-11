namespace SCGP.Models.MasterData.ServerModel
{
    public class ServerViewModel
    {
        public IEnumerable<Server> servers { get; set; }

        public Server submitServer { get; set; }
    }
}
