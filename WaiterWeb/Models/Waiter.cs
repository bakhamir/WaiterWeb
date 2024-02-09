namespace WaiterWeb.Models
{
	public class waiter
	{
		public int id { get; set; }
		public string name { get; set; }

	}
	public class diningtable
	{
		public int id { get; set; }
		public int waiterid { get; set; }
	}
	public class dishes
	{
		public int id { get; set; }
		public string name { get; set; }
		public int price { get; set; }

	}
	public class orders
	{
		public int id { get; set; }
		public bool status { get; set; }
		public int waiterid { get; set; }

	}



}
