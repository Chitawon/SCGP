namespace SCGP.Models.MasterData.RoleManagement
{
    public class RoleMasterData
    {
        #region List
        public bool ListAuthorize { get; set; }
        public bool ListServer { get; set; }
        public bool ListPlant { get; set; }
        public bool ListStorage { get; set; }
        public bool ListProblems { get; set; }
        #endregion

        #region View
        public bool ViewDetailAuthorize { get; set; }
        public bool ViewDetailServer { get; set; }
        public bool ViewDetailPlant { get; set; }
        public bool ViewDetailStorage { get; set; }
        public bool ViewDetailProblems { get; set; }
        #endregion

        #region Create
        public bool CreateAuthorize { get; set; }
        public bool CreateServer { get; set; }
        public bool CreatePlant { get; set; }
        public bool CreateStorage { get; set; }
        public bool CreateListProblems { get; set; }
        #endregion

        #region Edit
        public bool EditAuthorize { get; set; }
        public bool EditServer { get; set; }
        public bool EditPlant { get; set; }
        public bool EditStorage { get; set; }
        public bool EditListProblems { get; set; }
        #endregion

        #region Delete
        public bool DeleteAuthorize { get; set; }
        public bool DeleteServer { get; set; }
        public bool DeletePlant { get; set; }
        public bool DeleteStorage { get; set; }
        public bool DeleteListProblems { get; set; }
        #endregion
    }
}
