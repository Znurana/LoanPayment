using System;
namespace LoanPayment
{
	public class Product
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; } 
		public float Price { get; set; }
		public int Stock { get; set; }
		public string Brand { get; set; }
		public int  CategoryId { get; set; }

		public Product()
		{
			this.Id = new Random().Next(2000, 3000);
		}

	}
}

