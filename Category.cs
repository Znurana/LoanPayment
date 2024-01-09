using System;
namespace LoanPayment
{
	public  class Category
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public List<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
            this.Id = new Random().Next(1000, 2000);
        }

    }
}

