using System.ComponentModel.DataAnnotations;

namespace SCGP.Models.MasterData.ListProblemModel
{
    public class Problem
    {
        [Required]
        public int ProblemTypeId
        {
            get => (int)ProblemType;
            set => ProblemType = (ProblemTypeEnum)value;
        }

        [EnumDataType(typeof(ProblemTypeEnum))]
        public ProblemTypeEnum ProblemType { get; set; }
        public string Description { get; set; }
    }
}