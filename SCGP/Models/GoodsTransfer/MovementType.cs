namespace SCGP.Models.GoodsTransfer
{
    static class MovementType
    {
        public static Dictionary<string, string> Movements { get; set; }

        static MovementType()
        {
            Movements = new Dictionary<string, string>
            {
                { "101", "101" },
                { "102", "102" },
                { "521", "521" },
                { "522", "522" },
                { "201", "201" },
                { "202", "202" },
                { "909", "909" },
                { "910", "910" },
                { "301", "301" },
                { "302", "302" },
                { "309", "309" },
                { "310", "310" },
                { "311", "311" },
                { "312", "312" },
                { "321", "321" },
                { "322", "322" },
                { "323", "323" },
                { "324", "324" },
                { "343", "343" },
                { "344", "344" },
                { "321 QI to UR", "321qi" },
            };
        }
    }
}
