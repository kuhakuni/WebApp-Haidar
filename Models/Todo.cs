namespace WebApp.Models
{
	public class Todo
	{

		public string TodoId { get; set; }

		public string Day { get; set; }

		public DateTime TodayDate { get; set; }

		public string Note { get; set; }

		public int DetailCount { get; set; }

		public List<TodoDetail> TodoDetails { get; set; }

	}
}
