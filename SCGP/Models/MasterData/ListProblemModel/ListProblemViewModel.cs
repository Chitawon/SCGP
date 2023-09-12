namespace SCGP.Models.MasterData.ListProblemModel
{
	public class ListProblemViewModel
	{
		public IEnumerable<Problem> ListProblems { get; set; }

		public Problem SubmitProblem { get; set; }
	}
}